namespace SchedulerWebApi.Models
{
    public class EmployeeDTO
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public EmployeeDefaultWeekDTO DefaultWeek { get; set; }
    }
}
