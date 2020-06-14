using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMovies.Data.Migrations
{
    public partial class addIsCommentApproved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAproved",
                table: "MovieComments",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAproved",
                table: "MovieComments");
        }
    }
}
