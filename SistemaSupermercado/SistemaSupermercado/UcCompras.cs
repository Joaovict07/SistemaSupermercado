using SistemaSupermercado.Data;
using SistemaSupermercado.Entity;
using SistemaSupermercado.Repository;
using System.Data;

namespace SistemaSupermercado
{
    public partial class UcCompras : UserControl
    {
        public UcCompras()
        {
            InitializeComponent();
            _repositorio = new ProdutoRepository(new BancoContext());
            _repositorioCompra = new CompraRepository(new BancoContext());
            _repositorioProdutoCompra = new ProdutoComprasRepository(new BancoContext());
            CarregarDadosNoGrid();
        }
        private int quantidadeProduto;
        private decimal precoProduto;
        private string codigoProduto;
        private readonly ProdutoRepository _repositorio;
        private readonly CompraRepository _repositorioCompra;
        private readonly ProdutoComprasRepository _repositorioProdutoCompra;
        private List<Produto> _listaProdutos = new List<Produto>();
        private List<Produto> _listaProdutosComprados = new List<Produto>();

        private void CarregarDadosNoGrid()
        {
            dataGridView2.AutoGenerateColumns = false;
            Codigo.DataPropertyName = "codigo";
            Produto.DataPropertyName = "nome";
            EstoqueCompras.DataPropertyName = "quantidade";
            Preco.DataPropertyName = "preco";

            _listaProdutos = _repositorio.Listar();
            _listaProdutos = _listaProdutos.Where(p => p.quantidade > 0).ToList();
            dataGridView2.DataSource = _listaProdutos;

        }

        private void txtBuscaProdutosCompras_TextChanged(object sender, EventArgs e)
        {
            var procurado = txtBuscaProdutosCompras.Text.Trim();

            if (string.IsNullOrEmpty(procurado))
            {
                dataGridView2.DataSource = _listaProdutos;
                return;
            }

            var listaFiltrada = new List<Produto>();
            if (cboCategoriaCompras.Text != "Todas Categorias")
            {
                listaFiltrada = _listaProdutos
                    .Where(p => p.categoria.Contains(cboCategoriaCompras.Text) &&
                                p.nome.Contains(procurado, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            else
            {
                listaFiltrada = _listaProdutos
                    .Where(p => p.nome.Contains(procurado, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            dataGridView2.DataSource = listaFiltrada;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                txtCarrinho.Text = row.Cells["Produto"].Value.ToString();
                quantidadeProduto = Convert.ToInt32(row.Cells["EstoqueCompras"].Value);
                precoProduto = Convert.ToDecimal(row.Cells["Preco"].Value);
                codigoProduto = row.Cells["Codigo"].Value.ToString();
            }
            numericUpDown1.Value = 0;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > quantidadeProduto)
            {
                MessageBox.Show("Quantidade solicitada excede o estoque disponível.");
                numericUpDown1.Value = quantidadeProduto;
                return;
            }
        }

        private void cboCategoriaCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            var procurado = txtBuscaProdutosCompras.Text.Trim();
            List<Produto> listaFiltrada;

            if (cboCategoriaCompras.Text == "Todas Categorias")
            {
                if (string.IsNullOrEmpty(procurado))
                {
                    listaFiltrada = _listaProdutos.ToList();
                }
                else
                {
                    listaFiltrada = _listaProdutos
                        .Where(p => p.nome.Contains(procurado, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(procurado))
                {
                    listaFiltrada = _listaProdutos
                        .Where(p => p.categoria.Contains(cboCategoriaCompras.Text, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }
                else
                {
                    listaFiltrada = _listaProdutos
                        .Where(p => p.categoria.Contains(cboCategoriaCompras.Text, StringComparison.OrdinalIgnoreCase) &&
                                    p.nome.Contains(procurado, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }
            }

            dataGridView2.DataSource = listaFiltrada;
        }

        private void txtBuscaProdutosCompras_Click(object sender, EventArgs e)
        {
            txtBuscaProdutosCompras.Clear();
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {   
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }
            _listaProdutosComprados.Add(new Produto
            {
                codigo = codigoProduto,
                nome = txtCarrinho.Text,
                quantidade = (int)numericUpDown1.Value,
                preco = precoProduto
            });
            dataGridView3.AutoGenerateColumns = false;
            CarrinhoProduto.DataPropertyName = "nome";
            CarrinhoQuantidade.DataPropertyName = "quantidade";
            CarrinhoValor.DataPropertyName = "preco";
            CarrinhoTotal.DataPropertyName = "total";

            dataGridView3.DataSource = _listaProdutosComprados.ToList();

            txtSubTotal.Text = _listaProdutosComprados.Sum(p => p.total).ToString("C");
            txtTotal.Text = (_listaProdutosComprados.Sum(p => p.total) - Convert.ToDecimal(txtDesconto.Text)).ToString("C");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            _listaProdutosComprados.Clear();
            dataGridView3.DataSource = null;
            txtSubTotal.Text = "0,00";
            txtDesconto.Text = "0,00";
            txtTotal.Text = "0,00";
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (_listaProdutosComprados.Sum(p => p.total) - Convert.ToDecimal(txtDesconto.Text)).ToString("C");
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            string codigoCompra = DateTime.Now.ToString("YY") + new Random().Next(1000, 9999).ToString();
            var compra = new Compras
            {
                codigo_compra = codigoCompra,
                subtotal = _listaProdutosComprados.Sum(p => p.total),
                desconto = Convert.ToDecimal(txtDesconto.Text),
                total = (_listaProdutosComprados.Sum(p => p.total) - Convert.ToDecimal(txtDesconto.Text)),
                data_compra = DateTime.Now
            };

            foreach (var produto in _listaProdutosComprados)
            {
                var compraProduto = new Produtos_Compras
                {
                    codigo_compra = codigoCompra,
                    codigo_produto = produto.codigo,
                    quantidade = produto.quantidade,
                    preco = produto.preco
                };
                _repositorioProdutoCompra.Salvar(compraProduto);
                _repositorio.AtualizarEstoque(produto.codigo, produto.quantidade);
                CarregarDadosNoGrid();
            }

            _repositorioCompra.Salvar(compra);
            _listaProdutosComprados.Clear();
            dataGridView3.DataSource = null;
            txtSubTotal.Text = "0,00";
            txtDesconto.Text = "0,00";
            txtTotal.Text = "0,00";
            txtCarrinho.Text = "";
            numericUpDown1.Value = 0;
            MessageBox.Show("Compra cadastrada com sucesso!");
        }
    }
}
