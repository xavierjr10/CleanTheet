using System;
using System.Collections.Generic;
using System.Text;

namespace CleanTeeth.Domain.Interfaces;

public interface INotificationService
{
    void Send(string menssage);
}
