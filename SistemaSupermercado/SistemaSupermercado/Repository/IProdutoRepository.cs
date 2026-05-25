using SistemaSupermercado.Data;
using SistemaSupermercado.Entity;
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
