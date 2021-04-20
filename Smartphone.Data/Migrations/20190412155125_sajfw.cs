using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone.Data.Migrations
{
    public partial class sajfw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telephones_Makes_MakeId",
                table: "Telephones");

            migrationBuilder.DropForeignKey(
                name: "FK_Telephones_Models_ModelId",
                table: "Telephones");

            migrationBuilder.DropIndex(
                name: "IX_Telephones_MakeId",
                table: "Telephones");

            migrationBuilder.DropIndex(
                name: "IX_Telephones_ModelId",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "MakeId",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Telephones");

            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Telephones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Telephones",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Charachteristics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ModelYear = table.Column<int>(nullable: false),
                    Network = table.Column<string>(nullable: true),
                    Battery = table.Column<string>(nullable: true),
                    CapacityOfBattery = table.Column<int>(nullable: false),
                    HasTwoSim = table.Column<bool>(nullable: false),
                    TypeOfSim = table.Column<string>(nullable: true),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Thickness = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    RAM = table.Column<int>(nullable: false),
                    MyProperty = table.Column<int>(nullable: false),
                    BuiltInMemory = table.Column<int>(nullable: false),
                    SlotForMemory = table.Column<string>(nullable: true),
                    Processor = table.Column<string>(nullable: true),
                    SizeInInches = table.Column<double>(nullable: false),
                    FrontCamera = table.Column<int>(nullable: false),
                    BackCamera = table.Column<int>(nullable: false),
                    HasFinger = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charachteristics", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Charachteristics");

            migrationBuilder.DropColumn(
                name: "Make",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Telephones");

            migrationBuilder.AddColumn<int>(
                name: "MakeId",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Telephones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Telephones_MakeId",
                table: "Telephones",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Telephones_ModelId",
                table: "Telephones",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Telephones_Makes_MakeId",
                table: "Telephones",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "MakeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telephones_Models_ModelId",
                table: "Telephones",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
