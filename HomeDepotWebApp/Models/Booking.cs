using System;

namespace HomeDepotWebApp.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime PickUpDate { get; set; }
        public TimeSpan RentPeriod { get; set; }
        public BookingStatus Status { get; set; }
        public Tool Tool { get; set; }
        public Customer Customer { get; set; }

        public enum BookingStatus
        {
            Reserved,
            HandedOut,
            Returned
        }
    }
}