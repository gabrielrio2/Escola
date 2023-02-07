using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaProjeto.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_alunos",
                table: "alunos");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "turmas");

            migrationBuilder.DropColumn(
                name: "DataDeNascimento",
                table: "turmas");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "turmas");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "alunos");

            migrationBuilder.RenameTable(
                name: "alunos",
                newName: "Alunos");

            migrationBuilder.RenameColumn(
                name: "Matricula",
                table: "turmas",
                newName: "Numero");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeNascimento",
                table: "Alunos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "DataDeNascimento",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Alunos",
                newName: "alunos");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "turmas",
                newName: "Matricula");

            migrationBuilder.AddColumn<int>(
                name: "Cpf",
                table: "turmas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeNascimento",
                table: "turmas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "turmas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_alunos",
                table: "alunos",
                column: "Id");
        }
    }
}
