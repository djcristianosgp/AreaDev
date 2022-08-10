using Dapper.Contrib.Extensions;
using area_api_minimal.Data;
using static area_api_minimal.Data.TarefaContext;

namespace area_api_minimal.Endpoints
{
    public static class TarefasEndpoints
    {
        public static void MapTarefasEndpoints(this WebApplication app)
        {
            app.MapGet("/", () => $"Bem vindo a API Tarefas - {DateTime.Now}");

            app.MapGet("/tarefas", async (GetConnection connectionGetter) =>
            {
                using var con = await connectionGetter();
                var tarefas = con.GetAll<Tarefa>().ToList();
                if (tarefas is null)
                    return Results.NotFound();
                return Results.Ok(tarefas);
            });
        }
    }
}
