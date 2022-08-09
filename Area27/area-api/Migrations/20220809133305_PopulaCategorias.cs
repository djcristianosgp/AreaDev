using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace area_api.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO public.categoria(descricao, datacadastro, ativo) VALUES ('SALA','" + DateTime.Now.ToString() + "',true);");
            mb.Sql("INSERT INTO public.categoria(descricao, datacadastro, ativo) VALUES ('COZINHA','" + DateTime.Now.ToString() + "',true);");
            mb.Sql("INSERT INTO public.categoria(descricao, datacadastro, ativo) VALUES ('GARAGEM','" + DateTime.Now.ToString() + "',true);");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM public.categoria WHERE descricao='SALA';");
            mb.Sql("DELETE FROM public.categoria WHERE descricao='COZINHA';");
            mb.Sql("DELETE FROM public.categoria WHERE descricao='GARAGEM';");
        }
    }
}
