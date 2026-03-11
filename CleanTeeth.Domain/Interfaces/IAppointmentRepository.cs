using CleanTeeth.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanTeeth.Domain.Interfaces;

internal interface IAppointmentRepository
{

    void Add(Appointment appointment);

    bool DentistBusy(Guid dentistId, DateTime start);
}


