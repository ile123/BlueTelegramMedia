using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class InitalMigration3_the_return_of_eletric_bogaloo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "Reviewers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "Reviewers");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "Reviewers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "Reviewers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
