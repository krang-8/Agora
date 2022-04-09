using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6);

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    itemPrice = table.Column<int>(type: "INTEGER", maxLength: 9999, nullable: false),
                    SellerID = table.Column<int>(type: "INTEGER", maxLength: 9999, nullable: false),
                    stock = table.Column<int>(type: "INTEGER", maxLength: 9999, nullable: false),
                    itemName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 10000, nullable: false),
                    image = table.Column<string>(type: "TEXT", maxLength: 10000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemID);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemID", "Description", "SellerID", "image", "itemName", "itemPrice", "stock" },
                values: new object[] { 1, "This is post 1 and it has some very interesting content. I have also liked the video and subscribed.", 1000, "URL", "Post 1", 10, 50 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemID", "Description", "SellerID", "image", "itemName", "itemPrice", "stock" },
                values: new object[] { 2, "This is post 2 and it has some very interesting content. I have also liked the video and subscribed.", 2000, "URL", "Post 2", 20, 100 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemID", "Description", "SellerID", "image", "itemName", "itemPrice", "stock" },
                values: new object[] { 3, "This is post 3 and it has some very interesting content. I have also liked the video and subscribed.", 3000, "URL", "Post 3", 30, 150 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemID", "Description", "SellerID", "image", "itemName", "itemPrice", "stock" },
                values: new object[] { 4, "This is post 4 and it has some very interesting content. I have also liked the video and subscribed.", 4000, "URL", "Post 4", 40, 200 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemID", "Description", "SellerID", "image", "itemName", "itemPrice", "stock" },
                values: new object[] { 5, "This is post 5 and it has some very interesting content. I have also liked the video and subscribed.", 5000, "URL", "Post 5", 50, 250 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemID", "Description", "SellerID", "image", "itemName", "itemPrice", "stock" },
                values: new object[] { 6, "This is post 6 and it has some very interesting content. I have also liked the video and subscribed.", 6000, "URL", "Post 6", 60, 300 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 1, "This is post 1 and it has some very interesting content. I have also liked the video and subscribed.", "Post 1" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 2, "This is post 2 and it has some very interesting content. I have also liked the video and subscribed.", "Post 2" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 3, "This is post 3 and it has some very interesting content. I have also liked the video and subscribed.", "Post 3" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 4, "This is post 4 and it has some very interesting content. I have also liked the video and subscribed.", "Post 4" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 5, "This is post 5 and it has some very interesting content. I have also liked the video and subscribed.", "Post 5" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Content", "Title" },
                values: new object[] { 6, "This is post 6 and it has some very interesting content. I have also liked the video and subscribed.", "Post 6" });
        }
    }
}
