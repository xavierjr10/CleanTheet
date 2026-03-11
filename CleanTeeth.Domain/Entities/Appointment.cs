using CleanTeeth.Domain.Enums;
using CleanTeeth.Domain.Exceptions;
using CleanTeeth.Domain.ValuesObjects;
namespace CleanTeeth.Domain.Entities;

public class Appointment
{
    public Guid Id { get; private set; }
    public Guid PatientId { get; private set; }
    public Guid DentistId { get; private set; }
    public Guid DentalOfficeId { get; private set; }
    public AppointmentStatus Status { get; private set; }

    // public DateTime StartDate { get; private set; }
    //public DateTime EndDate { get; private set; }
    public TimeInterval Date { get; private set; }

    //Propiedades que facilitan la navegación entre entidades
    public Patient? Patient { get; private set; }
    public Dentist? Dentist { get; private set; }
    public DentalOffice? DentalOffice { get; private set; }
    public Appointment(Guid patientId, Guid dentistId, Guid dentalOfficeId,
                       TimeInterval date)

    {

        if (date.Start < DateTime.UtcNow)
        {
            throw new BusinessRuleException($"La fecha de inicio no puede ser anterior a la fecha actual ");
        }

        PatientId = patientId;
        DentistId = dentistId;
        DentalOfficeId = dentalOfficeId;
        Status = AppointmentStatus.Scheduled;
        //StartDate = startDate;
        //EndDate = endDate;
        Date = date;
        Id = Guid.CreateVersion7();

    }
    public void Cancel()
    {
        if (Status != AppointmentStatus.Scheduled)
        {
            throw new BusinessRuleException($"Solo pueden cancelar una cita que estén programadas");

        }
        Status = AppointmentStatus.Cancelled;

    }
    public void Complete()
    {
        if (Status != AppointmentStatus.Scheduled)
        {
            throw new BusinessRuleException($"Solo pueden completar citas que estén programadas");

        }
        Status = AppointmentStatus.Completed;

    }
}
