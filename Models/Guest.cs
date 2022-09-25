using System.ComponentModel.DataAnnotations;

namespace OnlineHotelManagementSystemAPI.Models
{
    public class Guest
    {
        [Key]
        public Guid GuestID { get; set; }
        public string MemberCode { get; set; }   
        public string PhoneNo { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
    }
}
