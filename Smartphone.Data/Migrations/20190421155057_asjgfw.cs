using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone.Data.Migrations
{
    public partial class asjgfw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Image1",
                table: "Telephones",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Telephones");
        }
    }
}
