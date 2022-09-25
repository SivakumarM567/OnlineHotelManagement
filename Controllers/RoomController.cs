using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementSystemAPI.Data;
using OnlineHotelManagementSystemAPI.Models;

namespace OnlineHotelManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly HotelDbContext dbContext;

        public RoomController(HotelDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: api/<RoomController>
        [HttpGet]
        public IActionResult GetAllRooms()
        {
            return Ok(dbContext.Room.ToList());
        }

        // GET api/<RoomController>/5
        [HttpGet("{id}")]
        public IActionResult GetRoom(Guid id)
        {
            var room = dbContext.Room.Find(id);

            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        // POST api/<RoomController>
        [HttpPost]
        public IActionResult AddRoom(Room _room)
        {
            var room = new Room();
            {
                room.RoomStatus = _room.RoomStatus;
                room.RoomComment = _room.RoomComment;
                room.RoomPrice = _room.RoomPrice;
                room.RoomInventory = _room.RoomInventory;
            }

            dbContext.Room.Add(room);
            return Ok(dbContext.SaveChanges());
        }

        // PUT api/<RoomController>/5
        [HttpPut("/UpdateRoomStatus/{id}")]
        public IActionResult UpdateRoomStatus(Guid id, Room _room)
        {
            var room = dbContext.Room.Find(id);

            if (room == null)
            {
                return NotFound();
            }

            room.RoomStatus = _room.RoomStatus;
            return Ok(dbContext.SaveChanges());
        }

        [HttpPut("/UpdateRoomInventory/{id}")]
        public IActionResult UpdateRoomInventory(Guid id, Room _room)
        {
            var room = dbContext.Room.Find(id);

            if (room == null)
            {
                return NotFound();
            }

            room.RoomInventory = _room.RoomInventory;
            return Ok(dbContext.SaveChanges());
        }

        [HttpPut("/UpdateRoomComment/{id}")]
        public IActionResult UpdateRoomComment(Guid id, Room _room)
        {
            var room = dbContext.Room.Find(id);

            if (room == null)
            {
                return NotFound();
            }

            room.RoomComment = _room.RoomComment;
            return Ok(dbContext.SaveChanges());
        }

        [HttpPut("/UpdateRoomPrice/{id}")]
        public IActionResult UpdateRoomPrice(Guid id, Room _room)
        {
            var room = dbContext.Room.Find(id);

            if (room == null)
            {
                return NotFound();
            }

            room.RoomPrice = _room.RoomPrice;
            return Ok(dbContext.SaveChanges());
        }

        // DELETE api/<RoomController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(Guid id)
        {
            var room = dbContext.Room.Find(id);

            if (room == null)
            {
                return NotFound();
            }

            dbContext.Room.Remove(room);
            return Ok(dbContext.SaveChanges());
        }
    }
}
