using System.ComponentModel.DataAnnotations;

namespace OnlineHotelManagementSystemAPI.Models
{
    public class Room
    {
        [Key]
        public Guid RoomID { get; set; }
        public bool RoomStatus { get; set; }
        public string RoomComment { get; set; }
        public string RoomInventory { get; set; }
        public float RoomPrice { get; set; }
    }
}
