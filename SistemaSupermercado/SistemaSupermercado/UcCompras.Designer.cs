namespace SistemaSupermercado
{
    partial class UcCompras
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1Compras = new Panel();
            lblSubtitulo1 = new Label();
            lblTitulo2 = new Label();
            panel2Compras = new Panel();
            txtBuscaProdutosCompras = new TextBox();
            lblTitulo3 = new Label();
            cboCategoriaCompras = new ComboBox();
            dataGridView1 = new DataGridView();
            CódigoProduto = new DataGridViewTextBoxColumn();
            NomeProduto = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            Estoque = new DataGridViewTextBoxColumn();
            panel4Compras = new Panel();
            panel3Compras = new Panel();
            lblTitulo5 = new Label();
            lblTitulo4 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            lblComprasProduto = new Label();
            lblComprasQtd = new Label();
            numericUpDown1 = new NumericUpDown();
            btnCarrinho = new Button();
            lblSubTotal = new Label();
            btnFinalizarCompra = new Button();
            txtSubTotal = new TextBox();
            txtDesconto = new TextBox();
            lblDesconto = new Label();
            txtTotal = new TextBox();
            lblTotal = new Label();
            btnLimpar = new Button();
            txtCarrinho = new TextBox();
            panel1Compras.SuspendLayout();
            panel2Compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4Compras.SuspendLayout();
            panel3Compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1Compras
            // 
            panel1Compras.BackColor = Color.White;
            panel1Compras.BorderStyle = BorderStyle.FixedSingle;
            panel1Compras.Controls.Add(lblSubtitulo1);
            panel1Compras.Controls.Add(lblTitulo2);
            panel1Compras.Location = new Point(3, 23);
            panel1Compras.Name = "panel1Compras";
            panel1Compras.Size = new Size(810, 79);
            panel1Compras.TabIndex = 0;
            // 
            // lblSubtitulo1
            // 
            lblSubtitulo1.AutoSize = true;
            lblSubtitulo1.Location = new Point(16, 49);
            lblSubtitulo1.Name = "lblSubtitulo1";
            lblSubtitulo1.Size = new Size(207, 15);
            lblSubtitulo1.TabIndex = 1;
            lblSubtitulo1.Text = "Adicione produtos à compra e finalize";
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo2.Location = new Point(16, 15);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(135, 25);
            lblTitulo2.TabIndex = 0;
            lblTitulo2.Text = "Nova Compra";
            // 
            // panel2Compras
            // 
            panel2Compras.BackColor = Color.White;
            panel2Compras.BorderStyle = BorderStyle.FixedSingle;
            panel2Compras.Controls.Add(dataGridView2);
            panel2Compras.Controls.Add(dataGridView1);
            panel2Compras.Controls.Add(cboCategoriaCompras);
            panel2Compras.Controls.Add(txtBuscaProdutosCompras);
            panel2Compras.Controls.Add(lblTitulo3);
            panel2Compras.Location = new Point(3, 108);
            panel2Compras.Name = "panel2Compras";
            panel2Compras.Size = new Size(402, 350);
            panel2Compras.TabIndex = 1;
            // 
            // txtBuscaProdutosCompras
            // 
            txtBuscaProdutosCompras.Font = new Font("Segoe UI", 10F);
            txtBuscaProdutosCompras.Location = new Point(10, 50);
            txtBuscaProdutosCompras.Name = "txtBuscaProdutosCompras";
            txtBuscaProdutosCompras.Size = new Size(238, 25);
            txtBuscaProdutosCompras.TabIndex = 1;
            txtBuscaProdutosCompras.Text = "Pesquisar produtos...";
            // 
            // lblTitulo3
            // 
            lblTitulo3.AutoSize = true;
            lblTitulo3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo3.Location = new Point(10, 16);
            lblTitulo3.Name = "lblTitulo3";
            lblTitulo3.Size = new Size(141, 21);
            lblTitulo3.TabIndex = 0;
            lblTitulo3.Text = "Lista de Produtos";
            // 
            // cboCategoriaCompras
            // 
            cboCategoriaCompras.FormattingEnabled = true;
            cboCategoriaCompras.Location = new Point(265, 52);
            cboCategoriaCompras.Name = "cboCategoriaCompras";
            cboCategoriaCompras.Size = new Size(122, 23);
            cboCategoriaCompras.TabIndex = 12;
            cboCategoriaCompras.Text = "Todas Categorias";
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CódigoProduto, NomeProduto, Preço, Estoque });
            dataGridView1.Location = new Point(10, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(377, 150);
            dataGridView1.TabIndex = 13;
            // 
            // CódigoProduto
            // 
            CódigoProduto.HeaderText = "Código";
            CódigoProduto.Name = "CódigoProduto";
            CódigoProduto.ReadOnly = true;
            // 
            // NomeProduto
            // 
            NomeProduto.HeaderText = "Produto";
            NomeProduto.Name = "NomeProduto";
            NomeProduto.ReadOnly = true;
            // 
            // Preço
            // 
            Preço.HeaderText = "Preço (R$)";
            Preço.Name = "Preço";
            Preço.ReadOnly = true;
            // 
            // Estoque
            // 
            Estoque.HeaderText = "Estoque";
            Estoque.Name = "Estoque";
            Estoque.ReadOnly = true;
            // 
            // panel4Compras
            // 
            panel4Compras.BackColor = Color.White;
            panel4Compras.BorderStyle = BorderStyle.FixedSingle;
            panel4Compras.Controls.Add(btnLimpar);
            panel4Compras.Controls.Add(lblTotal);
            panel4Compras.Controls.Add(txtTotal);
            panel4Compras.Controls.Add(lblDesconto);
            panel4Compras.Controls.Add(txtDesconto);
            panel4Compras.Controls.Add(txtSubTotal);
            panel4Compras.Controls.Add(btnFinalizarCompra);
            panel4Compras.Controls.Add(lblSubTotal);
            panel4Compras.Controls.Add(dataGridView3);
            panel4Compras.Controls.Add(lblTitulo5);
            panel4Compras.Location = new Point(411, 108);
            panel4Compras.Name = "panel4Compras";
            panel4Compras.Size = new Size(402, 551);
            panel4Compras.TabIndex = 2;
            // 
            // panel3Compras
            // 
            panel3Compras.BackColor = Color.White;
            panel3Compras.BorderStyle = BorderStyle.FixedSingle;
            panel3Compras.Controls.Add(txtCarrinho);
            panel3Compras.Controls.Add(btnCarrinho);
            panel3Compras.Controls.Add(numericUpDown1);
            panel3Compras.Controls.Add(lblComprasQtd);
            panel3Compras.Controls.Add(lblComprasProduto);
            panel3Compras.Controls.Add(lblTitulo4);
            panel3Compras.Location = new Point(3, 464);
            panel3Compras.Name = "panel3Compras";
            panel3Compras.Size = new Size(402, 195);
            panel3Compras.TabIndex = 3;
            // 
            // lblTitulo5
            // 
            lblTitulo5.AutoSize = true;
            lblTitulo5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo5.Location = new Point(12, 16);
            lblTitulo5.Name = "lblTitulo5";
            lblTitulo5.Size = new Size(170, 21);
            lblTitulo5.TabIndex = 14;
            lblTitulo5.Text = "Carrinho de Compras";
            // 
            // lblTitulo4
            // 
            lblTitulo4.AutoSize = true;
            lblTitulo4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo4.Location = new Point(10, 15);
            lblTitulo4.Name = "lblTitulo4";
            lblTitulo4.Size = new Size(177, 21);
            lblTitulo4.TabIndex = 15;
            lblTitulo4.Text = "Adicionar ao Carrinho";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView2.Location = new Point(12, 99);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(377, 150);
            dataGridView2.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Código";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Produto";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Preço (R$)";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Estoque";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToOrderColumns = true;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, Quantidade, Valor, Total });
            dataGridView3.Location = new Point(12, 67);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(377, 282);
            dataGridView3.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Produto";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.HeaderText = "Unitário (R$)";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total (R$)";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // lblComprasProduto
            // 
            lblComprasProduto.AutoSize = true;
            lblComprasProduto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblComprasProduto.Location = new Point(3, 57);
            lblComprasProduto.Name = "lblComprasProduto";
            lblComprasProduto.Size = new Size(64, 19);
            lblComprasProduto.TabIndex = 16;
            lblComprasProduto.Text = "Produto";
            // 
            // lblComprasQtd
            // 
            lblComprasQtd.AutoSize = true;
            lblComprasQtd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblComprasQtd.Location = new Point(3, 104);
            lblComprasQtd.Name = "lblComprasQtd";
            lblComprasQtd.Size = new Size(87, 19);
            lblComprasQtd.TabIndex = 17;
            lblComprasQtd.Text = "Quantidade";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(96, 104);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 18;
            // 
            // btnCarrinho
            // 
            btnCarrinho.BackColor = Color.DeepSkyBlue;
            btnCarrinho.FlatAppearance.BorderColor = Color.Black;
            btnCarrinho.FlatStyle = FlatStyle.Popup;
            btnCarrinho.Font = new Font("Segoe UI", 10F);
            btnCarrinho.Location = new Point(265, 138);
            btnCarrinho.Name = "btnCarrinho";
            btnCarrinho.Size = new Size(98, 35);
            btnCarrinho.TabIndex = 20;
            btnCarrinho.Text = "Adicionar";
            btnCarrinho.UseVisualStyleBackColor = false;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 10F);
            lblSubTotal.Location = new Point(74, 366);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(63, 19);
            lblSubTotal.TabIndex = 16;
            lblSubTotal.Text = "Subtotal:";
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.BackColor = Color.LightGreen;
            btnFinalizarCompra.FlatAppearance.BorderColor = Color.Black;
            btnFinalizarCompra.FlatStyle = FlatStyle.Popup;
            btnFinalizarCompra.Font = new Font("Segoe UI", 10F);
            btnFinalizarCompra.Location = new Point(55, 494);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(278, 35);
            btnFinalizarCompra.TabIndex = 21;
            btnFinalizarCompra.Text = "Finalizar Compra";
            btnFinalizarCompra.UseVisualStyleBackColor = false;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(199, 362);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 22;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(199, 403);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(100, 23);
            txtDesconto.TabIndex = 23;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Font = new Font("Segoe UI", 10F);
            lblDesconto.Location = new Point(39, 407);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(98, 19);
            lblDesconto.TabIndex = 24;
            lblDesconto.Text = "Desconto (R$):";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(199, 450);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 25;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(12, 451);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(125, 19);
            lblTotal.TabIndex = 26;
            lblTotal.Text = "Total da Compra:";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.LightCoral;
            btnLimpar.FlatAppearance.BorderColor = Color.Black;
            btnLimpar.FlatStyle = FlatStyle.Popup;
            btnLimpar.Font = new Font("Segoe UI", 10F);
            btnLimpar.Location = new Point(291, 16);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(98, 35);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // txtCarrinho
            // 
            txtCarrinho.Location = new Point(73, 56);
            txtCarrinho.Name = "txtCarrinho";
            txtCarrinho.Size = new Size(314, 23);
            txtCarrinho.TabIndex = 21;
            // 
            // UcCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3Compras);
            Controls.Add(panel4Compras);
            Controls.Add(panel2Compras);
            Controls.Add(panel1Compras);
            Name = "UcCompras";
            Size = new Size(816, 662);
            panel1Compras.ResumeLayout(false);
            panel1Compras.PerformLayout();
            panel2Compras.ResumeLayout(false);
            panel2Compras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4Compras.ResumeLayout(false);
            panel4Compras.PerformLayout();
            panel3Compras.ResumeLayout(false);
            panel3Compras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1Compras;
        private Label lblTitulo2;
        private Label lblSubtitulo1;
        private Panel panel2Compras;
        private Label lblTitulo3;
        private TextBox txtBuscaProdutosCompras;
        private ComboBox cboCategoriaCompras;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CódigoProduto;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn Preço;
        private DataGridViewTextBoxColumn Estoque;
        private Panel panel4Compras;
        private Label lblTitulo5;
        private Panel panel3Compras;
        private Label lblTitulo4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Total;
        private Label lblComprasProduto;
        private Label lblComprasQtd;
        private Button btnCarrinho;
        private Label lblSubTotal;
        private Button btnFinalizarCompra;
        private TextBox txtSubTotal;
        private TextBox txtDesconto;
        private Label lblTotal;
        private TextBox txtTotal;
        private Label lblDesconto;
        private Button btnLimpar;
        private TextBox txtCarrinho;
        private NumericUpDown numericUpDown1;
        //private Button btnCarrinho;
    }
}
