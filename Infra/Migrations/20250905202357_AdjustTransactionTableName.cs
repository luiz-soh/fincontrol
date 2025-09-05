using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdjustTransactionTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinTransaction_category_category_id",
                table: "FinTransaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FinTransaction",
                table: "FinTransaction");

            migrationBuilder.RenameTable(
                name: "FinTransaction",
                newName: "fin_transaction");

            migrationBuilder.RenameIndex(
                name: "IX_FinTransaction_category_id",
                table: "fin_transaction",
                newName: "IX_fin_transaction_category_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fin_transaction",
                table: "fin_transaction",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_fin_transaction_category_category_id",
                table: "fin_transaction",
                column: "category_id",
                principalTable: "category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fin_transaction_category_category_id",
                table: "fin_transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_fin_transaction",
                table: "fin_transaction");

            migrationBuilder.RenameTable(
                name: "fin_transaction",
                newName: "FinTransaction");

            migrationBuilder.RenameIndex(
                name: "IX_fin_transaction_category_id",
                table: "FinTransaction",
                newName: "IX_FinTransaction_category_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FinTransaction",
                table: "FinTransaction",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_FinTransaction_category_category_id",
                table: "FinTransaction",
                column: "category_id",
                principalTable: "category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
