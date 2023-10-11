using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExerciceFilm.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    PersonneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Prenom = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    RealisatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personne", x => x.PersonneId);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    RealisatorId = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.Id);
                    table.CheckConstraint("CK_MinYear", "ReleaseYear >= 1975");
                    table.ForeignKey(
                        name: "FK_Film_Personne_RealisatorId",
                        column: x => x.RealisatorId,
                        principalTable: "Personne",
                        principalColumn: "PersonneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmPersonneJoin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PersonneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmPersonneJoin", x => new { x.Id, x.PersonneId });
                    table.ForeignKey(
                        name: "FK_FilmPersonneJoin_Film_Id",
                        column: x => x.Id,
                        principalTable: "Film",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmPersonneJoin_Personne_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personne",
                        principalColumn: "PersonneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Personne",
                columns: new[] { "PersonneId", "Nom", "Prenom", "RealisatorId" },
                values: new object[,]
                {
                    { 1, "Wood", "Elijah", 0 },
                    { 2, "Hunnam", "Charlie", 0 },
                    { 3, "Ford", "Harisson", 0 },
                    { 4, "Hammil", "Mark", 0 },
                    { 5, "Fisher", "Carrie", 0 },
                    { 6, "Mortensen", "Vigo", 0 },
                    { 7, "Bloom", "Orlando", 0 },
                    { 8, "Alexander", "Lexi", 0 },
                    { 9, "Jackson", "Peter", 0 },
                    { 10, "Lucas", "Georges", 0 }
                });

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "Id", "Genre", "RealisatorId", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "Science-Fiction", 10, 1977, "Star Wars : Un nouvel espoir" },
                    { 2, "Science-Fiction", 10, 1980, "Star Wars : L'empire contre-attaque" },
                    { 3, "Science-Fiction", 10, 1983, "Star Wars : Le retour du Jedi" },
                    { 4, "Société", 8, 2005, "Hooligans" },
                    { 5, "Heroic-Fantasy", 9, 2001, "LOTR - La communauté de l'anneau" },
                    { 6, "Heroic-Fantasy", 9, 2002, "LOTR - Les deux tours" },
                    { 7, "Heroic-Fantasy", 9, 2003, "LOTR - Le retour du roi" }
                });

            migrationBuilder.InsertData(
                table: "FilmPersonneJoin",
                columns: new[] { "Id", "PersonneId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 1 },
                    { 4, 2 },
                    { 5, 1 },
                    { 5, 6 },
                    { 5, 7 },
                    { 6, 1 },
                    { 6, 6 },
                    { 6, 7 },
                    { 7, 1 },
                    { 7, 6 },
                    { 7, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Film_RealisatorId",
                table: "Film",
                column: "RealisatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Film_Title",
                table: "Film",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FilmPersonneJoin_PersonneId",
                table: "FilmPersonneJoin",
                column: "PersonneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmPersonneJoin");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Personne");
        }
    }
}
