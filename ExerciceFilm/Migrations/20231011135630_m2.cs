using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExerciceFilm.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RealisatorId",
                table: "Personne");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RealisatorId",
                table: "Personne",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 1,
                column: "RealisatorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 2,
                column: "RealisatorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 3,
                column: "RealisatorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 4,
                column: "RealisatorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 5,
                column: "RealisatorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 6,
                column: "RealisatorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 7,
                column: "RealisatorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 8,
                column: "RealisatorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 9,
                column: "RealisatorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 10,
                column: "RealisatorId",
                value: 0);
        }
    }
}
