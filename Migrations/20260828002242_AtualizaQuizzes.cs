using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacQuizApp.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaQuizzes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempoDeQuiz",
                table: "QuizzesRush");

            migrationBuilder.RenameColumn(
                name: "QuantidadeAcertos",
                table: "QuizzesRush",
                newName: "Streak");

            migrationBuilder.RenameColumn(
                name: "FoiConcluido",
                table: "QuizzesDiarios",
                newName: "Concluido");

            migrationBuilder.RenameColumn(
                name: "DataInicio",
                table: "QuizzesDiarios",
                newName: "DataIniciado");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DataFinalizado",
                table: "QuizzesRush",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Tempo",
                table: "QuizzesRush",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tempo",
                table: "QuizzesRush");

            migrationBuilder.RenameColumn(
                name: "Streak",
                table: "QuizzesRush",
                newName: "QuantidadeAcertos");

            migrationBuilder.RenameColumn(
                name: "DataIniciado",
                table: "QuizzesDiarios",
                newName: "DataInicio");

            migrationBuilder.RenameColumn(
                name: "Concluido",
                table: "QuizzesDiarios",
                newName: "FoiConcluido");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFinalizado",
                table: "QuizzesRush",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TempoDeQuiz",
                table: "QuizzesRush",
                type: "interval",
                nullable: true);
        }
    }
}
