﻿namespace SchedulerWebApi.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public EmployeeDefaultWeek DefaultWeek { get; set; }
    }
}
