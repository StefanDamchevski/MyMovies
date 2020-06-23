using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMovies.Data.Migrations
{
    public partial class addDislike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDisliked",
                table: "MovieLikes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDisliked",
                table: "MovieLikes");
        }
    }
}
