using Microsoft.EntityFrameworkCore.Migrations;

namespace SQ009Portfolio.Data.Migrations
{
    public partial class addProjectUrlToProjectTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectUrl",
                table: "Projects",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectUrl",
                table: "Projects");
        }
    }
}
