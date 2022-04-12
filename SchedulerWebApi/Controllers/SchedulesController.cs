﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchedulerWebApi.Entities;
using SchedulerWebApi.Models;
using SchedulerWebApi.Repositories;

namespace SchedulerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulesController : ControllerBase
    {
        private const string DATE_FORMAT = "yyyy-MM";
        private ISchedulesRepository _repository;

        public SchedulesController(ISchedulesRepository schedulesRepository)
        {
            _repository = schedulesRepository;
        }

        [HttpGet("Generate/{month}")]
        public IActionResult GenerateSchedule(string month)
        {
            try
            {
                var monthDate = DateTime.ParseExact(month, DATE_FORMAT, null);

                var schedule = _repository.GenerateSchedule(monthDate);

                return Ok(schedule);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{employeeId}/{month}")]
        public IActionResult GetMonthScheduleByEmployee(int employeeId, string month)
        {
            try
            {
                var result = _repository.GetByKey(employeeId, month);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{employeeId}/{month}")]
        public IActionResult UpdateEmployeeMonthSchedule(int employeeId, string month, [FromBody] EmployeeMonthDTO newSchedule)
        {
            try
            {
                _repository.Update(employeeId, month, newSchedule);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
