using SistemaSupermercado.Data;
using SistemaSupermercado.Entity;

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
            try
            {
                _bancoDeDados.Produtos.Add(produto);
                _bancoDeDados.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o produto: {ex.Message}");
            }
        }

        public List<Produto> Listar()
        {
            try
            {
                List<Produto> lista = new List<Produto>();
                lista.Clear();
                lista.AddRange(_bancoDeDados.Produtos.ToList());
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar os produtos: {ex.Message}");
                return new List<Produto>();
            }
        }

        public void Editar(Produto produto)
        {
            var produtoExistente = _bancoDeDados.Produtos.FirstOrDefault(p => p.codigo == produto.codigo);
            if (produtoExistente != null)
            {
                produtoExistente.codigo = produto.codigo;
                produtoExistente.nome = produto.nome;
                produtoExistente.categoria = produto.categoria;
                produtoExistente.quantidade = produto.quantidade;
                produtoExistente.preco = produto.preco;
                _bancoDeDados.SaveChanges();
                MessageBox.Show("Produto editado com sucesso!");
            }
            else
            {
                MessageBox.Show("Produto não encontrado!");
            }
        }

        public void Excluir(string codigo)
        {
            var produtoExistente = _bancoDeDados.Produtos.FirstOrDefault(p => p.codigo == codigo);
            if (produtoExistente != null)
            {
                _bancoDeDados.Produtos.Remove(produtoExistente);
                _bancoDeDados.SaveChanges();
                MessageBox.Show("Produto excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Produto não encontrado para exclusão!");
            }
        }

    }
}
