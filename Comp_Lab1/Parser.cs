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
            
            private readonly TokenType[] _expectedSequence = 
            {
                TokenType.KeywordConst,
                TokenType.KeywordVal,
                TokenType.Identifier,
                TokenType.Assignment,
                TokenType.StringConstant,
                TokenType.Semicolon
            };

            public Parser(List<Token> tokens)
            {
                _tokens = tokens;
            }

            public void Analyze()
            {
                int i = 0;

                while (i < _tokens.Count)
                {
                    while (i < _tokens.Count && 
                           _tokens[i].Code == (int)TokenType.Error) 
                    {
                        Errors.Add(new ParserError { 
                            Token = _tokens[i], 
                            Message = $"Лексическая ошибка: {_tokens[i].TypeName} {_tokens[i].Value}" 
                        });
                        i++;
                    }
                    if (i >= _tokens.Count) break;
                    if (_tokens[i].Code != (int)TokenType.KeywordConst && _tokens[i].Code != (int)TokenType.KeywordVal)
                    {
                        Errors.Add(new ParserError {
                            Token = _tokens[i],
                            Message = "Пропущен обязательный элемент: 'const'"
                        });
                        i++;      
                        continue; 
                    }

                    if (i >= _tokens.Count) break;
                    int state = 0;
                    bool wasStarted = false; 

                    while (state < _expectedSequence.Length && i < _tokens.Count)
                    {
                        var currentToken = _tokens[i];

                        if (currentToken.Code == (int)TokenType.Error)
                        {
                            Errors.Add(new ParserError { 
                                Token = currentToken, 
                                Message = $"Лексическая ошибка: {currentToken.TypeName} '{currentToken.Value}'" 
                            });
                            state++;
                            i++;
                            wasStarted = true;
                            continue;
                        }

                        if (currentToken.Code == (int)_expectedSequence[state])
                        {
                            state++;
                            i++;
                            wasStarted = true; 
                        }
                        else
                        {
                            bool foundExpectedAhead = false;
                            int lookaheadIndex = i;

                            while (lookaheadIndex < _tokens.Count && _tokens[lookaheadIndex].Code != (int)TokenType.Semicolon)
                            {
                                if (_tokens[lookaheadIndex].Code == (int)_expectedSequence[state])
                                {
                                    foundExpectedAhead = true;
                                    break;
                                }
                                lookaheadIndex++;
                            }

                            if (foundExpectedAhead)
                            {
                                for (int k = i; k < lookaheadIndex; k++)
                                {
                                    Errors.Add(new ParserError {
                                        Token = _tokens[k],
                                        Message = $"Лишний элемент '{_tokens[k].Value}' перед '{GetTokenName(_expectedSequence[state])}'"
                                    });
                                }
                                i = lookaheadIndex; 
                            }
                            else
                            {
                                Errors.Add(new ParserError {
                                    Token = currentToken,
                                    Message = $"Пропущен обязательный элемент: '{GetTokenName(_expectedSequence[state])}'"
                                });
                                
                                state++; 
                                wasStarted = true;
                            }
                        }
                    }

                    while (wasStarted && state < _expectedSequence.Length && i >= _tokens.Count)
                    {
                        var lastToken = _tokens.LastOrDefault() ?? new Token { Line = 1, StartPos = 1, EndPos = 1 };
                        Errors.Add(new ParserError 
                        {
                            Token = lastToken,
                            Message = $"Неожиданный конец кода. Не хватает: '{GetTokenName(_expectedSequence[state])}'"
                        });
                        state++;
                    }
                }
            }
        
            private string GetTokenName(TokenType type)
            {
                switch (type)
                {
                    case TokenType.KeywordConst: return "const";
                    case TokenType.KeywordVal: return "val";
                    case TokenType.Identifier: return "идентификатор";
                    case TokenType.Assignment: return "=";
                    case TokenType.StringConstant: return "строковая константа ";
                    case TokenType.Semicolon: return ";";
                    default: return type.ToString();
                }
            }
        }
    }