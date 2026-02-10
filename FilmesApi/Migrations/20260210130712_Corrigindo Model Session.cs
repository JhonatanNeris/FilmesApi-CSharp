using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmesApi.Migrations
{
    /// <inheritdoc />
    public partial class CorrigindoModelSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Movies_FilmeId",
                table: "Sessions");

            migrationBuilder.RenameColumn(
                name: "FilmeId",
                table: "Sessions",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_FilmeId",
                table: "Sessions",
                newName: "IX_Sessions_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Movies_MovieId",
                table: "Sessions",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Movies_MovieId",
                table: "Sessions");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Sessions",
                newName: "FilmeId");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_MovieId",
                table: "Sessions",
                newName: "IX_Sessions_FilmeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Movies_FilmeId",
                table: "Sessions",
                column: "FilmeId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
