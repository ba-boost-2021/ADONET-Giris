using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tratel.Data.Migrations
{
    public partial class PhoneColumnSwap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                schema: "Auth",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                schema: "Customer",
                table: "Persons",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                schema: "Customer",
                table: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                schema: "Auth",
                table: "Users",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: true);
        }
    }
}
