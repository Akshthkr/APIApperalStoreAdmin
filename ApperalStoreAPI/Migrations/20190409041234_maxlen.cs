using Microsoft.EntityFrameworkCore.Migrations;

namespace ApperalStoreAPI.Migrations
{
    public partial class maxlen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Customers",
                newName: "CustomerPhoneNumber2");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Customers",
                newName: "CustomerZipNumber2");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Customers",
                newName: "CustomerZipNumber");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customers",
                newName: "CustomerUserName");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Customers",
                newName: "CustomerState2");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "categoryName");

            migrationBuilder.AlterColumn<long>(
                name: "VendorPhoneNo",
                table: "Vendors",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<string>(
                name: "CustomerAddress1",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerAddress2",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerCountry",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerCountry2",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerFirstName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerGender",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerLastName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerPassword",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CustomerPhoneNumber",
                table: "Customers",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "CustomerState",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SameAddress",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "categoryName",
                table: "Categories",
                unicode: false,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerAddress1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerAddress2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerCountry",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerCountry2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerFirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerGender",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerLastName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerPassword",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerPhoneNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerState",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SameAddress",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "CustomerZipNumber2",
                table: "Customers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "CustomerZipNumber",
                table: "Customers",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "CustomerUserName",
                table: "Customers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "CustomerState2",
                table: "Customers",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "CustomerPhoneNumber2",
                table: "Customers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "categoryName",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.AlterColumn<double>(
                name: "VendorPhoneNo",
                table: "Vendors",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 10,
                oldNullable: true);
        }
    }
}
