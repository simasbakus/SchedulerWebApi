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

        public EmployeeMonth? GetByEmployeeIdAndMonth(int employeeId, string month)
        {
            return _context.EmployeesMonths.Include(em => em.Days).FirstOrDefault(em => em.EmployeeId == employeeId && em.Month == month);
        }

        public void DeleteByMonth(string month)
        {
            foreach (var employeeMonth in _context.EmployeesMonths.Where(em => em.Month == month))
            {
                _context.Remove(employeeMonth);
            }
            _context.SaveChanges();
        }
    }
}
