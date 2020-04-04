using Microsoft.EntityFrameworkCore.Migrations;

namespace AppAdmin.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administradoras",
                columns: table => new
                {
                    AdministradoraId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradoras", x => x.AdministradoraId);
                });

            migrationBuilder.CreateTable(
                name: "Assuntos",
                columns: table => new
                {
                    AssuntoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoAssunto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assuntos", x => x.AssuntoId);
                });

            migrationBuilder.CreateTable(
                name: "Condominios",
                columns: table => new
                {
                    CondominioId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    AdministradoraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condominios", x => x.CondominioId);
                    table.ForeignKey(
                        name: "FK_Condominios_Administradoras_AdministradoraId",
                        column: x => x.AdministradoraId,
                        principalTable: "Administradoras",
                        principalColumn: "AdministradoraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    CondominioId = table.Column<int>(nullable: true),
                    TipoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuarios_Condominios_CondominioId",
                        column: x => x.CondominioId,
                        principalTable: "Condominios",
                        principalColumn: "CondominioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Condominios_AdministradoraId",
                table: "Condominios",
                column: "AdministradoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CondominioId",
                table: "Usuarios",
                column: "CondominioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assuntos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Condominios");

            migrationBuilder.DropTable(
                name: "Administradoras");
        }
    }
}
