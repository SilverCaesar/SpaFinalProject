using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Customer_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAccount = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Customer_Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Service_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Service_Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecializationService_Id = table.Column<int>(type: "int", nullable: true),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Service_SpecializationService_Id",
                        column: x => x.SpecializationService_Id,
                        principalTable: "Service",
                        principalColumn: "Service_Id");
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Appointment_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Id = table.Column<int>(type: "int", nullable: false),
                    Employee_Id = table.Column<int>(type: "int", nullable: false),
                    Service_Id = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Appointment_Id);
                    table.ForeignKey(
                        name: "FK_Appointment_Customer_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customer",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointment_Employee_Employee_Id",
                        column: x => x.Employee_Id,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointment_Service_Service_Id",
                        column: x => x.Service_Id,
                        principalTable: "Service",
                        principalColumn: "Service_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Customer_Id",
                table: "Appointment",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Employee_Id",
                table: "Appointment",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Service_Id",
                table: "Appointment",
                column: "Service_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_SpecializationService_Id",
                table: "Employee",
                column: "SpecializationService_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Service");
        }
    }
}
