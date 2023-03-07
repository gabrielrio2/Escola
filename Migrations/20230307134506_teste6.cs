using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaProjeto.Migrations
{
    public partial class teste6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_escolas_escolaId",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "escolaId",
                table: "Alunos",
                newName: "EscolaId");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_escolaId",
                table: "Alunos",
                newName: "IX_Alunos_EscolaId");

            migrationBuilder.AddColumn<int>(
                name: "EscolaId",
                table: "turmas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TurmaId",
                table: "escolas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EscolaId",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_turmas_EscolaId",
                table: "turmas",
                column: "EscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_escolas_TurmaId",
                table: "escolas",
                column: "TurmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_escolas_EscolaId",
                table: "Alunos",
                column: "EscolaId",
                principalTable: "escolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_escolas_turmas_TurmaId",
                table: "escolas",
                column: "TurmaId",
                principalTable: "turmas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_turmas_escolas_EscolaId",
                table: "turmas",
                column: "EscolaId",
                principalTable: "escolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_escolas_EscolaId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_escolas_turmas_TurmaId",
                table: "escolas");

            migrationBuilder.DropForeignKey(
                name: "FK_turmas_escolas_EscolaId",
                table: "turmas");

            migrationBuilder.DropIndex(
                name: "IX_turmas_EscolaId",
                table: "turmas");

            migrationBuilder.DropIndex(
                name: "IX_escolas_TurmaId",
                table: "escolas");

            migrationBuilder.DropColumn(
                name: "EscolaId",
                table: "turmas");

            migrationBuilder.DropColumn(
                name: "TurmaId",
                table: "escolas");

            migrationBuilder.RenameColumn(
                name: "EscolaId",
                table: "Alunos",
                newName: "escolaId");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_EscolaId",
                table: "Alunos",
                newName: "IX_Alunos_escolaId");

            migrationBuilder.AlterColumn<int>(
                name: "escolaId",
                table: "Alunos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_escolas_escolaId",
                table: "Alunos",
                column: "escolaId",
                principalTable: "escolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
