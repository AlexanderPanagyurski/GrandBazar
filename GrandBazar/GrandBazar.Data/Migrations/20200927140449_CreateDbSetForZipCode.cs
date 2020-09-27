using Microsoft.EntityFrameworkCore.Migrations;

namespace GrandBazar.Data.Migrations
{
    public partial class CreateDbSetForZipCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ZipCode_ZipCodeId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZipCode",
                table: "ZipCode");

            migrationBuilder.RenameTable(
                name: "ZipCode",
                newName: "ZipCodes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZipCodes",
                table: "ZipCodes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ZipCodes_ZipCodeId",
                table: "Users",
                column: "ZipCodeId",
                principalTable: "ZipCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ZipCodes_ZipCodeId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZipCodes",
                table: "ZipCodes");

            migrationBuilder.RenameTable(
                name: "ZipCodes",
                newName: "ZipCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZipCode",
                table: "ZipCode",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ZipCode_ZipCodeId",
                table: "Users",
                column: "ZipCodeId",
                principalTable: "ZipCode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
