using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaProjeto.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "escolas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "escolaId",
                table: "Alunos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_escolas_AlunoId",
                table: "escolas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_escolaId",
                table: "Alunos",
                column: "escolaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_escolas_escolaId",
                table: "Alunos",
                column: "escolaId",
                principalTable: "escolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Alunos_escolas_escolaId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_escolas_Alunos_AlunoId",
                table: "escolas");

            migrationBuilder.DropIndex(
                name: "IX_escolas_AlunoId",
                table: "escolas");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_escolaId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "escolas");

            migrationBuilder.DropColumn(
                name: "escolaId",
                table: "Alunos");
        }
    }
}
