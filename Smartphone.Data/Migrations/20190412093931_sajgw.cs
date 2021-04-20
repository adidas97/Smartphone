using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone.Data.Migrations
{
    public partial class sajgw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BackCamera",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Battery",
                table: "Telephones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BuiltInMemory",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CapacityOfBattery",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FrontCamera",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "HasFinger",
                table: "Telephones",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasTwoSim",
                table: "Telephones",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelYear",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Network",
                table: "Telephones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Processor",
                table: "Telephones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RAM",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "SizeInInches",
                table: "Telephones",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "SlotForMemory",
                table: "Telephones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Thickness",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfSim",
                table: "Telephones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Telephones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Make",
                columns: table => new
                {
                    MakeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOfMake = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Make", x => x.MakeId);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    ModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOfModel = table.Column<string>(nullable: true),
                    MakeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.ModelId);
                    table.ForeignKey(
                        name: "FK_Model_Make_MakeId",
                        column: x => x.MakeId,
                        principalTable: "Make",
                        principalColumn: "MakeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Telephones_UserId",
                table: "Telephones",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Model_MakeId",
                table: "Model",
                column: "MakeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Telephones_AspNetUsers_UserId",
                table: "Telephones",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telephones_AspNetUsers_UserId",
                table: "Telephones");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "Make");

            migrationBuilder.DropIndex(
                name: "IX_Telephones_UserId",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "BackCamera",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "Battery",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "BuiltInMemory",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "CapacityOfBattery",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "FrontCamera",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "HasFinger",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "HasTwoSim",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "ModelYear",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "Network",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "Processor",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "RAM",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "SizeInInches",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "SlotForMemory",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "Thickness",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "TypeOfSim",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Telephones");
        }
    }
}
