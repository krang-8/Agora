using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class Migration17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 2,
                columns: new[] { "CartID", "UserId" },
                values: new object[] { 1000, 2 });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 4, "addy", "ta", "bhai home", 2000, 4, "test" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 6, "addy", "ta", "bhai home", 3000, 6, "test" });

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 3,
                column: "UserId",
                value: 3);

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 5, "addy", 5, "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 7, "addy", 7, "test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 2,
                columns: new[] { "CartID", "UserId" },
                values: new object[] { 2000, 1 });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 1, "addy", "ta", "bhai home", 1000, 1, "test" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "UserId", "name" },
                values: new object[] { 3, "addy", "ta", "bhai home", 3000, 1, "test" });

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 3,
                column: "UserId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 1, "addy", 1, "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "UserId", "name" },
                values: new object[] { 2, "addy", 1, "test" });
        }
    }
}
