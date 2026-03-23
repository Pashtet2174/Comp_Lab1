using Antlr4.Runtime;
using System.Collections.Generic;

namespace Comp_Lab1
{
    public class MyAntlrErrorListener : BaseErrorListener
    {
        // Список кортежей: храним сообщение И сам токен ANTLR
        public List<(string Message, IToken Token)> Errors { get; } = new List<(string, IToken)>();

        public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, 
            int line, int charPositionInLine, string msg, RecognitionException e)
        {
            // Добавляем в список и текст ошибки, и объект токена
            Errors.Add((msg, offendingSymbol));
        }
    }
}