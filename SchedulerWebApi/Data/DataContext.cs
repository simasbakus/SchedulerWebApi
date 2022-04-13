using Microsoft.EntityFrameworkCore;
using SchedulerWebApi.Entities;

namespace SchedulerWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeMonth> EmployeesMonths { get; set; }
        public DbSet<EmployeeDefaultWeek> EmployeesDefaultWeeks { get; set; }
        public DbSet<EmployeeMonthDay> EmployeesMonthDays { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeMonth>().HasAlternateKey(em => new { em.EmployeeId, em.Month });
        }
    }
}
