using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuseuAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddImagemUrlToObra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagemUrl",
                table: "Obras",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemUrl",
                table: "Obras");
        }
    }
}
