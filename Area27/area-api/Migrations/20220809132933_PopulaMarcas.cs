using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace area_api.Migrations
{
    public partial class PopulaMarcas : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO public.marca(descricao, datacadastro, ativo) VALUES ('PHILCO','" + DateTime.Now.ToString() + "',true);");
            mb.Sql("INSERT INTO public.marca(descricao, datacadastro, ativo) VALUES ('BRASTEMP','" + DateTime.Now.ToString() + "',true);");
            mb.Sql("INSERT INTO public.marca(descricao, datacadastro, ativo) VALUES ('VOUNDER','" + DateTime.Now.ToString() + "',true);");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM public.marca WHERE descricao='PHILCO';");
            mb.Sql("DELETE FROM public.marca WHERE descricao='BRASTEMP';");
            mb.Sql("DELETE FROM public.marca WHERE descricao='VOUNDER';");
        }
    }
}
