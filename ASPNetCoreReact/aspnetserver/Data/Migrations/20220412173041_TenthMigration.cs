using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class TenthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Quantity",
                table: "Carts",
                type: "TEXT",
                maxLength: 999999,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: 1000,
                column: "Quantity",
                value: "1,1,2");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: 2000,
                column: "Quantity",
                value: "1,1,2");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: 3000,
                column: "Quantity",
                value: "1,1,2");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: 4000,
                column: "Quantity",
                value: "1,1,2");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: 5000,
                column: "Quantity",
                value: "1,1,2");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: 6000,
                column: "Quantity",
                value: "1,1,2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Carts");
        }
    }
}
