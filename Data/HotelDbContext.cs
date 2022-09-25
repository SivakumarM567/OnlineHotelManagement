using Microsoft.EntityFrameworkCore;
using OnlineHotelManagementSystemAPI.Models;

namespace OnlineHotelManagementSystemAPI.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Guest> Guest { get; set; }
        public DbSet<IssueBill> IssueBill { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Staff> Staff { get; set; }
    }
}
