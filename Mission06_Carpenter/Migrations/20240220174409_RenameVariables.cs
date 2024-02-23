using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Carpenter.Migrations
{
    /// <inheritdoc />
    public partial class RenameVariables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieName",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "Movies",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "MovieYear",
                table: "Movies",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "MovieRating",
                table: "Movies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "MovieNotes",
                table: "Movies",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "MovieLentTo",
                table: "Movies",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "MovieEdited",
                table: "Movies",
                newName: "Edited");

            migrationBuilder.RenameColumn(
                name: "MovieDirector",
                table: "Movies",
                newName: "LentTo");

            migrationBuilder.RenameColumn(
                name: "MovieCopiedToPlex",
                table: "Movies",
                newName: "CopiedToPlex");

            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "Movies",
                newName: "Director");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Movies",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movies",
                newName: "MovieID");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Movies",
                newName: "MovieYear");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movies",
                newName: "MovieRating");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Movies",
                newName: "MovieNotes");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Movies",
                newName: "MovieLentTo");

            migrationBuilder.RenameColumn(
                name: "LentTo",
                table: "Movies",
                newName: "MovieDirector");

            migrationBuilder.RenameColumn(
                name: "Edited",
                table: "Movies",
                newName: "MovieEdited");

            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Movies",
                newName: "MovieCategory");

            migrationBuilder.RenameColumn(
                name: "CopiedToPlex",
                table: "Movies",
                newName: "MovieCopiedToPlex");

            migrationBuilder.AddColumn<string>(
                name: "MovieName",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
