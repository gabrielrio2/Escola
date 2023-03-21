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

            migrationBuilder.DropForeignKey(
                name: "FK_escolas_Alunos_AlunoId",
                table: "escolas");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_escolaId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "escolaId",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "AlunoId",
                table: "escolas",
                newName: "TurmaId");

            migrationBuilder.RenameIndex(
                name: "IX_escolas_AlunoId",
                table: "escolas",
                newName: "IX_escolas_TurmaId");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "turmas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "turmas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EscolaId",
                table: "turmas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MateriaId",
                table: "turmas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Professor",
                table: "materias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "materias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurmaId",
                table: "materias",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "escolas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Endereço",
                table: "escolas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "escolas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Matricula",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurmaId",
                table: "Alunos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_turmas_AlunoId",
                table: "turmas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_turmas_EscolaId",
                table: "turmas",
                column: "EscolaId");

            migrationBuilder.CreateIndex(
                name: "IX_turmas_MateriaId",
                table: "turmas",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_materias_TurmaId",
                table: "materias",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TurmaId",
                table: "Alunos",
                column: "TurmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_turmas_TurmaId",
                table: "Alunos",
                column: "TurmaId",
                principalTable: "turmas",
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
                name: "FK_materias_turmas_TurmaId",
                table: "materias",
                column: "TurmaId",
                principalTable: "turmas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_turmas_Alunos_AlunoId",
                table: "turmas",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_turmas_escolas_EscolaId",
                table: "turmas",
                column: "EscolaId",
                principalTable: "escolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_turmas_materias_MateriaId",
                table: "turmas",
                column: "MateriaId",
                principalTable: "materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_turmas_TurmaId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_escolas_turmas_TurmaId",
                table: "escolas");

            migrationBuilder.DropForeignKey(
                name: "FK_materias_turmas_TurmaId",
                table: "materias");

            migrationBuilder.DropForeignKey(
                name: "FK_turmas_Alunos_AlunoId",
                table: "turmas");

            migrationBuilder.DropForeignKey(
                name: "FK_turmas_escolas_EscolaId",
                table: "turmas");

            migrationBuilder.DropForeignKey(
                name: "FK_turmas_materias_MateriaId",
                table: "turmas");

            migrationBuilder.DropIndex(
                name: "IX_turmas_AlunoId",
                table: "turmas");

            migrationBuilder.DropIndex(
                name: "IX_turmas_EscolaId",
                table: "turmas");

            migrationBuilder.DropIndex(
                name: "IX_turmas_MateriaId",
                table: "turmas");

            migrationBuilder.DropIndex(
                name: "IX_materias_TurmaId",
                table: "materias");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_TurmaId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "turmas");

            migrationBuilder.DropColumn(
                name: "EscolaId",
                table: "turmas");

            migrationBuilder.DropColumn(
                name: "MateriaId",
                table: "turmas");

            migrationBuilder.DropColumn(
                name: "TurmaId",
                table: "materias");

            migrationBuilder.DropColumn(
                name: "TurmaId",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "TurmaId",
                table: "escolas",
                newName: "AlunoId");

            migrationBuilder.RenameIndex(
                name: "IX_escolas_TurmaId",
                table: "escolas",
                newName: "IX_escolas_AlunoId");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "turmas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Professor",
                table: "materias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "materias",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "escolas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Endereço",
                table: "escolas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "escolas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Matricula",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "escolaId",
                table: "Alunos",
                type: "int",
                nullable: true);

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
    }
}
