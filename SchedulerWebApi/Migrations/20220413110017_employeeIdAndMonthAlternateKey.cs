using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchedulerWebApi.Migrations
{
    public partial class employeeIdAndMonthAlternateKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeesMonths",
                table: "EmployeesMonths");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_EmployeesMonths_EmployeeId_Month",
                table: "EmployeesMonths",
                columns: new[] { "EmployeeId", "Month" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeesMonths",
                table: "EmployeesMonths",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_EmployeesMonths_EmployeeId_Month",
                table: "EmployeesMonths");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeesMonths",
                table: "EmployeesMonths");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeesMonths",
                table: "EmployeesMonths",
                columns: new[] { "EmployeeId", "Month" });
        }
    }
}
