using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaSupermercado.Modelo
{
    internal class Produto
    {
        [Key]
        public string codigo {  get; set; }
        public string nome { get; set; }
        public string categoria{ get; set; }
        public int quantidade { get; set; }
        public decimal preco { get; set; }
        public DateTime data_cadastro { get; set; }
    }
}
