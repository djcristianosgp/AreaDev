using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace area_api.Migrations
{
    public partial class pedidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    id_pedidos = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data_pedidos = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dth_exporta = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    colaborador = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    estacao = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    pao = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.id_pedidos);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pedidos");
        }
    }
}
