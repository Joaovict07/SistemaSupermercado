using SistemaSupermercado.Data;
using SistemaSupermercado.Entity;


namespace SistemaSupermercado.Repository
{
    internal class ProdutoComprasRepository : IProdutoComprasRepository
    {
        private readonly BancoContext _bancoDeDados;
        public ProdutoComprasRepository(BancoContext bancoDeDados)
        {
            _bancoDeDados = bancoDeDados;
        }
        public void Salvar(Produtos_Compras produtos_Compras)
        {
            try
            {
                _bancoDeDados.Produtos_Compras.Add(produtos_Compras);
                _bancoDeDados.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar venda: {ex.Message}");
            }
        }
    }
}
