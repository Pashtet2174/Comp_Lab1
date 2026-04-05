

using Antlr4.Runtime;

public class ErrorDetails
{
    public int Line { get; set; }
    public int Column { get; set; }
    public string OffendingText { get; set; }
    public string Message { get; set; }
}

public class AntlrUIErrorListener : BaseErrorListener
{
    public List<ErrorDetails> Errors { get; } = new List<ErrorDetails>();

    public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        Errors.Add(new ErrorDetails
        {
            Line = line,
            Column = charPositionInLine,
            OffendingText = offendingSymbol?.Text ?? "<EOF>", 
            Message = msg
        });
    }
}