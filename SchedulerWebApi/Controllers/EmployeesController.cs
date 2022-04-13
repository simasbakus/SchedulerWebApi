using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchedulerWebApi.Entities;
using SchedulerWebApi.Models;
using SchedulerWebApi.Repositories;

namespace SchedulerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeesRepository _repository;
        public EmployeesController(IEmployeesRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            try
            {
                var employees = _repository.GetAllEmployees();

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
                var employee = _repository.GetEmployeeById(employeeId);

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
                var newEmployee = _repository.CreateEmployee(employee);

                return Ok(newEmployee);
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
                _repository.UpdateEmployee(employeeId, updatedEmployee);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
