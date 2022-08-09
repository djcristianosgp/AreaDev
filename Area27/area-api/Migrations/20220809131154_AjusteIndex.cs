using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace area_api.Migrations
{
    public partial class AjusteIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "marca_index01",
                table: "marca",
                column: "descricao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "categoria_index01",
                table: "categoria",
                column: "descricao",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "marca_index01",
                table: "marca");

            migrationBuilder.DropIndex(
                name: "categoria_index01",
                table: "categoria");
        }
    }
}
