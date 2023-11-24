using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseEditor.Migrations
{
    /// <inheritdoc />
    public partial class PurchasesChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Purchases_PurchasesId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Purchases_Id_Product",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_Id_Product",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Products_PurchasesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PurchasesId",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_Id_Product",
                table: "Purchases",
                column: "Id_Product",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Products_Id_Product",
                table: "Purchases",
                column: "Id_Product",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Products_Id_Product",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_Id_Product",
                table: "Purchases");

            migrationBuilder.AddColumn<int>(
                name: "PurchasesId",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_Id_Product",
                table: "Purchases",
                column: "Id_Product");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PurchasesId",
                table: "Products",
                column: "PurchasesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Purchases_PurchasesId",
                table: "Products",
                column: "PurchasesId",
                principalTable: "Purchases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Purchases_Id_Product",
                table: "Purchases",
                column: "Id_Product",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
