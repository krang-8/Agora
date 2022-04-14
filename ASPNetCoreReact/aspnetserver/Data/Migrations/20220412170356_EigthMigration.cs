using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    public partial class EigthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CartID",
                table: "Carts",
                newName: "CartID");

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartID", "BuyerID", "cartItems" },
                values: new object[] { 1000, 1, "1,2,4" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartID", "BuyerID", "cartItems" },
                values: new object[] { 2000, 2, "1,2,4" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartID", "BuyerID", "cartItems" },
                values: new object[] { 3000, 3, "1,2,4" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartID", "BuyerID", "cartItems" },
                values: new object[] { 4000, 4, "1,2,4" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartID", "BuyerID", "cartItems" },
                values: new object[] { 5000, 5, "1,2,4" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartID", "BuyerID", "cartItems" },
                values: new object[] { 6000, 6, "1,2,4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: 4000);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: 5000);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: 6000);

            migrationBuilder.RenameColumn(
                name: "CartID",
                table: "Carts",
                newName: "CartID");
        }
    }
}
