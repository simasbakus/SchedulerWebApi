using SchedulerWebApi.Entities;
using SchedulerWebApi.Models;

namespace SchedulerWebApi.Repositories
{
    public interface IEmployeesRepository
    {
        List<Employee> GetAllEmployees(bool includeDefaultWeek = true);
        Employee? GetEmployeeById(int employeeId, bool includeDefaultWeek = true);
        Employee CreateEmployee(Employee newEmployee);
        void UpdateEmployee(int employeeId, EmployeeDTO updatedEmployee, bool updateFullEmployee = true);
    }
}
