using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseEditor.Migrations
{
    /// <inheritdoc />
    public partial class ListPurchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Purchases_Id_Product",
                table: "Purchases");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_Id_Product",
                table: "Purchases",
                column: "Id_Product");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Purchases_Id_Product",
                table: "Purchases");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_Id_Product",
                table: "Purchases",
                column: "Id_Product",
                unique: true);
        }
    }
}
