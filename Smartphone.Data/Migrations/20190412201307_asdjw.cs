using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone.Data.Migrations
{
    public partial class asdjw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BackCamera",
                table: "Models",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Battery",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BuiltInMemory",
                table: "Models",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CapacityOfBattery",
                table: "Models",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FrontCamera",
                table: "Models",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HasFinger",
                table: "Models",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasTwoSim",
                table: "Models",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Models",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ModelYear",
                table: "Models",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Network",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Processor",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RAM",
                table: "Models",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "SizeInInches",
                table: "Models",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "SlotForMemory",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Thickness",
                table: "Models",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfSim",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Models",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "Models",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackCamera",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Battery",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "BuiltInMemory",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "CapacityOfBattery",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "FrontCamera",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "HasFinger",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "HasTwoSim",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "ModelYear",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Network",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Processor",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "RAM",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "SizeInInches",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "SlotForMemory",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Thickness",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "TypeOfSim",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Models");
        }
    }
}
