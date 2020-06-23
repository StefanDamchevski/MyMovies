using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMovies.Data.Migrations
{
    public partial class updateLikeLogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDisliked",
                table: "MovieLikes");

            migrationBuilder.RenameColumn(
                name: "IsLiked",
                table: "MovieLikes",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "MovieLikes",
                newName: "IsLiked");

            migrationBuilder.AddColumn<bool>(
                name: "IsDisliked",
                table: "MovieLikes",
                nullable: false,
                defaultValue: false);
        }
    }
}
