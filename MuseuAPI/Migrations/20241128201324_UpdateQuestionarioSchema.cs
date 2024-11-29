using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuseuAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQuestionarioSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avaliacao",
                table: "Questionarios");

            migrationBuilder.RenameColumn(
                name: "Sugestao",
                table: "Questionarios",
                newName: "Resposta5");

            migrationBuilder.AddColumn<string>(
                name: "Comentarios",
                table: "Questionarios",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Questionarios",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Pergunta1",
                table: "Questionarios",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pergunta2",
                table: "Questionarios",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pergunta3",
                table: "Questionarios",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pergunta4",
                table: "Questionarios",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pergunta5",
                table: "Questionarios",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Resposta1",
                table: "Questionarios",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Resposta2",
                table: "Questionarios",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Resposta3",
                table: "Questionarios",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Resposta4",
                table: "Questionarios",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comentarios",
                table: "Questionarios");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Questionarios");

            migrationBuilder.DropColumn(
                name: "Pergunta1",
                table: "Questionarios");

            migrationBuilder.DropColumn(
                name: "Pergunta2",
                table: "Questionarios");

            migrationBuilder.DropColumn(
                name: "Pergunta3",
                table: "Questionarios");

            migrationBuilder.DropColumn(
                name: "Pergunta4",
                table: "Questionarios");

            migrationBuilder.DropColumn(
                name: "Pergunta5",
                table: "Questionarios");

            migrationBuilder.DropColumn(
                name: "Resposta1",
                table: "Questionarios");

            migrationBuilder.DropColumn(
                name: "Resposta2",
                table: "Questionarios");

            migrationBuilder.DropColumn(
                name: "Resposta3",
                table: "Questionarios");

            migrationBuilder.DropColumn(
                name: "Resposta4",
                table: "Questionarios");

            migrationBuilder.RenameColumn(
                name: "Resposta5",
                table: "Questionarios",
                newName: "Sugestao");

            migrationBuilder.AddColumn<string>(
                name: "Avaliacao",
                table: "Questionarios",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
