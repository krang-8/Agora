using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class Migration13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 1,
                columns: new[] { "image", "itemName" },
                values: new object[] { "https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg", "Item 1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 2,
                columns: new[] { "image", "itemName" },
                values: new object[] { "https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg", "Item 2" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 3,
                columns: new[] { "image", "itemName" },
                values: new object[] { "https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg", "Item 3" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 4,
                columns: new[] { "image", "itemName" },
                values: new object[] { "https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg", "Item 4" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 5,
                columns: new[] { "image", "itemName" },
                values: new object[] { "https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg", "Item 5" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 6,
                columns: new[] { "image", "itemName" },
                values: new object[] { "https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg", "Item 6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "username",
                value: "User 1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "username",
                value: "User 2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "username",
                value: "User 3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "username",
                value: "User 4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "username",
                value: "User 5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "username",
                value: "User 6");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 1,
                columns: new[] { "image", "itemName" },
                values: new object[] { "URL", "Post 1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 2,
                columns: new[] { "image", "itemName" },
                values: new object[] { "URL", "Post 2" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 3,
                columns: new[] { "image", "itemName" },
                values: new object[] { "URL", "Post 3" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 4,
                columns: new[] { "image", "itemName" },
                values: new object[] { "URL", "Post 4" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 5,
                columns: new[] { "image", "itemName" },
                values: new object[] { "URL", "Post 5" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 6,
                columns: new[] { "image", "itemName" },
                values: new object[] { "URL", "Post 6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "username",
                value: "Post 1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "username",
                value: "Post 2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "username",
                value: "Post 3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "username",
                value: "Post 4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "username",
                value: "Post 5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "username",
                value: "Post 6");
        }
    }
}
