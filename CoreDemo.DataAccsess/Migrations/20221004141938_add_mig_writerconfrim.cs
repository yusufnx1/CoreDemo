using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDemo.DataAccsess.Migrations
{
    public partial class add_mig_writerconfrim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Writers");
        }
    }
}
