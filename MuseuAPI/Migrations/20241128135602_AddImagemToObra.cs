using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuseuAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddImagemToObra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemUrl",
                table: "Obras");

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagem",
                table: "Obras",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Obras");

            migrationBuilder.AddColumn<string>(
                name: "ImagemUrl",
                table: "Obras",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
