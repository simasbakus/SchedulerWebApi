using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchedulerWebApi.Migrations
{
    public partial class MonthDayEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day_1",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_10",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_11",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_12",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_13",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_14",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_15",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_16",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_17",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_18",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_19",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_2",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_20",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_21",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_22",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_23",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_24",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_25",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_26",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_27",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_28",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_29",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_3",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_30",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_31",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_4",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_5",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_6",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_7",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_8",
                table: "EmployeesMonths");

            migrationBuilder.DropColumn(
                name: "Day_9",
                table: "EmployeesMonths");

            migrationBuilder.CreateTable(
                name: "EmployeesMonthDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeMonthId = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Schedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weekday = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesMonthDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesMonthDays_EmployeesMonths_EmployeeMonthId",
                        column: x => x.EmployeeMonthId,
                        principalTable: "EmployeesMonths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesMonthDays_EmployeeMonthId",
                table: "EmployeesMonthDays",
                column: "EmployeeMonthId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeesMonthDays");

            migrationBuilder.AddColumn<string>(
                name: "Day_1",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_10",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_11",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_12",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_13",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_14",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_15",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_16",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_17",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_18",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_19",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_2",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_20",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_21",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_22",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_23",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_24",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_25",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_26",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_27",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_28",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_29",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_3",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_30",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_31",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_4",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_5",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_6",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_7",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_8",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day_9",
                table: "EmployeesMonths",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
