using CleanTeeth.Domain.Interfaces;
using CleanTeeth.Domain.ValuesObjects;  
namespace CleanTeeth.Domain;

public class EmailService : IemailService
{
    #region
    public EmailService(Email email, string message)
    {
        Console.WriteLine($"Enviando el correo para {email} con el texto: {message}");
        //.....

    }
    public void Send(Email email, string message)
    {
        Console.WriteLine($"Enviando el correo para {email} con el texto: {message}");
        //.....
    }

    public void Send(EmailService email, string message)
    {
        throw new NotImplementedException();
    }

#endregion
}
