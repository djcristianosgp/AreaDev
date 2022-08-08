using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace area_api.Migrations
{
    public partial class PopularProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO public.\"Produto\"( \"Descricao\", \"CategoriaId\", \"MarcaId\", \"Datacadastro\", \"Ativo\", \"Preco\") " +
                "VALUES ('SMART TV 32',1,1,'"+DateTime.Now.ToString()+"',true,1325.99);");
            mb.Sql("INSERT INTO public.\"Produto\"( \"Descricao\", \"CategoriaId\", \"MarcaId\", \"Datacadastro\", \"Ativo\", \"Preco\") " +
                "VALUES ('GUARDA ROUPA 4 PORTAS',2,2,'"+DateTime.Now.ToString()+"',true,850.99);");
            mb.Sql("INSERT INTO public.\"Produto\"( \"Descricao\", \"CategoriaId\", \"MarcaId\", \"Datacadastro\", \"Ativo\", \"Preco\") " +
                "VALUES ('LAVADORA DE ALTA PRESSÃO VO 5000',3,3,'"+DateTime.Now.ToString()+"',true,630.99);");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM \"Produto\" WHERE \"Descricao\" = 'SMART TV 32';");
            mb.Sql("DELETE FROM \"Produto\" WHERE \"Descricao\" = 'GUARDA ROUPA 4 PORTAS';");
            mb.Sql("DELETE FROM \"Produto\" WHERE \"Descricao\" = 'LAVADORA DE ALTA PRESSÃO VO 5000';");
        }
    }
}
