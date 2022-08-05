using Microsoft.EntityFrameworkCore;
using area_api.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string postgresqlConection = builder.Configuration.GetConnectionString("postgresql");

builder.Services.AddDbContext<AppDbContext>(opitions =>
        opitions.UseNpgsql(postgresqlConection));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
