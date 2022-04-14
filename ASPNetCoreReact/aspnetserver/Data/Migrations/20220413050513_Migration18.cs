using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class Migration18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "password",
                value: "password");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "password",
                value: "password");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "password", "userType", "username" },
                values: new object[] { 7, "password", 1, "User 7" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "password", "userType", "username" },
                values: new object[] { 8, "password", 0, "User 8" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "password", "userType", "username" },
                values: new object[] { 11, "password", 1, "User 11" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "password", "userType", "username" },
                values: new object[] { 12, "password", 0, "User 12" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "password",
                value: "This is item 3 and it is very cheap.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "password",
                value: "This is item 4 and it is very cheap.");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "password", "userType", "username" },
                values: new object[] { 1, "This is item 1 and it is very cheap.", 1, "User 1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "password", "userType", "username" },
                values: new object[] { 2, "This is item 2 and it is very cheap.", 0, "User 2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "password", "userType", "username" },
                values: new object[] { 5, "This is item 5 and it is very cheap.", 1, "User 5" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "password", "userType", "username" },
                values: new object[] { 6, "This is item 6 and it is very cheap.", 0, "User 6" });
        }
    }
}
