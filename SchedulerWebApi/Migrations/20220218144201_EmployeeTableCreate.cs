using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchedulerWebApi.Migrations
{
    public partial class EmployeeTableCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersDefaultWeeks");

            migrationBuilder.DropTable(
                name: "UsersMonths");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesDefaultWeeks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Saturday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sunday = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesDefaultWeeks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesDefaultWeeks_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesMonths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_31 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesMonths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesMonths_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesDefaultWeeks_EmployeeId",
                table: "EmployeesDefaultWeeks",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesMonths_EmployeeId",
                table: "EmployeesMonths",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeesDefaultWeeks");

            migrationBuilder.DropTable(
                name: "EmployeesMonths");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "UsersDefaultWeeks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Friday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Saturday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sunday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thursday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tuesday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wednesday = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersDefaultWeeks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersDefaultWeeks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersMonths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Day_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_31 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Day_9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersMonths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersMonths_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersDefaultWeeks_UserId",
                table: "UsersDefaultWeeks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersMonths_UserId",
                table: "UsersMonths",
                column: "UserId");
        }
    }
}
