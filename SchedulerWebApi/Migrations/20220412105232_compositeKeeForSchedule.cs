using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchedulerWebApi.Migrations
{
    public partial class compositeKeeForSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeesMonths",
                table: "EmployeesMonths");

            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "EmployeesMonths",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeesMonths",
                table: "EmployeesMonths",
                columns: new[] { "EmployeeId", "Month" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeesMonths",
                table: "EmployeesMonths");

            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeesMonths",
                table: "EmployeesMonths",
                column: "Id");
        }
    }
}
