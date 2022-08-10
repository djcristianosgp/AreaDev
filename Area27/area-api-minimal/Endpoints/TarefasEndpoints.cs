using area_api_minimal.Data;
using Dapper.Contrib.Extensions;
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
                try
                {
                    using var con = await connectionGetter();
                    var tarefas = con.GetAll<Tarefa>().ToList();
                    if (tarefas is null)
                        return Results.NotFound();
                    return Results.Ok(tarefas);
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            });

            app.MapGet("/tarefas/{id:int}", async (GetConnection connectionGetter,int id) =>
            {
                try
                {
                    using var con = await connectionGetter();
                    var tarefas = con.Get<Tarefa>(id);
                    if (tarefas is null)
                        return Results.NotFound();
                    return Results.Ok(tarefas);
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            });

            app.MapGet("/tarefas/{status}", async (GetConnection connectionGetter, string status) =>
            {
                try
                {
                    using var con = await connectionGetter();
                    var tarefas = con.GetAll<Tarefa>().Where(s => s.status.Contains(status.ToUpper())).ToList();
                    if (tarefas is null)
                        return Results.NotFound();
                    return Results.Ok(tarefas);
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            });
        }
    }
}
