using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementSystemAPI.Data;
using OnlineHotelManagementSystemAPI.Models;

namespace OnlineHotelManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly HotelDbContext dbContext;

        public GuestController(HotelDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllGuest()
        {
            return Ok(dbContext.Guest.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetUniqueGuest(Guid id)
        {
            var search = dbContext.Guest.Find(id);

            if (search == null)
            {
                return NotFound();
            }

            return Ok(search);
        }
        // POST api/<GuestController>
        [HttpPost]
        public IActionResult Post(Guest guest)
        {

            dbContext.Guest.Add(guest);
            dbContext.SaveChanges();

            return Ok(dbContext.Guest.ToList());
        }

        // PUT api/<GuestController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Guest _guest)
        {
            var guest = dbContext.Guest.Find(id);

            if (guest == null)
            {
                return NotFound();
            }

            guest = _guest;

            return Ok(dbContext.SaveChanges());
        }
    }
}
