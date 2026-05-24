using SistemaSupermercado.Data;
using SistemaSupermercado.Modelo;

namespace SistemaSupermercado
{
    public partial class UcProdutos : UserControl
    {
        public UcProdutos()
        {
            InitializeComponent();
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

        private void CarregarDadosNoGrid()
        {
            dataGridView1.AutoGenerateColumns = false;

            CódigoProduto.DataPropertyName = "codigo";
            NomeProduto.DataPropertyName = "nome";
            Categoria.DataPropertyName = "categoria";
            Estoque.DataPropertyName = "quantidade";
            Preço.DataPropertyName = "preco";
            Data.DataPropertyName = "data_cadastro";
            using (var contexto = new BancoContext())
            {
                var listaDeProdutos = contexto.Produtos.ToList();
                dataGridView1.DataSource = listaDeProdutos;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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

            using (var contexto = new BancoContext())
            {
                var produto = new Produto
                {
                    codigo = codigoProduto,
                    nome = nomeProduto,
                    categoria = categoria,
                    quantidade = quatidade,
                    preco = preco,
                    data_cadastro = DateTime.Parse(dataCadastro)
                };
                contexto.Produtos.Add(produto);
                contexto.SaveChanges();
                MessageBox.Show("Produto cadastrado com sucesso!");
                LimparCampos();
                CarregarDadosNoGrid();
            }
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

            using (var contexto = new BancoContext())
            {
                var produto = contexto.Produtos.FirstOrDefault(p => p.codigo == codigoProduto);
                if (produto != null)
                {
                    produto.nome = nomeProduto;
                    produto.categoria = categoria;
                    produto.quantidade = quatidade;
                    produto.preco = preco;
                    produto.data_cadastro = DateTime.Parse(dataCadastro);
                    contexto.SaveChanges();
                    MessageBox.Show("Produto atualizado com sucesso!");
                    LimparCampos();
                    CarregarDadosNoGrid();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado para atualização.");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()))
            {
                MessageBox.Show("Por favor, selecione um produto para excluir.");
                return;
            }
            using (var contexto = new BancoContext())
            {
                var produto = contexto.Produtos.FirstOrDefault(p => p.codigo == txtCodigo.Text.Trim());
                if (produto != null)
                {
                    contexto.Produtos.Remove(produto);
                    contexto.SaveChanges();
                    MessageBox.Show("Produto excluído com sucesso!");
                    LimparCampos();
                    CarregarDadosNoGrid();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado para exclusão.");
                }
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            var procurado = txtBuscaProdutos.Text.Trim();
            using (var contexto = new BancoContext())
            {
                var resultados = contexto.Produtos
                    .Where(p => p.nome.Contains(procurado) || p.categoria.Contains(procurado))
                    .ToList();
                dataGridView1.DataSource = resultados;
            }
        }

        private void txtBuscaProdutos_Click(object sender, EventArgs e)
        {
            txtBuscaProdutos.Clear();
        }
    }
}
