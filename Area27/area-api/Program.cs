using area_api.Context;
using area_api.Models.Execucoes;
using area_api.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
        options.JsonSerializerOptions.
            ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiArea27", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme ="Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description =@"JWT Authorization header usin the Bearer scheme,
Enter 'Bearer' [space]. Exemple: \'Bearer 123456abcdef\'",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id= "Bearer"
                }
            },
            new string[] { }
        }
    });
});

string postgresqlConection = builder.Configuration.GetConnectionString("postgresql");

builder.Services.AddDbContext<AppDbContext>(opitions =>
        opitions.UseNpgsql(postgresqlConection));

builder.Services.AddSingleton<ITokenService>(new TokenService());

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
{
    option.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

var app = builder.Build();
app.MapPost("/login", [AllowAnonymous] (UserModel usermodel, ITokenService tokenService) =>
{
    if (usermodel == null)
        return Results.BadRequest("Login Inválido");
    if (usermodel.Username == "Cristiano" && usermodel.Password == "numsey#123")
    {
        var tokenString = tokenService.GerarToken(
            app.Configuration["Jwt:key"],
            app.Configuration["Jwt:Issuer"],
            app.Configuration["Jwt:Audience"],
            usermodel);
        return Results.Ok(new { token = tokenString });
    }
    else
        return Results.BadRequest("Login inválido");
}).Produces(StatusCodes.Status400BadRequest).
Produces(StatusCodes.Status200OK)
.WithTags("Login")
.WithTags("Autenticacao");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseHttpsRedirection();

app.MapControllers();

app.UseAuthentication();

app.UseAuthorization();

app.Run();
