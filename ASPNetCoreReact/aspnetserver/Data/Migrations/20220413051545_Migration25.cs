using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class Migration25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 3,
                column: "CartID",
                value: 1000);

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 5, "addy", "ta", "bhai home", 2000, 5, "test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 3,
                column: "CartID",
                value: 2000);

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 2, "addy", "ta", "bhai home", 1000, 2, "test" });
        }
    }
}
