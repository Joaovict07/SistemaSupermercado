using Microsoft.EntityFrameworkCore;
using SistemaSupermercado.Entity;
using Pomelo.EntityFrameworkCore.MySql;

namespace SistemaSupermercado.Data
{
    internal class BancoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<Produtos_Compras> Produtos_Compras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Verifica se a conexão já não foi configurada antes
            if (!optionsBuilder.IsConfigured)
            {
                string conexao = "Server=localhost;User ID=root;Password=12345;Database=supermercadoDB";

                optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            }
        }
    }
}
