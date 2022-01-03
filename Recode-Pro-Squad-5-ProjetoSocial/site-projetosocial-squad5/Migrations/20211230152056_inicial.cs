using Microsoft.EntityFrameworkCore.Migrations;

namespace site_projetosocial_squad5.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    id_cadastro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_cadatro = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    idade_cadastro = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    email_cadastro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    endereco_cadastro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    cep_cadastro = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    bairro_cadastro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cidade_cadastro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    telefone_cadastro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    nomeNegocio_cadastro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    telefoneNegocio_cadastro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    categoriaNegocio_cadastro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.id_cadastro);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    id_produto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_produto = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    descricao_produto = table.Column<string>(type: "nvarchar(510)", maxLength: 510, nullable: true),
                    preco_produto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FK_id_cadastro = table.Column<int>(type: "int", nullable: false),
                    id_cadastro1 = table.Column<int>(type: "int", nullable: true),
                    FK_nome_negocio = table.Column<int>(type: "int", nullable: false),
                    nomeNegocio_cadastroid_cadastro = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.id_produto);
                    table.ForeignKey(
                        name: "FK_Produtos_Cadastro_id_cadastro1",
                        column: x => x.id_cadastro1,
                        principalTable: "Cadastro",
                        principalColumn: "id_cadastro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produtos_Cadastro_nomeNegocio_cadastroid_cadastro",
                        column: x => x.nomeNegocio_cadastroid_cadastro,
                        principalTable: "Cadastro",
                        principalColumn: "id_cadastro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    id_servico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_servico = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    descricao_servico = table.Column<string>(type: "nvarchar(510)", maxLength: 510, nullable: true),
                    preco_produto = table.Column<float>(type: "real", nullable: false),
                    FK_id_cadastro = table.Column<int>(type: "int", nullable: false),
                    id_cadastro1 = table.Column<int>(type: "int", nullable: true),
                    FK_nome_negocio = table.Column<int>(type: "int", nullable: false),
                    nomeNegocio_cadastroid_cadastro = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.id_servico);
                    table.ForeignKey(
                        name: "FK_Servicos_Cadastro_id_cadastro1",
                        column: x => x.id_cadastro1,
                        principalTable: "Cadastro",
                        principalColumn: "id_cadastro",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servicos_Cadastro_nomeNegocio_cadastroid_cadastro",
                        column: x => x.nomeNegocio_cadastroid_cadastro,
                        principalTable: "Cadastro",
                        principalColumn: "id_cadastro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_id_cadastro1",
                table: "Produtos",
                column: "id_cadastro1");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_nomeNegocio_cadastroid_cadastro",
                table: "Produtos",
                column: "nomeNegocio_cadastroid_cadastro");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_id_cadastro1",
                table: "Servicos",
                column: "id_cadastro1");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_nomeNegocio_cadastroid_cadastro",
                table: "Servicos",
                column: "nomeNegocio_cadastroid_cadastro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Cadastro");
        }
    }
}
