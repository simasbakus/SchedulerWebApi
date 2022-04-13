using Microsoft.EntityFrameworkCore;
using SchedulerWebApi.Entities;
using SchedulerWebApi.Models;

namespace SchedulerWebApi.Repositories
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private DataContext _context;

        public EmployeesRepository(DataContext context)
        {
            _context = context;
        }

        public List<Employee> GetAllEmployees(bool includeDefaultWeek = true)
        {
            if (includeDefaultWeek)
            {
                return _context.Employees.Include(e => e.DefaultWeek).ToList();
            }

            return _context.Employees.ToList();
        }

        public Employee? GetEmployeeById(int employeeId, bool includeDefaultWeek = true)
        {
            if (includeDefaultWeek)
            {
                return _context.Employees.Include(e => e.DefaultWeek).FirstOrDefault(e => e.Id == employeeId);
            }

            return _context.Employees.FirstOrDefault(e => e.Id == employeeId);
        }

        public Employee CreateEmployee(Employee newEmployee)
        {
            var result = _context.Employees.Add(newEmployee);
            _context.SaveChanges();

            return result.Entity;
        }

        public void UpdateEmployee(int employeeId, EmployeeDTO updatedEmployee, bool updateFullEmployee = true)
        {
            var currentEmployee = GetEmployeeById(employeeId, updateFullEmployee);

            if (currentEmployee != null)
            {
                _context.Entry(currentEmployee).CurrentValues.SetValues(updatedEmployee);

                if (updateFullEmployee)
                    _context.Entry(currentEmployee.DefaultWeek).CurrentValues.SetValues(updatedEmployee.DefaultWeek);

                _context.SaveChanges();
            }
        }
    }
}
