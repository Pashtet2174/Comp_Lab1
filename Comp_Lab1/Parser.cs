using System.Collections.Generic;
using System.Linq;

namespace Comp_Lab1
{
    public class ParserError
    {
        public Token Token { get; set; }
        public string Message { get; set; }
    }

    public class Parser
    {
        private readonly List<Token> _tokens;
        public List<ParserError> Errors { get; } = new List<ParserError>();

        public Parser(List<Token> tokens)
        {
            _tokens = tokens.Where(t => t.Code != (int)TokenType.Whitespace).ToList();
        }

        public void Analyze()
        {
            var expectedSequence = new[]
            {
                TokenType.KeywordConst,
                TokenType.KeywordVal,
                TokenType.Identifier,
                TokenType.Assignment,
                TokenType.StringConstant,
                TokenType.Semicolon
            };

            int tokIdx = 0; 

            while (tokIdx < _tokens.Count)
            {
                int reqIdx = 0; 

                while (tokIdx < _tokens.Count && reqIdx < expectedSequence.Length)
                {
                    var actualTok = _tokens[tokIdx];
                    
                    if (actualTok.Code == 99)
                    {
                        Errors.Add(new ParserError { Token = actualTok, Message = actualTok.TypeName });
                        
                        if (expectedSequence[reqIdx] == TokenType.StringConstant)
                        {
                            reqIdx++; 
                        }
                        tokIdx++;
                        continue;
                    }

                    if ((TokenType)actualTok.Code == expectedSequence[reqIdx])
                    {
                        reqIdx++;
                        tokIdx++;
                    }
                    else
                    {
                        Errors.Add(new ParserError {
                            Token = actualTok,
                            Message = $"Ожидалось '{GetTokenName(expectedSequence[reqIdx])}', но встречено '{actualTok.Value}'"
                        });
                        
                        int matchIdx = -1;
                        for (int i = reqIdx + 1; i < expectedSequence.Length; i++)
                        {
                            if (expectedSequence[i] == (TokenType)actualTok.Code) { matchIdx = i; break; }
                        }

                        if (matchIdx != -1) reqIdx = matchIdx; 
                        else tokIdx++;
                    }
                }

                if (reqIdx < expectedSequence.Length && tokIdx >= _tokens.Count)
                {
                    while (reqIdx < expectedSequence.Length)
                    {
                        var lastPos = _tokens.LastOrDefault() ?? new Token { Line = 1, StartPos = 1, EndPos = 1 };
                        Errors.Add(new ParserError {
                            Token = lastPos,
                            Message = $"Отсутствует обязательный элемент: '{GetTokenName(expectedSequence[reqIdx])}'"
                        });
                        reqIdx++;
                    }
                }
            }
        }
        private string GetTokenName(TokenType type)
        {
            return type switch
            {
                TokenType.KeywordConst => "const",
                TokenType.KeywordVal => "val",
                TokenType.Identifier => "идентификатор",
                TokenType.Assignment => "=",
                TokenType.StringConstant => "строковая константа",
                TokenType.Semicolon => ";",
                _ => type.ToString()
            };
        }
    }
}