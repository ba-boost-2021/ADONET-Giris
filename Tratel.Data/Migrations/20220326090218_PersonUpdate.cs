using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tratel.Data.Migrations
{
    public partial class PersonUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Persons",
                newSchema: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Persons",
                schema: "Customer",
                newName: "Persons");
        }
    }
}
