using Microsoft.EntityFrameworkCore;
using SchedulerWebApi.Entities;
using SchedulerWebApi.Models;

namespace SchedulerWebApi.Repositories
{
    public class ShedulesRepository : ISchedulesRepository
    {
        private DataContext _context;

        public ShedulesRepository(DataContext context)
        {
            _context = context;
        }

        public List<EmployeeMonth> GenerateSchedule(DateTime monthDate)
        {
            var allEmployeesSchedules = new List<EmployeeMonth>();
            var allEmployees = _context.Employees.Include(e => e.DefaultWeek).ToList();

            foreach (var employee in allEmployees)
            {
                var employeeMonth = new EmployeeMonth(employee, monthDate);

                var result = _context.EmployeesMonths.Add(employeeMonth);
                _context.SaveChanges();

                allEmployeesSchedules.Add(result.Entity);
            }

            return allEmployeesSchedules;
        }

        public EmployeeMonth? GetByKey(int employeeId, string month)
        {
            return _context.EmployeesMonths.Find(employeeId, month);
        }

        public void Update(int employeeId, string month, EmployeeMonthDTO newSchedule)
        {
            var employeeSchedule = _context.EmployeesMonths.Find(employeeId, month);

            if (employeeSchedule != null)
            {
                _context.Entry(employeeSchedule).CurrentValues.SetValues(newSchedule);

                _context.SaveChanges();
            }
        }
    }
}
