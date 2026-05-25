using SistemaSupermercado.Data;
using SistemaSupermercado.Entity;


namespace SistemaSupermercado.Repository
{
    internal class CompraRepository
    {
        private readonly BancoContext _bancoDeDados;
        public CompraRepository(BancoContext bancoDeDados)
        {
            _bancoDeDados = bancoDeDados;
        }
        public void Salvar(Compras compras)
        {
            try
            {
                _bancoDeDados.Compras.Add(compras);
                _bancoDeDados.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o produto: {ex.Message}");
            }
        }
    }
}
