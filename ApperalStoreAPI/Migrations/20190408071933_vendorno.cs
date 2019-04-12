using Microsoft.EntityFrameworkCore.Migrations;

namespace ApperalStoreAPI.Migrations
{
    public partial class vendorno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "VendorPhoneNo",
                table: "Vendors",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VendorPhoneNo",
                table: "Vendors",
                nullable: true,
                oldClrType: typeof(double));
        }
    }
}
