using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace area_27_dashboard.DB
{
    public class DbConnectionProvider
    {
        private readonly IConfiguration _configuration;
        public delegate T Callback<T>(IDbConnection connection);
        public DbConnectionProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<T> ExecutaSQL<T>(string conexao, Callback<Task<T>> callback)
        {
            var conn = this.GetConnection(conexao);
            var retorno = await callback(conn);
            conn.Close();
            NpgsqlConnection.ClearAllPools();
            return retorno;
        }

        public IDbConnection GetConnection(string conexao)
        {
            var connection = new NpgsqlConnection(_configuration[$"{conexao}Connection"]);
            connection.Open();
            return connection;
        }
    }
}
