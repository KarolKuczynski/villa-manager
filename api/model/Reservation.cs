using System;
using System.ComponentModel.DataAnnotations;

namespace model
{
    public class Reservation : Entity
    {
        [Required]
        public virtual Guest Guest { get; set; }
        [Required]
        public virtual Room Room { get; set; }
        public int HowManyGuests { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Comments { get; set; }
        [Required]
        public ReservationStatus Status { get; set; }
        [Required]
        public virtual Price Cost { get; set; }

        public string CloseComments { get; set; }
        public GuestRate CloseRate { get; set; }
    }
}
