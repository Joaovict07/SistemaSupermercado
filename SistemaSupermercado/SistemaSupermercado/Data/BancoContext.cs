using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SistemaSupermercado.Modelo;

namespace SistemaSupermercado.Data
{
    internal class BancoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 
        }
    }
}
