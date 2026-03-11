namespace CleanTeeth.Domain.ValuesObjects;

public sealed class TimeInterval
{
    public DateTime Start { get; }
    public DateTime End { get; }

    public TimeInterval(DateTime start, DateTime end)
    {
        if (start > end)
        {
            throw new ArgumentException("La fecha de iniciodebe ser anterior a la fecha de fin.");
        }
        Start = start;
        End = end;
    }
    
      
    }

