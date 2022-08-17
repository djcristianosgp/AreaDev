using area_api.Models.Cadastros;
using Microsoft.EntityFrameworkCore;

namespace area_api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<Marca>? Marcas { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<Pedidos>? Pedidos { get; set; }

    }
}
