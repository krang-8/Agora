using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userType",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 1,
                column: "Description",
                value: "This is item 1 and it is very cheap.");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 2,
                column: "Description",
                value: "This is item 2 and it is very cheap.");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 3,
                column: "Description",
                value: "This is item 3 and it is very cheap.");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 4,
                column: "Description",
                value: "This is item 4 and it is very cheap.");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 5,
                column: "Description",
                value: "This is item 5 and it is very cheap.");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 6,
                column: "Description",
                value: "This is item 6 and it is very cheap.");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address1", "Address2", "Address3", "cartID", "name", "password", "userType", "username" },
                values: new object[] { 1, "My Location 1", "My Location 2", "My Location 3", 1000, "My name is Agent 1", "This is item 1 and it is very cheap.", 1, "Post 1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address1", "Address2", "Address3", "cartID", "name", "password", "userType", "username" },
                values: new object[] { 2, "My Location 1", "My Location 2", "My Location 3", 2000, "My name is Agent 2", "This is item 2 and it is very cheap.", 0, "Post 2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address1", "Address2", "Address3", "cartID", "name", "password", "userType", "username" },
                values: new object[] { 3, "My Location 1", "My Location 2", "My Location 3", 3000, "My name is Agent 3", "This is item 3 and it is very cheap.", 1, "Post 3" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address1", "Address2", "Address3", "cartID", "name", "password", "userType", "username" },
                values: new object[] { 4, "My Location 1", "My Location 2", "My Location 3", 4000, "My name is Agent 4", "This is item 4 and it is very cheap.", 0, "Post 4" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address1", "Address2", "Address3", "cartID", "name", "password", "userType", "username" },
                values: new object[] { 5, "My Location 1", "My Location 2", "My Location 3", 5000, "My name is Agent 5", "This is item 5 and it is very cheap.", 1, "Post 5" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address1", "Address2", "Address3", "cartID", "name", "password", "userType", "username" },
                values: new object[] { 6, "My Location 1", "My Location 2", "My Location 3", 6000, "My name is Agent 6", "This is item 6 and it is very cheap.", 0, "Post 6" });
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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "userType",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 1,
                column: "Description",
                value: "This is post 1 and it has some very interesting content. I have also liked the video and subscribed.");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 2,
                column: "Description",
                value: "This is post 2 and it has some very interesting content. I have also liked the video and subscribed.");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 3,
                column: "Description",
                value: "This is post 3 and it has some very interesting content. I have also liked the video and subscribed.");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 4,
                column: "Description",
                value: "This is post 4 and it has some very interesting content. I have also liked the video and subscribed.");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 5,
                column: "Description",
                value: "This is post 5 and it has some very interesting content. I have also liked the video and subscribed.");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 6,
                column: "Description",
                value: "This is post 6 and it has some very interesting content. I have also liked the video and subscribed.");
        }
    }
}
