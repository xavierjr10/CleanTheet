using CleanTeeth.Domain.Entities;
using CleanTeeth.Domain.Exceptions;
using CleanTeeth.Domain.Interfaces;

namespace CleanTeeth.Domain;

public class AppointmentService
{
    //private readonly AppointmentRepository _repository;
    //private readonly EmailService _emailService;
    private readonly IAppointmentRepository _repository;
    //private readonly IEmailService _emailService;
    private readonly INotificationService _notificationService;

    public AppointmentService(AppointmentRepository repository, EmailNotification notification, SmsNotification smsNotification)
    {
        //_emailService = emailService;
        _repository = repository;
        _notificationService = smsNotification;
    }

    public void Schedule(Appointment appointment)
    {
        if (_repository.DentistBusy(appointment.DentistId, appointment.Date.Start))
        {
            throw new BusinessRuleException("Destista Ocupado");
        }

        _repository.Add(appointment);
        //_emailService.Send(appointment.Patient.Email, "Cita Programada");
        _notificationService.Send("Enviado por SMS");
    }
}
 