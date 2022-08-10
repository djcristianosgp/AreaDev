using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(opt =>
opt.UseInMemoryDatabase("TarefasDB"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Olá Mundo");

app.MapGet("frases", async () =>
        await new HttpClient().GetStringAsync("https://ron-swanson-quotes.herokuapp.com/v2/quotes"));

app.MapGet("/tarefas", async (AppDbContext db) => { return await db.Tarefas.ToListAsync(); });
app.MapPost("/tarefas", async (Tarefa tarefa, AppDbContext db) =>
{
    db.Tarefas.Add(tarefa);
    await db.SaveChangesAsync();
    return Results.Created($"/tarefas/{tarefa.Id}", tarefa);
});

app.MapGet("/tarefas/{id:int}", async (int id, AppDbContext db) =>
    await db.Tarefas.FindAsync(id) is Tarefa tarefa ? Results.Ok(tarefa) : Results.NotFound());

app.MapGet("/tarefas/concluida", async (AppDbContext db) =>
    await db.Tarefas.Where(tar => tar.IsConcluida).ToListAsync());

app.MapPut("/tarefas/{id:int}", async (int id, Tarefa inputtarefa, AppDbContext db) =>
{
    var tarefa = await db.Tarefas.FindAsync(id);
    if (tarefa is null)
        return Results.NotFound("Tarefa não encontrada!!");
    tarefa.Nome = inputtarefa.Nome;
    tarefa.IsConcluida = inputtarefa.IsConcluida;

    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("tarefas/{id:int}", async (int id, AppDbContext db) =>
{
    if(await db.Tarefas.FindAsync(id) is Tarefa tarefa)
    {
        db.Remove(tarefa);
        await db.SaveChangesAsync();
        return Results.Ok(tarefa);
    }
    return Results.NotFound();
});

app.Run();


class Tarefa
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public bool IsConcluida { get; set; }
}

class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Tarefa> Tarefas => Set<Tarefa>();
}

