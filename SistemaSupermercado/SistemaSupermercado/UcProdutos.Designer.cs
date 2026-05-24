namespace SistemaSupermercado
{
    partial class UcProdutos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitulo1 = new Label();
            lblSubtitulo1 = new Label();
            lblCodigo = new Label();
            lblNomeProd = new Label();
            panel1Produtos = new Panel();
            panel2Produtos = new Panel();
            lblCategoria = new Label();
            lblQtd = new Label();
            lblPreço = new Label();
            txtCodigo = new TextBox();
            txtNomeProd = new TextBox();
            txtQtd = new TextBox();
            txtPreço = new TextBox();
            cboCategoria = new ComboBox();
            btnCadastrar = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            panel1 = new Panel();
            txtBuscaProdutos = new TextBox();
            btnBusca = new Button();
            dataGridView1 = new DataGridView();
            CódigoProduto = new DataGridViewTextBoxColumn();
            NomeProduto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Estoque = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            panel1Produtos.SuspendLayout();
            panel2Produtos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo1.Location = new Point(10, 17);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(206, 25);
            lblTitulo1.TabIndex = 0;
            lblTitulo1.Text = "Cadastro de Produtos";
            // 
            // lblSubtitulo1
            // 
            lblSubtitulo1.AutoSize = true;
            lblSubtitulo1.Font = new Font("Segoe UI", 8F);
            lblSubtitulo1.Location = new Point(10, 48);
            lblSubtitulo1.Name = "lblSubtitulo1";
            lblSubtitulo1.Size = new Size(275, 13);
            lblSubtitulo1.TabIndex = 1;
            lblSubtitulo1.Text = "Cadastre, edite ou remova produtos do seu estoque";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 10F);
            lblCodigo.Location = new Point(10, 21);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(127, 19);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código do Produto";
            // 
            // lblNomeProd
            // 
            lblNomeProd.AutoSize = true;
            lblNomeProd.Font = new Font("Segoe UI", 10F);
            lblNomeProd.Location = new Point(10, 58);
            lblNomeProd.Name = "lblNomeProd";
            lblNomeProd.Size = new Size(120, 19);
            lblNomeProd.TabIndex = 3;
            lblNomeProd.Text = "Nome do Produto";
            // 
            // panel1Produtos
            // 
            panel1Produtos.BackColor = Color.White;
            panel1Produtos.BorderStyle = BorderStyle.FixedSingle;
            panel1Produtos.Controls.Add(lblTitulo1);
            panel1Produtos.Controls.Add(lblSubtitulo1);
            panel1Produtos.Location = new Point(3, 24);
            panel1Produtos.Name = "panel1Produtos";
            panel1Produtos.Size = new Size(810, 79);
            panel1Produtos.TabIndex = 4;
            // 
            // panel2Produtos
            // 
            panel2Produtos.BackColor = Color.White;
            panel2Produtos.BorderStyle = BorderStyle.FixedSingle;
            panel2Produtos.Controls.Add(btnLimpar);
            panel2Produtos.Controls.Add(btnExcluir);
            panel2Produtos.Controls.Add(btnAtualizar);
            panel2Produtos.Controls.Add(btnCadastrar);
            panel2Produtos.Controls.Add(cboCategoria);
            panel2Produtos.Controls.Add(txtPreço);
            panel2Produtos.Controls.Add(txtQtd);
            panel2Produtos.Controls.Add(txtNomeProd);
            panel2Produtos.Controls.Add(txtCodigo);
            panel2Produtos.Controls.Add(lblPreço);
            panel2Produtos.Controls.Add(lblQtd);
            panel2Produtos.Controls.Add(lblCategoria);
            panel2Produtos.Controls.Add(lblCodigo);
            panel2Produtos.Controls.Add(lblNomeProd);
            panel2Produtos.Location = new Point(3, 109);
            panel2Produtos.Name = "panel2Produtos";
            panel2Produtos.Size = new Size(810, 265);
            panel2Produtos.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 10F);
            lblCategoria.Location = new Point(10, 93);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(68, 19);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria";
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Font = new Font("Segoe UI", 10F);
            lblQtd.Location = new Point(10, 129);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(157, 19);
            lblQtd.TabIndex = 5;
            lblQtd.Text = "Quantidade em Estoque";
            // 
            // lblPreço
            // 
            lblPreço.AutoSize = true;
            lblPreço.Font = new Font("Segoe UI", 10F);
            lblPreço.Location = new Point(10, 171);
            lblPreço.Name = "lblPreço";
            lblPreço.Size = new Size(71, 19);
            lblPreço.TabIndex = 6;
            lblPreço.Text = "Preço (R$)";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(212, 17);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(135, 23);
            txtCodigo.TabIndex = 7;
            // 
            // txtNomeProd
            // 
            txtNomeProd.Location = new Point(212, 54);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(135, 23);
            txtNomeProd.TabIndex = 8;
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(212, 125);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(135, 23);
            txtQtd.TabIndex = 9;
            // 
            // txtPreço
            // 
            txtPreço.Location = new Point(212, 167);
            txtPreço.Name = "txtPreço";
            txtPreço.Size = new Size(135, 23);
            txtPreço.TabIndex = 10;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(212, 89);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(135, 23);
            cboCategoria.TabIndex = 11;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DeepSkyBlue;
            btnCadastrar.FlatAppearance.BorderColor = Color.Black;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Font = new Font("Segoe UI", 10F);
            btnCadastrar.Location = new Point(22, 216);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(98, 35);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Khaki;
            btnAtualizar.FlatAppearance.BorderColor = Color.Black;
            btnAtualizar.FlatStyle = FlatStyle.Popup;
            btnAtualizar.Font = new Font("Segoe UI", 10F);
            btnAtualizar.Location = new Point(155, 216);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(98, 35);
            btnAtualizar.TabIndex = 13;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.FlatAppearance.BorderColor = Color.Black;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.Font = new Font("Segoe UI", 10F);
            btnExcluir.Location = new Point(283, 217);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(98, 34);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Gainsboro;
            btnLimpar.FlatAppearance.BorderColor = Color.Black;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Segoe UI", 10F);
            btnLimpar.Location = new Point(409, 218);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(98, 33);
            btnLimpar.TabIndex = 15;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnBusca);
            panel1.Controls.Add(txtBuscaProdutos);
            panel1.Location = new Point(3, 380);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 279);
            panel1.TabIndex = 6;
            // 
            // txtBuscaProdutos
            // 
            txtBuscaProdutos.Font = new Font("Segoe UI", 10F);
            txtBuscaProdutos.Location = new Point(10, 24);
            txtBuscaProdutos.Name = "txtBuscaProdutos";
            txtBuscaProdutos.Size = new Size(256, 25);
            txtBuscaProdutos.TabIndex = 0;
            txtBuscaProdutos.Text = "Pesquisar produtos...";
            // 
            // btnBusca
            // 
            btnBusca.BackColor = Color.WhiteSmoke;
            btnBusca.FlatAppearance.BorderColor = Color.Black;
            btnBusca.FlatStyle = FlatStyle.Popup;
            btnBusca.Font = new Font("Segoe UI", 10F);
            btnBusca.Location = new Point(272, 24);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(75, 25);
            btnBusca.TabIndex = 1;
            btnBusca.Text = "Buscar";
            btnBusca.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CódigoProduto, NomeProduto, Categoria, Estoque, Preço, Data });
            dataGridView1.Location = new Point(10, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(797, 150);
            dataGridView1.TabIndex = 2;
            // 
            // CódigoProduto
            // 
            CódigoProduto.HeaderText = "Código";
            CódigoProduto.Name = "CódigoProduto";
            CódigoProduto.ReadOnly = true;
            // 
            // NomeProduto
            // 
            NomeProduto.HeaderText = "Nome do Produto";
            NomeProduto.Name = "NomeProduto";
            NomeProduto.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Estoque
            // 
            Estoque.HeaderText = "Estoque";
            Estoque.Name = "Estoque";
            Estoque.ReadOnly = true;
            // 
            // Preço
            // 
            Preço.HeaderText = "Preço (R$)";
            Preço.Name = "Preço";
            Preço.ReadOnly = true;
            // 
            // Data
            // 
            Data.HeaderText = "Data Cadastro";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // UcProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2Produtos);
            Controls.Add(panel1Produtos);
            Name = "UcProdutos";
            Size = new Size(816, 662);
            panel1Produtos.ResumeLayout(false);
            panel1Produtos.PerformLayout();
            panel2Produtos.ResumeLayout(false);
            panel2Produtos.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo1;
        private Label lblSubtitulo1;
        private Label lblCodigo;
        private Label lblNomeProd;
        private Panel panel1Produtos;
        private Panel panel2Produtos;
        private Label lblCategoria;
        private Label lblQtd;
        private TextBox txtPreço;
        private TextBox txtQtd;
        private TextBox txtNomeProd;
        private TextBox txtCodigo;
        private Label lblPreço;
        private ComboBox cboCategoria;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnCadastrar;
        private Panel panel1;
        private Button btnBusca;
        private TextBox txtBuscaProdutos;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CódigoProduto;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Estoque;
        private DataGridViewTextBoxColumn Preço;
        private DataGridViewTextBoxColumn Data;
    }
}
