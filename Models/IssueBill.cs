using System.ComponentModel.DataAnnotations;

namespace OnlineHotelManagementSystemAPI.Models
{
    public class IssueBill
    {
        [Key]
        public Guid BillNO { get; set; }
        public int Quantity { get; set; }
        public float Prize { get; set; }
        public float Taxes { get; set; }
        public DateTime Date { get; set; }
        public int Services { get; set; }
        public int unit { get; set; }
    }
}
