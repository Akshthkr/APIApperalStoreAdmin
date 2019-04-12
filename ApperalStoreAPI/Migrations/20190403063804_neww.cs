using Microsoft.EntityFrameworkCore.Migrations;

namespace ApperalStoreAPI.Migrations
{
    public partial class neww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Orders_OrderId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_OrderId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Feedbacks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Feedbacks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_OrderId",
                table: "Feedbacks",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Orders_OrderId",
                table: "Feedbacks",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
