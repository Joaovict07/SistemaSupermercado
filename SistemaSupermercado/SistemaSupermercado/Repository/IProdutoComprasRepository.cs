using SistemaSupermercado.Entity;

namespace SistemaSupermercado.Repository
{
    internal interface IProdutoComprasRepository
    {
        void Salvar(Produtos_Compras produtos_Compras);
    }
}
