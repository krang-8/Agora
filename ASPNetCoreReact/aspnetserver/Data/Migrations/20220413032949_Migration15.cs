using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class Migration15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "name" },
                values: new object[] { 1, "addy", "ta", "bhai home", 1000, "test" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "name" },
                values: new object[] { 2, "addy", "ta", "bhai home", 2000, "test" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "name" },
                values: new object[] { 3, "addy", "ta", "bhai home", 3000, "test" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "name" },
                values: new object[] { 4, "addy", "ta", "bhai home", 4000, "test" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "name" },
                values: new object[] { 5, "addy", "ta", "bhai home", 5000, "test" });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address1", "Address2", "Address3", "CartID", "name" },
                values: new object[] { 6, "addy", "ta", "bhai home", 6000, "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "name" },
                values: new object[] { 1, "addy", "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "name" },
                values: new object[] { 2, "addy", "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "name" },
                values: new object[] { 3, "addy", "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "name" },
                values: new object[] { 4, "addy", "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "name" },
                values: new object[] { 5, "addy", "test" });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address1", "name" },
                values: new object[] { 6, "addy", "test" });
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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 6);
        }
    }
}
