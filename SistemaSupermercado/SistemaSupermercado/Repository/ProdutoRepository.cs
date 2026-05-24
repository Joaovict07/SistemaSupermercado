using SistemaSupermercado.Data;
using SistemaSupermercado.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaSupermercado.Repository
{
    internal class ProdutoRepository : IProdutoRepository
    {
        private readonly BancoContext _bancoDeDados;

        public ProdutoRepository(BancoContext bancoDeDados)
        {
            _bancoDeDados = bancoDeDados;
        }

        public void Salvar(Produto produto)
        {
            _bancoDeDados.Produtos.Add(produto);

            _bancoDeDados.SaveChanges();
        }
    }
}
