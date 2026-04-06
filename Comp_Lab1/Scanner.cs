using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Comp_Lab1
{
    public enum TokenType
    {
        KeywordConst = 1,  // const
        KeywordVal = 2,    // val
        Identifier = 3,    // Имена 
        StringConstant = 4, // "строковая константа"
        Assignment = 10,   // =
        Semicolon = 16,    // ;
        Error = 99         // ошибка
    }
    public class Token
    {
        public int Code { get; set; }
        public string TypeName { get; set; }
        public string Value { get; set; }
        public int Line { get; set; }
        public int StartPos { get; set; }
        public int EndPos { get; set; }
    }
    public class Scanner
    {
        private readonly string _source;
        private readonly Dictionary<string, TokenType> _keywords = new Dictionary<string, TokenType> 
        { 
            { "const", TokenType.KeywordConst }, 
            { "val", TokenType.KeywordVal } 
        };
        public Scanner(string source)
        {
            _source = source;
        } 
        public List<Token> Analyze()
        {
            var tokens = new List<Token>();
            int i = 0;
            int currentLine = 1;
            int lineStartPos = 0;

            while (i < _source.Length)
            {
                char c = _source[i];
                int startInLine = i - lineStartPos + 1;

                if (char.IsWhiteSpace(c))
                {
                    if (c == '\n') 
                    { 
                        currentLine++; 
                        lineStartPos = i + 1; 
                    }
                    i++;
                    continue; 
                }

                if (c == '"')
                {
                    int start = i;
                    i++; 
                    
                    while (i < _source.Length && _source[i] != '"' && _source[i] != '\n') 
                    {
                        i++;
                    }

                    if (i < _source.Length && _source[i] == '"')
                    {
                        i++;
                        string val = _source.Substring(start, i - start);
                        tokens.Add(CreateToken(TokenType.StringConstant, Label.TypeString, val, currentLine, startInLine, i - lineStartPos));
                    }
                    else
                    {
                        tokens.Add(CreateToken(TokenType.Error, Label.TypeErrorString, _source.Substring(start, i - start), currentLine, startInLine, i - lineStartPos));
                    }
                    continue;
                }

                if (char.IsLetter(c) || c == '_')
                {
                    int start = i;
                    while (i < _source.Length && (char.IsLetterOrDigit(_source[i]) || _source[i] == '_')) i++;
                    string val = _source.Substring(start, i - start);
                    
                    if (_keywords.TryGetValue(val, out TokenType keywordType))
                        tokens.Add(CreateToken(keywordType, Label.TypeKeyword, val, currentLine, startInLine, i - lineStartPos));
                    else
                        tokens.Add(CreateToken(TokenType.Identifier, Label.TypeIdentifier, val, currentLine, startInLine, i - lineStartPos));
                    continue;
                }

                if (c == '=')
                {
                    tokens.Add(CreateToken(TokenType.Assignment, Label.TypeAssign, "=", currentLine, startInLine, startInLine));
                    i++; continue;
                }
                if (c == ';')
                {
                    tokens.Add(CreateToken(TokenType.Semicolon, Label.TypeSemicolon, ";", currentLine, startInLine, startInLine));
                    i++; continue;
                }

                tokens.Add(CreateToken(TokenType.Error, Label.TypeErrorSymbol, c.ToString(), currentLine, startInLine, startInLine));
                i++;
            }
            return tokens;
        }

        private Token CreateToken(TokenType type, string name, string val, int line, int start, int end)
        {
            return new Token { Code = (int)type, TypeName = name, Value = val, Line = line, StartPos = start, EndPos = end };
        }
    }
}