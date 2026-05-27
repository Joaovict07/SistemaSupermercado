using SistemaSupermercado.Data;
using SistemaSupermercado.Entity;
using SistemaSupermercado.Repository;
using System.Data;

namespace SistemaSupermercado
{
    public partial class UcProdutos : UserControl
    {
        private readonly ProdutoRepository _repositorio;
        private List<Produto> _listaProdutos = new List<Produto>();
        public UcProdutos()
        {
            InitializeComponent();
            _repositorio = new ProdutoRepository(new BancoContext());
            CarregarDadosNoGrid();
        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNomeProd.Clear();
            cboCategoria.SelectedIndex = -1;
            txtQtd.Clear();
            txtPreço.Clear();
        }

        public void CarregarDadosNoGrid()
        {
            dataGridView1.AutoGenerateColumns = false;

            CódigoProduto.DataPropertyName = "codigo";
            NomeProduto.DataPropertyName = "nome";
            Categoria.DataPropertyName = "categoria";
            Estoque.DataPropertyName = "quantidade";
            Preço.DataPropertyName = "preco";
            Data.DataPropertyName = "data_cadastro";
            
            _listaProdutos = _repositorio.Listar();
            dataGridView1.DataSource = _listaProdutos;
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string codigoProduto = txtCodigo.Text.Trim();
            string nomeProduto = txtNomeProd.Text.Trim();
            string categoria = cboCategoria.Text.Trim();
            int quatidade = int.TryParse(txtQtd.Text.Trim(), out int qtd) ? qtd : 0;
            decimal preco = decimal.TryParse(txtPreço.Text.Trim(), out decimal p) ? p : 0;
            string dataCadastro = DateTime.Now.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(codigoProduto) || string.IsNullOrEmpty(nomeProduto) || string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(txtQtd.Text.Trim()) || string.IsNullOrEmpty(txtPreço.Text.Trim()))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

           
            var produto = new Produto
            {
                codigo = codigoProduto,
                nome = nomeProduto,
                categoria = categoria,
                quantidade = quatidade,
                preco = preco,
                data_cadastro = DateTime.Parse(dataCadastro)
            };

            try
            { 
                _repositorio.Salvar(produto);
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o produto: {ex.Message}");
            }

      

            LimparCampos();
            CarregarDadosNoGrid();
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["CódigoProduto"].Value.ToString();
                txtNomeProd.Text = row.Cells["NomeProduto"].Value.ToString();
                cboCategoria.Text = row.Cells["Categoria"].Value.ToString();
                txtQtd.Text = row.Cells["Estoque"].Value.ToString();
                txtPreço.Text = row.Cells["Preço"].Value.ToString();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string codigoProduto = txtCodigo.Text.Trim();
            string nomeProduto = txtNomeProd.Text.Trim();
            string categoria = cboCategoria.Text.Trim();
            int quatidade = int.Parse(txtQtd.Text.Trim());
            decimal preco = decimal.Parse(txtPreço.Text.Trim());
            string dataCadastro = DateTime.Now.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(codigoProduto) || string.IsNullOrEmpty(nomeProduto) || string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(txtQtd.Text.Trim()) || string.IsNullOrEmpty(txtPreço.Text.Trim()))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            var produto = new Produto
            {
                codigo = codigoProduto,
                nome = nomeProduto,
                categoria = categoria,
                quantidade = quatidade,
                preco = preco,
                data_cadastro = DateTime.Parse(dataCadastro)
            };

            try
            {
                _repositorio.Editar(produto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar o produto: " + ex.Message);
                return;
            }
            
     
            LimparCampos();
            CarregarDadosNoGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()))
            {
                MessageBox.Show("Por favor, selecione um produto para excluir.");
                return;
            }

            string codigo = txtCodigo.Text.Trim();

            if(codigo.Length != 0)
            {
                try
                {
                    var confirmResult = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        _repositorio.Excluir(codigo);
                        LimparCampos();
                        CarregarDadosNoGrid();
                        MessageBox.Show("Produto excluído com sucesso!");
                        return;
                    }
                    MessageBox.Show("Exclusão cancelada.");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir o produto: {ex.Message}");
                    return;
                }
            }

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            var procurado = txtBuscaProdutos.Text.Trim();
         
            if (string.IsNullOrEmpty(procurado))
            {
                dataGridView1.DataSource = _listaProdutos;
                return; 
            }

            var listaFiltrada = _listaProdutos
                .Where(p => p.categoria.Contains(procurado) ||
                            p.nome.Contains(procurado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dataGridView1.DataSource = listaFiltrada;

        }

        private void txtBuscaProdutos_Click(object sender, EventArgs e)
        {
            txtBuscaProdutos.Clear();
        }
    }
}
