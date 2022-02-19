using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchedulerWebApi.Migrations
{
    public partial class EmployeeRelatedTablesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesDefaultWeeks_Employees_EmployeeId",
                table: "EmployeesDefaultWeeks");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesDefaultWeeks_EmployeeId",
                table: "EmployeesDefaultWeeks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EmployeesDefaultWeeks_EmployeeId",
                table: "EmployeesDefaultWeeks",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesDefaultWeeks_Employees_EmployeeId",
                table: "EmployeesDefaultWeeks",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
