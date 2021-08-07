using Microsoft.EntityFrameworkCore.Migrations;

namespace Laptop.Migrations
{
    public partial class laptopTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laptop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LaptopName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPorts = table.Column<int>(type: "int", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Screen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptop", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Laptop",
                columns: new[] { "Id", "GraphicCard", "LaptopName", "Memory", "NumberOfPorts", "Price", "Processor", "RAM", "Screen" },
                values: new object[] { 1, "nvidia 1650ti", "Omen", "1TB SSD", 10, 113958, "i7", "16GB", "144hz" });

            migrationBuilder.InsertData(
                table: "Laptop",
                columns: new[] { "Id", "GraphicCard", "LaptopName", "Memory", "NumberOfPorts", "Price", "Processor", "RAM", "Screen" },
                values: new object[] { 2, "nvidia 1650", "Pavilion Gaming", "512GB SSD", 8, 60000, "i5", "8GB", "60hz" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptop");
        }
    }
}
