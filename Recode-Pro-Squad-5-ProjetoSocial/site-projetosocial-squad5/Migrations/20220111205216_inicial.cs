using Microsoft.EntityFrameworkCore.Migrations;

namespace site_projetosocial_squad5.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Afiliada",
                columns: table => new
                {
                    id_afiliada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_afiliada = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    sobrenome_afiliada = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    email_afiliada = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    senha_afiliada = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    telefone_afiliada = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afiliada", x => x.id_afiliada);
                });

            migrationBuilder.CreateTable(
                name: "Autonoma",
                columns: table => new
                {
                    id_autonoma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_autonoma = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    sobrenome_autonoma = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    email_autonoma = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    senha_autonoma = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    telefone_autonoma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    nomeNegocio_autonoma = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autonoma", x => x.id_autonoma);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoServico",
                columns: table => new
                {
                    id_produtoServico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo_produtoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo_produtoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nome_produtoServico = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    descricao_produtoServico = table.Column<string>(type: "nvarchar(510)", maxLength: 510, nullable: true),
                    preco_produtoServico = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    nomeNegocio_autonoma = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FK_id_autonoma = table.Column<int>(type: "int", nullable: false),
                    id_autonoma1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoServico", x => x.id_produtoServico);
                    table.ForeignKey(
                        name: "FK_ProdutoServico_Autonoma_id_autonoma1",
                        column: x => x.id_autonoma1,
                        principalTable: "Autonoma",
                        principalColumn: "id_autonoma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Afiliacao",
                columns: table => new
                {
                    id_afiliacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo_produtoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FK_id_afiliada = table.Column<int>(type: "int", nullable: false),
                    Afiliadaid_afiliada = table.Column<int>(type: "int", nullable: true),
                    FK_id_produtoServico = table.Column<int>(type: "int", nullable: false),
                    ProdutoServicoid_produtoServico = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afiliacao", x => x.id_afiliacao);
                    table.ForeignKey(
                        name: "FK_Afiliacao_Afiliada_Afiliadaid_afiliada",
                        column: x => x.Afiliadaid_afiliada,
                        principalTable: "Afiliada",
                        principalColumn: "id_afiliada",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Afiliacao_ProdutoServico_ProdutoServicoid_produtoServico",
                        column: x => x.ProdutoServicoid_produtoServico,
                        principalTable: "ProdutoServico",
                        principalColumn: "id_produtoServico",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Afiliacao_Afiliadaid_afiliada",
                table: "Afiliacao",
                column: "Afiliadaid_afiliada");

            migrationBuilder.CreateIndex(
                name: "IX_Afiliacao_ProdutoServicoid_produtoServico",
                table: "Afiliacao",
                column: "ProdutoServicoid_produtoServico");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoServico_id_autonoma1",
                table: "ProdutoServico",
                column: "id_autonoma1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afiliacao");

            migrationBuilder.DropTable(
                name: "Afiliada");

            migrationBuilder.DropTable(
                name: "ProdutoServico");

            migrationBuilder.DropTable(
                name: "Autonoma");
        }
    }
}
