using CleanTeeth.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanTeeth.Domain;

public class SmsNotification : INotificationService
{
    public void Send(string menssage)
    {
        Console.WriteLine(menssage);
    }
}
