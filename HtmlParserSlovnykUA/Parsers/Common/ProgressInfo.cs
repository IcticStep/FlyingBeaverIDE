namespace HtmlParserSlovnykUA.Parsers.Common;

public class ProgressInfo
{
    public ProgressInfo(int operationsNeeded, int operationsDone)
    {
        OperationsNeeded = operationsNeeded;
        OperationsDone = operationsDone;
    }

    public int OperationsNeeded { get; }
    public int OperationsDone { get; }
    
    public double ProgressPercents => 
        (double)OperationsDone / OperationsNeeded;

    public double FancyProgressPercents =>
        Math.Round(ProgressPercents * 100, 2);
    
    public bool Finished =>
        OperationsDone == OperationsNeeded;

    public static ProgressInfo WithIncreasedProgress(ProgressInfo progressInfo) =>
        new(progressInfo.OperationsNeeded, progressInfo.OperationsDone + 1);

    public override string ToString() => $"{OperationsDone}/{OperationsNeeded} - {FancyProgressPercents}%";
}