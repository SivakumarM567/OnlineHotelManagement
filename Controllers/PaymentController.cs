using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementSystemAPI.Data;
using OnlineHotelManagementSystemAPI.Models;

namespace OnlineHotelManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly HotelDbContext dbContext;

        public PaymentController(HotelDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // POST api/<PaymentController>
        [HttpPost]
        public IActionResult Post(Payment addPayment)
        {

            dbContext.Payment.Add(addPayment);
            dbContext.SaveChanges();

            return Ok(dbContext.Payment.ToList());
        }
    }
}
