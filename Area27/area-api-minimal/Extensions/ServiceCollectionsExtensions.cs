﻿using Npgsql;
using System.Data.SqlClient;
using static area_api_minimal.Data.TarefaContext;

namespace area_api_minimal.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("postgresqlCon");

            builder.Services.AddScoped<GetConnection>(sp =>
            async () =>
            {
                var connection = new NpgsqlConnection(connectionString);
                await connection.OpenAsync();
                return connection;
            });
            return builder;
        }
    }
}
