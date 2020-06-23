using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMovies.Data.Migrations
{
    public partial class propertyFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsLike",
                table: "MovieLikes",
                newName: "IsLiked");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsLiked",
                table: "MovieLikes",
                newName: "IsLike");
        }
    }
}
