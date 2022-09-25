using System.ComponentModel.DataAnnotations;

namespace OnlineHotelManagementSystemAPI.Models
{
    public class Staff
    {
        [Key]
        public Guid EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public float Salary { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
