using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class Add_Rel_Media : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Media_MovieId",
                table: "Media");

            migrationBuilder.CreateIndex(
                name: "IX_Media_MovieId",
                table: "Media",
                column: "MovieId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Media_MovieId",
                table: "Media");

            migrationBuilder.CreateIndex(
                name: "IX_Media_MovieId",
                table: "Media",
                column: "MovieId");
        }
    }
}
