namespace CleanTeeth.Domain.Exceptions;

public class BusinessRuleException:  Exception
{
    public BusinessRuleException(String message): base(message)
    {
        
    }
}
