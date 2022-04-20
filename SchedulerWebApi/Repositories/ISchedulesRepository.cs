using SchedulerWebApi.Entities;
using SchedulerWebApi.Models;

namespace SchedulerWebApi.Repositories
{
    public interface ISchedulesRepository
    {
        List<EmployeeMonth> GenerateSchedule(DateTime monthDate);
        EmployeeMonth? GetByEmployeeIdAndMonth(int employeeId, string month);
        void DeleteByMonth(string month);
        List<EmployeeMonth> GetAllSchedules();
    }
}
