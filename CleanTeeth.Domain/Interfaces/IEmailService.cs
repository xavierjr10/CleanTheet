using System;
using System.Collections.Generic;
using System.Text;

namespace CleanTeeth.Domain.Interfaces;

public interface IemailService 
{
    public void Send(EmailService email, string message);

}
