using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class Migration20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 13);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 8, "addy", "ta", "bhai home", 4000, 8, "test" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 10, "addy", "ta", "bhai home", 5000, 10, "test" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 12, "addy", "ta", "bhai home", 6000, 12, "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 9, "addy", 9, "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 11, "addy", 11, "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 13, "addy", 13, "test" });
        }
    }
}
