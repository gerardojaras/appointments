using System.Collections.Generic;

namespace DrAppointments.Core.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public List<Email> Email { get; set; }
        public List<PhoneNumber> Phone { get; set; }
    }
}