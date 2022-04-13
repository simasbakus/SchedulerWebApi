namespace SchedulerWebApi.Entities
{
    public class EmployeeMonthDay
    {
        public int Id { get; set; }
        public int EmployeeMonthId { get; set; }
        public int Day { get; set; }
        public string Schedule { get; set; }
        public string Weekday { get; set; }

        public EmployeeMonthDay()
        {

        }

        public EmployeeMonthDay(DateTime day, string schedule)
        {
            Day = day.Day;
            Schedule = schedule;
            Weekday = day.DayOfWeek.ToString();
        }
    }
}
