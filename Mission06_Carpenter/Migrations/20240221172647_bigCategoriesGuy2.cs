using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Carpenter.Migrations
{
    /// <inheritdoc />
    public partial class bigCategoriesGuy2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "Category",
                newName: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Category",
                newName: "categoryId");
        }
    }
}
