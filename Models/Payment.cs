using System.ComponentModel.DataAnnotations;

namespace OnlineHotelManagementSystemAPI.Models
{
    public class Payment
    {
        [Key]
        public Guid PaymentID { get; set; }
        public float Total { get; set; }
        public DateTime PayTime { get; set; }
        public string CreditCardDetails { get; set; }
    }
}
