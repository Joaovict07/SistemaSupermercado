using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaSupermercado.Modelo
{
    internal class Produto
    {
        public string Codigo {  get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public double PrecoProduto { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
