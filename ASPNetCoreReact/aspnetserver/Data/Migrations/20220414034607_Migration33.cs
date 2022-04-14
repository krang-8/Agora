using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class Migration33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 3,
                column: "CartID",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 5,
                column: "CartID",
                value: 2000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 3,
                column: "CartID",
                value: 5000);

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 5,
                column: "CartID",
                value: 10000);
        }
    }
}
