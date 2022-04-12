﻿using Microsoft.EntityFrameworkCore;
using Nager.Date;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerWebApi.Entities
{
    public class EmployeeMonth
    {
        private const string DATE_FORMAT = "yyyy-MM";

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Month { get; set; }
        public string? Day_1 { get; set; }
        public string? Day_2 { get; set; }
        public string? Day_3 { get; set; }
        public string? Day_4 { get; set; }
        public string? Day_5 { get; set; }
        public string? Day_6 { get; set; }
        public string? Day_7 { get; set; }
        public string? Day_8 { get; set; }
        public string? Day_9 { get; set; }
        public string? Day_10 { get; set; }
        public string? Day_11 { get; set; }
        public string? Day_12 { get; set; }
        public string? Day_13 { get; set; }
        public string? Day_14 { get; set; }
        public string? Day_15 { get; set; }
        public string? Day_16 { get; set; }
        public string? Day_17 { get; set; }
        public string? Day_18 { get; set; }
        public string? Day_19 { get; set; }
        public string? Day_20 { get; set; }
        public string? Day_21 { get; set; }
        public string? Day_22 { get; set; }
        public string? Day_23 { get; set; }
        public string? Day_24 { get; set; }
        public string? Day_25 { get; set; }
        public string? Day_26 { get; set; }
        public string? Day_27 { get; set; }
        public string? Day_28 { get; set; }
        public string? Day_29 { get; set; }
        public string? Day_30 { get; set; }
        public string? Day_31 { get; set; }

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

                GetType().GetProperty($"Day_{i}")?.SetValue(this, employeeDaySchedule);
            }
        }
    }
}
