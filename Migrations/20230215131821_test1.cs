using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaProjeto.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "escolas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EscolaId",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_escolas_AlunoId",
                table: "escolas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_EscolaId",
                table: "Alunos",
                column: "EscolaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_escolas_EscolaId",
                table: "Alunos",
                column: "EscolaId",
                principalTable: "escolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_escolas_Alunos_AlunoId",
                table: "escolas",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_escolas_EscolaId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_escolas_Alunos_AlunoId",
                table: "escolas");

            migrationBuilder.DropIndex(
                name: "IX_escolas_AlunoId",
                table: "escolas");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_EscolaId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "escolas");

            migrationBuilder.DropColumn(
                name: "EscolaId",
                table: "Alunos");
        }
    }
}
