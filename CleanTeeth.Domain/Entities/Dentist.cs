using CleanTeeth.Domain.Exceptions;
using CleanTeeth.Domain.ValuesObjects;
namespace CleanTeeth.Domain.Entities;

public class Dentist
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = null!;
    public string Email { get; private set; } = null!;

    public Dentist(String name, string email)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleException($"El {nameof(name)} es obligatorio");
        }
       
        Id = Guid.CreateVersion7();
        Name = name;
     
    }

}
