using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class Migration11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Address3",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CartID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    BuyerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false),
                    Address1 = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Address2 = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Address3 = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    CartID = table.Column<int>(type: "INTEGER", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.BuyerId);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    SellerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 32, nullable: false),
                    Address1 = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.SellerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "Users",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Users",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address3",
                table: "Users",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CartID",
                table: "Users",
                type: "INTEGER",
                maxLength: 1000,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Users",
                type: "TEXT",
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Address1", "Address2", "Address3", "CartID", "name" },
                values: new object[] { "My Location 1", "My Location 2", "My Location 3", 1000, "My name is Agent 1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Address1", "Address2", "Address3", "CartID", "name" },
                values: new object[] { "My Location 1", "My Location 2", "My Location 3", 2000, "My name is Agent 2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "Address1", "Address2", "Address3", "CartID", "name" },
                values: new object[] { "My Location 1", "My Location 2", "My Location 3", 3000, "My name is Agent 3" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "Address1", "Address2", "Address3", "CartID", "name" },
                values: new object[] { "My Location 1", "My Location 2", "My Location 3", 4000, "My name is Agent 4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "Address1", "Address2", "Address3", "CartID", "name" },
                values: new object[] { "My Location 1", "My Location 2", "My Location 3", 5000, "My name is Agent 5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "Address1", "Address2", "Address3", "CartID", "name" },
                values: new object[] { "My Location 1", "My Location 2", "My Location 3", 6000, "My name is Agent 6" });
        }
    }
}
