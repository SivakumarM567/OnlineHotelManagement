using System.ComponentModel.DataAnnotations;

namespace OnlineHotelManagementSystemAPI.Models
{
    public class Reservation
    {
        [Key]
        public Guid ReservationID { get; set; } 
        public string Code { get; set; }
        public int NoOfChildren { get; set; }
        public int NoOfAdult { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Status { get; set; }
        public int NoOfNights { get; set; }
    }
}
