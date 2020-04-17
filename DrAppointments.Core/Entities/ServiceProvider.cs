using System.Collections.Generic;

namespace DrAppointments.Core.Entities
{
    public class ServiceProvider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public List<PhoneNumber> Phone { get; set; }
        public string Logo { get; set; }
        public List<Email> Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}