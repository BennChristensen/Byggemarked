using System.Collections.Generic;

namespace HomeDepotWebApp.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}