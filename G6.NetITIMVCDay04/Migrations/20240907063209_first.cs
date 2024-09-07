using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace G6.NetITIMVCDay04.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "HR" },
                    { 2, "PR" },
                    { 3, "Social Media" },
                    { 4, "Finance" },
                    { 5, "SD" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Age", "DepartmentId", "Email", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "Ismaila", 20, 1, "email@mail.com", "Ramy", 1234m },
                    { 2, "Ismaila", 25, 2, "email@mail.com", "Ali", 2234m },
                    { 3, "Ismaila", 30, 3, "email@mail.com", "Mohamed", 3234m },
                    { 4, "Ismaila", 35, 4, "email@mail.com", "Ahmed", 4234m },
                    { 5, "Ismaila", 40, 5, "email@mail.com", "Hala", 5234m },
                    { 6, "Ismaila", 45, 1, "email@mail.com", "Mai", 6234m },
                    { 7, "Ismaila", 50, 2, "email@mail.com", "Omar", 7234m },
                    { 8, "Ismaila", 55, 3, "email@mail.com", "Sara", 8234m },
                    { 9, "Ismaila", 30, 4, "email@mail.com", "Mostafa", 9234m },
                    { 10, "Ismaila", 40, 5, "email@mail.com", "Nour", 10234m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
