using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaQuizRush : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_QuizzesRush_UsuarioId",
                table: "QuizzesRush");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DataIniciado",
                table: "QuizzesRush",
                type: "timestamptz",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DataConcluido",
                table: "QuizzesRush",
                type: "timestamptz",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzesRush_UsuarioId_DataIniciado",
                table: "QuizzesRush",
                columns: new[] { "UsuarioId", "DataIniciado" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_QuizzesRush_UsuarioId_DataIniciado",
                table: "QuizzesRush");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DataIniciado",
                table: "QuizzesRush",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamptz",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DataConcluido",
                table: "QuizzesRush",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamptz");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzesRush_UsuarioId",
                table: "QuizzesRush",
                column: "UsuarioId");
        }
    }
}
