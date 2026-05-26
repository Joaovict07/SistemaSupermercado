using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaSupermercado.Entity
{
    public class Compras
    {
        [Key]
        public string codigo_compra { get; set; }
        public decimal subtotal { get; set; }
        public decimal desconto { get; set; }
        public decimal total { get; set; }
        public DateTime data_compra { get; set; }
    }
}
