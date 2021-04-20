using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone.Data.Migrations
{
    public partial class asfge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Image2",
                table: "Telephones",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Image3",
                table: "Telephones",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Image4",
                table: "Telephones",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Image5",
                table: "Telephones",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "Image5",
                table: "Telephones");
        }
    }
}
