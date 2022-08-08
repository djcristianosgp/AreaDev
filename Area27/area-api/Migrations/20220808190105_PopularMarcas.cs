using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace area_api.Migrations
{
    public partial class PopularMarcas : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO \"Marca\"(\"Descricao\", \"Datacadastro\", \"Ativo\") VALUES ('PHILCO','" + DateTime.Now.ToString() + "',true);");
            mb.Sql("INSERT INTO \"Marca\"(\"Descricao\", \"Datacadastro\", \"Ativo\") VALUES ('SIMONETTE','" + DateTime.Now.ToString() + "',true);");
            mb.Sql("INSERT INTO \"Marca\"(\"Descricao\", \"Datacadastro\", \"Ativo\") VALUES ('VONDER','" + DateTime.Now.ToString() + "',true);");
        }

        protected override void Down(MigrationBuilder MB)
        {
            MB.Sql("DELETE FROM public.\"Marca\" WHERE \"Descricao\" = 'PHILCO';");
            MB.Sql("DELETE FROM public.\"Marca\" WHERE \"Descricao\" = 'SIMONETTE';");
            MB.Sql("DELETE FROM public.\"Marca\" WHERE \"Descricao\" = 'VONDER';");
        }
    }
}
