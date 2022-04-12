using SchedulerWebApi.Entities;
using SchedulerWebApi.Models;

namespace SchedulerWebApi.Repositories
{
    public interface ISchedulesRepository
    {
        List<EmployeeMonth> GenerateSchedule(DateTime monthDate);
        EmployeeMonth? GetByKey(int employeeId, string month);
        void Update(int employeeId, string month, EmployeeMonthDTO newSchedule);
    }
}
