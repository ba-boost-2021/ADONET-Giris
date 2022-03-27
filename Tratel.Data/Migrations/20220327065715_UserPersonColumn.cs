using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tratel.Data.Migrations
{
    public partial class UserPersonColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PersonId",
                schema: "Auth",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonId",
                schema: "Auth",
                table: "Users",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Persons_PersonId",
                schema: "Auth",
                table: "Users",
                column: "PersonId",
                principalSchema: "Customer",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Persons_PersonId",
                schema: "Auth",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PersonId",
                schema: "Auth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PersonId",
                schema: "Auth",
                table: "Users");
        }
    }
}
