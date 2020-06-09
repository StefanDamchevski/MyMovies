using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMovies.Data.Migrations
{
    public partial class DbSetForgotten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieComment_Movies_MovieId",
                table: "MovieComment");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieComment_Users_UserId",
                table: "MovieComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieComment",
                table: "MovieComment");

            migrationBuilder.RenameTable(
                name: "MovieComment",
                newName: "MovieComments");

            migrationBuilder.RenameIndex(
                name: "IX_MovieComment_UserId",
                table: "MovieComments",
                newName: "IX_MovieComments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieComment_MovieId",
                table: "MovieComments",
                newName: "IX_MovieComments_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieComments",
                table: "MovieComments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieComments_Movies_MovieId",
                table: "MovieComments",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieComments_Users_UserId",
                table: "MovieComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieComments_Movies_MovieId",
                table: "MovieComments");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieComments_Users_UserId",
                table: "MovieComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieComments",
                table: "MovieComments");

            migrationBuilder.RenameTable(
                name: "MovieComments",
                newName: "MovieComment");

            migrationBuilder.RenameIndex(
                name: "IX_MovieComments_UserId",
                table: "MovieComment",
                newName: "IX_MovieComment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieComments_MovieId",
                table: "MovieComment",
                newName: "IX_MovieComment_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieComment",
                table: "MovieComment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieComment_Movies_MovieId",
                table: "MovieComment",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieComment_Users_UserId",
                table: "MovieComment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
