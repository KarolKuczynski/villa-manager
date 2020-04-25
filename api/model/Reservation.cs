using System;

namespace model
{
    public class Reservation : Entity
    {
        public Guest Guest { get; set; }
        public Room Room { get; set; }
        public int HowManyGuests { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Comments { get; set; }
        public ReservationStatus Status { get; set; }
        public Price Cost { get; set; }

        public string CloseComments { get; set; }
        public GuestRate CloseRate { get; set; }
    }
}
