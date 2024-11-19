using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class Add_Genre_Country : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Movie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenresId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movie_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CountryId",
                table: "Movie",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesId",
                table: "GenreMovie",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Countries_CountryId",
                table: "Movie",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Countries_CountryId",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Movie_CountryId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Movie",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
