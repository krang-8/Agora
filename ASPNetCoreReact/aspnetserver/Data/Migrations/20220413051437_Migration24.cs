using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class Migration24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 1, "addy", "ta", "bhai home", 0, 1, "test" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 3, "addy", "ta", "bhai home", 2000, 3, "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 2, "addy", 2, "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 4, "addy", 4, "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 6, "addy", 6, "test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 4, "addy", "ta", "bhai home", 2000, 4, "test" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 6, "addy", "ta", "bhai home", 3000, 6, "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 3, "addy", 3, "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 5, "addy", 5, "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 7, "addy", 7, "test" });
        }
    }
}
