using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AkcelitaTest.Migrations
{
    public partial class AddressMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addreses_AddressId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addreses",
                table: "Addreses");

            migrationBuilder.RenameTable(
                name: "Addreses",
                newName: "Addresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Addreses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addreses",
                table: "Addreses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addreses_AddressId",
                table: "Orders",
                column: "AddressId",
                principalTable: "Addreses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
