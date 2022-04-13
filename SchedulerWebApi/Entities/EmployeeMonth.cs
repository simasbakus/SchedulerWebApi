using Microsoft.EntityFrameworkCore;
using Nager.Date;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerWebApi.Entities
{
    public class EmployeeMonth
    {
        private const string DATE_FORMAT = "yyyy-MM";

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Month { get; set; }
        public List<EmployeeMonthDay> Days { get; set; } = new List<EmployeeMonthDay>();

        public EmployeeMonth() { }

        public EmployeeMonth(Employee employee, DateTime monthDate)
        {
            EmployeeId = employee.Id;
            Month = monthDate.ToString(DATE_FORMAT);

            int daysInMonth = DateTime.DaysInMonth(monthDate.Year, monthDate.Month);

            for (int i = 1; i <= daysInMonth; i++)
            {
                var day = new DateTime(monthDate.Year, monthDate.Month, i);

                var employeeDaySchedule = employee.DefaultWeek.GetType().GetProperty(day.DayOfWeek.ToString())?.GetValue(employee.DefaultWeek);

                if (DateSystem.IsPublicHoliday(day, CountryCode.LT)) employeeDaySchedule = "S";

                Days.Add(new EmployeeMonthDay(day, employeeDaySchedule.ToString()));
            }
        }
    }
}
