using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchedulerWebApi.Migrations
{
    public partial class EmployeeEntityChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesMonths_Employees_EmployeeId",
                table: "EmployeesMonths");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesMonths_EmployeeId",
                table: "EmployeesMonths");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesDefaultWeeks_EmployeeId",
                table: "EmployeesDefaultWeeks",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesDefaultWeeks_Employees_EmployeeId",
                table: "EmployeesDefaultWeeks",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesDefaultWeeks_Employees_EmployeeId",
                table: "EmployeesDefaultWeeks");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesDefaultWeeks_EmployeeId",
                table: "EmployeesDefaultWeeks");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesMonths_EmployeeId",
                table: "EmployeesMonths",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesMonths_Employees_EmployeeId",
                table: "EmployeesMonths",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
