using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proj_Modulo3.Migrations
{
    public partial class tabela_nova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "promocoes",
                columns: table => new
                {
                    id_promocoes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    local_viagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preco_antigo = table.Column<float>(type: "real", nullable: false),
                    preco_atual = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_promocoes", x => x.id_promocoes);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "promocoes");
        }
    }
}
