using CleanTeeth.Domain.Entities;
using CleanTeeth.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanTeeth.Domain;

public class AppointmentRepository : IAppointmentRepository
{
    private List<Appointment> _appointments = new ();
    public void Add(Appointment appointment)
    {
        _appointments.Add(appointment);
    }   

    public bool DentistBusy(Guid dentistId, DateTime start)
    {
        return _appointments.Any(a => a.DentistId == dentistId && a.Date.Start == start);

    }

    //Guardar
    //...


}
