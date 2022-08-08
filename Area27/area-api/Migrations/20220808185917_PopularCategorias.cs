using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace area_api.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO \"Categoria\"(\"Descricao\", \"Datacadastro\", \"Ativo\")	VALUES ('SALA','"+DateTime.Now.ToString()+"',true);");
            mb.Sql("INSERT INTO \"Categoria\"(\"Descricao\", \"Datacadastro\", \"Ativo\")	VALUES ('QUARTO','" + DateTime.Now.ToString()+"',true);");
            mb.Sql("INSERT INTO \"Categoria\"(\"Descricao\", \"Datacadastro\", \"Ativo\")	VALUES ('GARAGEM','" + DateTime.Now.ToString()+"',true);");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM \"Categoria\" WHERE \"Descricao\" ='SALA';");
            mb.Sql("DELETE FROM \"Categoria\" WHERE \"Descricao\" ='QUARTO';");
            mb.Sql("DELETE FROM \"Categoria\" WHERE \"Descricao\" ='GARAGEM';");
        }
    }
}
