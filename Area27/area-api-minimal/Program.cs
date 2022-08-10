using area_api_minimal.Endpoints;
using area_api_minimal.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddPersistence();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapTarefasEndpoints();

app.Run();


