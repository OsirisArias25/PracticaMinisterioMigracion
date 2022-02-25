using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practica.Migrations
{
    public partial class correcciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugadores_Equipo_Id_EquipoId",
                table: "Jugadores");

            migrationBuilder.AlterColumn<int>(
                name: "Id_EquipoId",
                table: "Jugadores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadores_Equipo_Id_EquipoId",
                table: "Jugadores",
                column: "Id_EquipoId",
                principalTable: "Equipo",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugadores_Equipo_Id_EquipoId",
                table: "Jugadores");

            migrationBuilder.AlterColumn<int>(
                name: "Id_EquipoId",
                table: "Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadores_Equipo_Id_EquipoId",
                table: "Jugadores",
                column: "Id_EquipoId",
                principalTable: "Equipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
