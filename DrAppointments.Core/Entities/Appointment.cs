using System;

namespace DrAppointments.Core.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public ServiceProvider ServiceProvider { get; set; }
        public Client Client { get; set; }
        public Employee Employee { get; set; }
    }
}