using SistemaSupermercado.Data;
using SistemaSupermercado.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaSupermercado.Repository
{
    internal interface IProdutoRepository
    {
        void Salvar(Produto produto);
    }
}
