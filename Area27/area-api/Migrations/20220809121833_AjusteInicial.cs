using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace area_api.Migrations
{
    public partial class AjusteInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    categoriaid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    datacadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.categoriaid);
                });

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    marcaid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    datacadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marca", x => x.marcaid);
                });

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    produtoid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    preco = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    categoriaid = table.Column<int>(type: "integer", nullable: false),
                    marcaid = table.Column<int>(type: "integer", nullable: false),
                    datacadastro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    codigogtin = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    ativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.produtoid);
                    table.ForeignKey(
                        name: "FK_produto_categoria_categoriaid",
                        column: x => x.categoriaid,
                        principalTable: "categoria",
                        principalColumn: "categoriaid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produto_marca_marcaid",
                        column: x => x.marcaid,
                        principalTable: "marca",
                        principalColumn: "marcaid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_produto_categoriaid",
                table: "produto",
                column: "categoriaid");

            migrationBuilder.CreateIndex(
                name: "IX_produto_marcaid",
                table: "produto",
                column: "marcaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.DropTable(
                name: "categoria");

            migrationBuilder.DropTable(
                name: "marca");
        }
    }
}
