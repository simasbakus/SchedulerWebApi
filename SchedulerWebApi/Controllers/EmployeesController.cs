using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchedulerWebApi.Entities;
using SchedulerWebApi.Models;

namespace SchedulerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private DataContext _context;
        public EmployeesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            try
            {
                var employees = _context.Employees.Include(e => e.DefaultWeek).ToList();

                return Ok(employees);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{employeeId}")]
        public IActionResult GetEmployee(int employeeId)
        {
            try
            {
                var employee = _context.Employees.Include(e => e.DefaultWeek).FirstOrDefault(e => e.Id == employeeId);

                return Ok(employee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            try
            {
                var newEmployee = _context.Employees.Add(employee);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 

        [HttpPut("{employeeId}")]
        public IActionResult UpdateEmployee(int employeeId, [FromBody] EmployeeDTO updatedEmployee)
        {
            try
            {
                var currentEmployee = _context.Employees.Include(e => e.DefaultWeek).FirstOrDefault(e => e.Id == employeeId);

                if (currentEmployee != null)
                {
                    _context.Entry(currentEmployee).CurrentValues.SetValues(updatedEmployee);
                    _context.Entry(currentEmployee.DefaultWeek).CurrentValues.SetValues(updatedEmployee.DefaultWeek);

                    _context.SaveChanges();
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
