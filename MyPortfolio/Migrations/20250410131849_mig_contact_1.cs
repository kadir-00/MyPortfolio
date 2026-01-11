using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolio.Migrations
{
    public partial class mig_contact_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email2",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Phone2",
                table: "Contacts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email2",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone2",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
