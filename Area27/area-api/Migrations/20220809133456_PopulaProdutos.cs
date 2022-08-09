using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace area_api.Migrations
{
    public partial class PopulapRODUTOS : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO public.produto(descricao, preco, categoriaid, marcaid, datacadastro, codigogtin, ativo) " +
                "VALUES ('SMART TV PHILCO 32 POLEGADAS', 1325.99, 1, 1, '"+DateTime.Now.ToString()+ "', '1946753211111', true);");
            mb.Sql("INSERT INTO public.produto(descricao, preco, categoriaid, marcaid, datacadastro, codigogtin, ativo) " +
                "VALUES ('GELADEIRA 473L BRASTEMP INVERTER', 4862.99, 2, 2, '"+DateTime.Now.ToString()+ "', '1946753212222', true);");
            mb.Sql("INSERT INTO public.produto(descricao, preco, categoriaid, marcaid, datacadastro, codigogtin, ativo) " +
                "VALUES ('LAVADORA DE ALTA PRESSÃO VO 5000', 685.99, 3, 3, '"+DateTime.Now.ToString()+ "', '1946753213333', true);");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM public.produto WHERE descricao ='SMART TV PHILCO 32 POLEGADAS';");
            mb.Sql("DELETE FROM public.produto WHERE descricao ='GELADEIRA 473L BRASTEMP INVERTER';");
            mb.Sql("DELETE FROM public.produto WHERE descricao ='LAVADORA DE ALTA PRESSÃO VO 5000';");
        }
    }
}
