using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineHotelManagementSystemAPI.Data;
using OnlineHotelManagementSystemAPI.Models;

namespace OnlineHotelManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly HotelDbContext dbContext;

        public EmployeeController(HotelDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(dbContext.Staff.ToList());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult SearchEmployees(Guid id)
        {
            var emp = dbContext.Staff.Find(id);

            if (emp == null)
            {
                return NotFound();
            }

            return Ok(emp);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void AddEmployee(Staff addEmployee)
        {
            dbContext.Staff.Add(addEmployee);
            dbContext.SaveChanges();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(Guid id, [FromBody] Staff updateEmployee)
        {
            var emp = dbContext.Staff.Find(id);

            if (emp == null)
            {
                return NotFound();
            }

            emp.EmployeeName = updateEmployee.EmployeeName;

            return Ok(dbContext.SaveChanges());

        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult RemoveEmployee(Guid id)
        {
            var emp = dbContext.Staff.Find(id);

            if (emp != null)
            {
                dbContext.Remove(emp);
                dbContext.SaveChanges();
                return Ok();
            }

            return NotFound();
        }
    }
}
