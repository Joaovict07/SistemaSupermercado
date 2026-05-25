using SistemaSupermercado.Entity;

namespace SistemaSupermercado.Repository
{
    internal interface IProdutoRepository
    {
        void Salvar(Produto produto);
        List<Produto> Listar();
        void Editar(Produto produto);
        void Excluir(string Codigo);
    }
}
