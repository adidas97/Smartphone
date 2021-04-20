using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone.Data.Migrations
{
    public partial class sajfwsa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
