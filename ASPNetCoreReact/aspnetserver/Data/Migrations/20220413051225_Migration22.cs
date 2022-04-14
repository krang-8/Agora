using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class Migration22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "username",
                value: "User3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "username",
                value: "User4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "password", "userType", "username" },
                values: new object[] { 1, "password", 1, "User1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "password", "userType", "username" },
                values: new object[] { 2, "password", 0, "User2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "password", "userType", "username" },
                values: new object[] { 5, "password", 1, "User5" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "password", "userType", "username" },
                values: new object[] { 6, "password", 0, "User6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
