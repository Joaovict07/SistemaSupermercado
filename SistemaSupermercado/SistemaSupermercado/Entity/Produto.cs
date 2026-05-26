using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaSupermercado.Entity
{
    public class Produto
    {
        [Key]
        public string codigo {  get; set; }
        public string nome { get; set; }
        public string categoria{ get; set; }
        public int quantidade { get; set; }
        public decimal preco { get; set; }
        public DateTime data_cadastro { get; set; }

        // Apenas para a coluna total do carrinho
        public decimal total => quantidade * preco;
    }
}
