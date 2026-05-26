using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaSupermercado.Entity
{
    internal class Produtos_Compras
    {
        [Key]
        public int Id { get; set; }
        public string codigo_compra { get; set; }
        public string codigo_produto { get; set; }
        public int quantidade { get; set; }
        public decimal preco { get; set; }  
    }
}
