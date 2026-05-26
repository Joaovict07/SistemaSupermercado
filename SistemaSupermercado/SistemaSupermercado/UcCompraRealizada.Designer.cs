namespace SistemaSupermercado
{
    partial class UcCompraRealizada
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
            panel1CompraRealizada = new Panel();
            lblSubtitulo3 = new Label();
            lblTitulo6 = new Label();
            panel1DadosCompra = new Panel();
            txtNumNota = new TextBox();
            txtDataCompra = new TextBox();
            txtAtendente = new TextBox();
            txtCliente = new TextBox();
            txtPagto = new TextBox();
            lblAtendente = new Label();
            lblPagto = new Label();
            lblCliente = new Label();
            lblDataCompra = new Label();
            lblDados = new Label();
            lblNumNota = new Label();
            panelItensCompra = new Panel();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Unitário = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            lblItens = new Label();
            panelResumoCompra = new Panel();
            txtNotaSubtotal = new TextBox();
            txtNotaDesconto = new TextBox();
            txtNotaTotal = new TextBox();
            lblNotaTotal = new Label();
            lblNotaDesconto = new Label();
            lblNotaSubtotal = new Label();
            lblResumo = new Label();
            btnNovaCompra = new Button();
            btnFechar = new Button();
            btnNota = new Button();
            panel1CompraRealizada.SuspendLayout();
            panel1DadosCompra.SuspendLayout();
            panelItensCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            panelResumoCompra.SuspendLayout();
            SuspendLayout();
            // 
            // panel1CompraRealizada
            // 
            panel1CompraRealizada.BackColor = Color.White;
            panel1CompraRealizada.BorderStyle = BorderStyle.FixedSingle;
            panel1CompraRealizada.Controls.Add(lblSubtitulo3);
            panel1CompraRealizada.Controls.Add(lblTitulo6);
            panel1CompraRealizada.Location = new Point(4, 42);
            panel1CompraRealizada.Margin = new Padding(4, 5, 4, 5);
            panel1CompraRealizada.Name = "panel1CompraRealizada";
            panel1CompraRealizada.Size = new Size(1156, 130);
            panel1CompraRealizada.TabIndex = 1;
            // 
            // lblSubtitulo3
            // 
            lblSubtitulo3.AutoSize = true;
            lblSubtitulo3.Location = new Point(23, 82);
            lblSubtitulo3.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo3.Name = "lblSubtitulo3";
            lblSubtitulo3.Size = new Size(245, 25);
            lblSubtitulo3.TabIndex = 1;
            lblSubtitulo3.Text = "Detalhes da compra realizada";
            // 
            // lblTitulo6
            // 
            lblTitulo6.AutoSize = true;
            lblTitulo6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo6.Location = new Point(23, 25);
            lblTitulo6.Margin = new Padding(4, 0, 4, 0);
            lblTitulo6.Name = "lblTitulo6";
            lblTitulo6.Size = new Size(233, 38);
            lblTitulo6.TabIndex = 0;
            lblTitulo6.Text = "Nota de Compra";
            // 
            // panel1DadosCompra
            // 
            panel1DadosCompra.BackColor = Color.White;
            panel1DadosCompra.BorderStyle = BorderStyle.FixedSingle;
            panel1DadosCompra.Controls.Add(txtNumNota);
            panel1DadosCompra.Controls.Add(txtDataCompra);
            panel1DadosCompra.Controls.Add(txtAtendente);
            panel1DadosCompra.Controls.Add(txtCliente);
            panel1DadosCompra.Controls.Add(txtPagto);
            panel1DadosCompra.Controls.Add(lblAtendente);
            panel1DadosCompra.Controls.Add(lblPagto);
            panel1DadosCompra.Controls.Add(lblCliente);
            panel1DadosCompra.Controls.Add(lblDataCompra);
            panel1DadosCompra.Controls.Add(lblDados);
            panel1DadosCompra.Controls.Add(lblNumNota);
            panel1DadosCompra.Location = new Point(4, 183);
            panel1DadosCompra.Margin = new Padding(4, 5, 4, 5);
            panel1DadosCompra.Name = "panel1DadosCompra";
            panel1DadosCompra.Size = new Size(478, 570);
            panel1DadosCompra.TabIndex = 2;
            // 
            // txtNumNota
            // 
            txtNumNota.Location = new Point(259, 95);
            txtNumNota.Margin = new Padding(4, 5, 4, 5);
            txtNumNota.Name = "txtNumNota";
            txtNumNota.Size = new Size(141, 31);
            txtNumNota.TabIndex = 10;
            // 
            // txtDataCompra
            // 
            txtDataCompra.Location = new Point(259, 158);
            txtDataCompra.Margin = new Padding(4, 5, 4, 5);
            txtDataCompra.Name = "txtDataCompra";
            txtDataCompra.Size = new Size(141, 31);
            txtDataCompra.TabIndex = 9;
            // 
            // txtAtendente
            // 
            txtAtendente.Location = new Point(259, 357);
            txtAtendente.Margin = new Padding(4, 5, 4, 5);
            txtAtendente.Name = "txtAtendente";
            txtAtendente.Size = new Size(141, 31);
            txtAtendente.TabIndex = 8;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(259, 225);
            txtCliente.Margin = new Padding(4, 5, 4, 5);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(141, 31);
            txtCliente.TabIndex = 7;
            // 
            // txtPagto
            // 
            txtPagto.Location = new Point(259, 290);
            txtPagto.Margin = new Padding(4, 5, 4, 5);
            txtPagto.Name = "txtPagto";
            txtPagto.Size = new Size(141, 31);
            txtPagto.TabIndex = 6;
            // 
            // lblAtendente
            // 
            lblAtendente.AutoSize = true;
            lblAtendente.Font = new Font("Segoe UI", 10F);
            lblAtendente.Location = new Point(26, 363);
            lblAtendente.Margin = new Padding(4, 0, 4, 0);
            lblAtendente.Name = "lblAtendente";
            lblAtendente.Size = new Size(134, 28);
            lblAtendente.TabIndex = 5;
            lblAtendente.Text = "Atendido por:";
            // 
            // lblPagto
            // 
            lblPagto.AutoSize = true;
            lblPagto.Font = new Font("Segoe UI", 10F);
            lblPagto.Location = new Point(26, 297);
            lblPagto.Margin = new Padding(4, 0, 4, 0);
            lblPagto.Name = "lblPagto";
            lblPagto.Size = new Size(203, 28);
            lblPagto.TabIndex = 4;
            lblPagto.Text = "Forma de Pagamento:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F);
            lblCliente.Location = new Point(26, 232);
            lblCliente.Margin = new Padding(4, 0, 4, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(76, 28);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente:";
            // 
            // lblDataCompra
            // 
            lblDataCompra.AutoSize = true;
            lblDataCompra.Font = new Font("Segoe UI", 10F);
            lblDataCompra.Location = new Point(26, 165);
            lblDataCompra.Margin = new Padding(4, 0, 4, 0);
            lblDataCompra.Name = "lblDataCompra";
            lblDataCompra.Size = new Size(159, 28);
            lblDataCompra.TabIndex = 2;
            lblDataCompra.Text = "Data da Compra:";
            // 
            // lblDados
            // 
            lblDados.AutoSize = true;
            lblDados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDados.Location = new Point(23, 32);
            lblDados.Margin = new Padding(4, 0, 4, 0);
            lblDados.Name = "lblDados";
            lblDados.Size = new Size(179, 28);
            lblDados.TabIndex = 1;
            lblDados.Text = "Dados da Compra";
            // 
            // lblNumNota
            // 
            lblNumNota.AutoSize = true;
            lblNumNota.Font = new Font("Segoe UI", 10F);
            lblNumNota.Location = new Point(26, 102);
            lblNumNota.Margin = new Padding(4, 0, 4, 0);
            lblNumNota.Name = "lblNumNota";
            lblNumNota.Size = new Size(164, 28);
            lblNumNota.TabIndex = 0;
            lblNumNota.Text = "Número da Nota:";
            // 
            // panelItensCompra
            // 
            panelItensCompra.BackColor = Color.White;
            panelItensCompra.BorderStyle = BorderStyle.FixedSingle;
            panelItensCompra.Controls.Add(dataGridView4);
            panelItensCompra.Controls.Add(lblItens);
            panelItensCompra.Location = new Point(491, 183);
            panelItensCompra.Margin = new Padding(4, 5, 4, 5);
            panelItensCompra.Name = "panelItensCompra";
            panelItensCompra.Size = new Size(669, 570);
            panelItensCompra.TabIndex = 3;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToOrderColumns = true;
            dataGridView4.AllowUserToResizeRows = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.BackgroundColor = Color.White;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Quantidade, Unitário, Total });
            dataGridView4.Location = new Point(11, 102);
            dataGridView4.Margin = new Padding(4, 5, 4, 5);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.Size = new Size(644, 250);
            dataGridView4.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Produto";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 8;
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // Unitário
            // 
            Unitário.HeaderText = "Unitário (R$)";
            Unitário.MinimumWidth = 8;
            Unitário.Name = "Unitário";
            Unitário.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total (R$)";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // lblItens
            // 
            lblItens.AutoSize = true;
            lblItens.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblItens.Location = new Point(31, 30);
            lblItens.Margin = new Padding(4, 0, 4, 0);
            lblItens.Name = "lblItens";
            lblItens.Size = new Size(166, 28);
            lblItens.TabIndex = 0;
            lblItens.Text = "Itens da Compra";
            // 
            // panelResumoCompra
            // 
            panelResumoCompra.BackColor = Color.White;
            panelResumoCompra.BorderStyle = BorderStyle.FixedSingle;
            panelResumoCompra.Controls.Add(txtNotaSubtotal);
            panelResumoCompra.Controls.Add(txtNotaDesconto);
            panelResumoCompra.Controls.Add(txtNotaTotal);
            panelResumoCompra.Controls.Add(lblNotaTotal);
            panelResumoCompra.Controls.Add(lblNotaDesconto);
            panelResumoCompra.Controls.Add(lblNotaSubtotal);
            panelResumoCompra.Controls.Add(lblResumo);
            panelResumoCompra.Location = new Point(4, 765);
            panelResumoCompra.Margin = new Padding(4, 5, 4, 5);
            panelResumoCompra.Name = "panelResumoCompra";
            panelResumoCompra.Size = new Size(478, 332);
            panelResumoCompra.TabIndex = 4;
            // 
            // txtNotaSubtotal
            // 
            txtNotaSubtotal.Location = new Point(259, 108);
            txtNotaSubtotal.Margin = new Padding(4, 5, 4, 5);
            txtNotaSubtotal.Name = "txtNotaSubtotal";
            txtNotaSubtotal.Size = new Size(141, 31);
            txtNotaSubtotal.TabIndex = 6;
            // 
            // txtNotaDesconto
            // 
            txtNotaDesconto.Location = new Point(259, 180);
            txtNotaDesconto.Margin = new Padding(4, 5, 4, 5);
            txtNotaDesconto.Name = "txtNotaDesconto";
            txtNotaDesconto.Size = new Size(141, 31);
            txtNotaDesconto.TabIndex = 5;
            // 
            // txtNotaTotal
            // 
            txtNotaTotal.Location = new Point(259, 260);
            txtNotaTotal.Margin = new Padding(4, 5, 4, 5);
            txtNotaTotal.Name = "txtNotaTotal";
            txtNotaTotal.Size = new Size(141, 31);
            txtNotaTotal.TabIndex = 4;
            // 
            // lblNotaTotal
            // 
            lblNotaTotal.AutoSize = true;
            lblNotaTotal.Font = new Font("Segoe UI", 10F);
            lblNotaTotal.Location = new Point(26, 267);
            lblNotaTotal.Margin = new Padding(4, 0, 4, 0);
            lblNotaTotal.Name = "lblNotaTotal";
            lblNotaTotal.Size = new Size(160, 28);
            lblNotaTotal.TabIndex = 3;
            lblNotaTotal.Text = "Total da Compra:";
            // 
            // lblNotaDesconto
            // 
            lblNotaDesconto.AutoSize = true;
            lblNotaDesconto.Font = new Font("Segoe UI", 10F);
            lblNotaDesconto.Location = new Point(26, 187);
            lblNotaDesconto.Margin = new Padding(4, 0, 4, 0);
            lblNotaDesconto.Name = "lblNotaDesconto";
            lblNotaDesconto.Size = new Size(139, 28);
            lblNotaDesconto.TabIndex = 2;
            lblNotaDesconto.Text = "Desconto (R$):";
            // 
            // lblNotaSubtotal
            // 
            lblNotaSubtotal.AutoSize = true;
            lblNotaSubtotal.Font = new Font("Segoe UI", 10F);
            lblNotaSubtotal.Location = new Point(26, 115);
            lblNotaSubtotal.Margin = new Padding(4, 0, 4, 0);
            lblNotaSubtotal.Name = "lblNotaSubtotal";
            lblNotaSubtotal.Size = new Size(91, 28);
            lblNotaSubtotal.TabIndex = 1;
            lblNotaSubtotal.Text = "Subtotal:";
            // 
            // lblResumo
            // 
            lblResumo.AutoSize = true;
            lblResumo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResumo.Location = new Point(23, 43);
            lblResumo.Margin = new Padding(4, 0, 4, 0);
            lblResumo.Name = "lblResumo";
            lblResumo.Size = new Size(195, 28);
            lblResumo.TabIndex = 0;
            lblResumo.Text = "Resumo da Compra";
            // 
            // btnNovaCompra
            // 
            btnNovaCompra.BackColor = Color.DeepSkyBlue;
            btnNovaCompra.FlatAppearance.BorderColor = Color.Black;
            btnNovaCompra.FlatStyle = FlatStyle.Popup;
            btnNovaCompra.Font = new Font("Segoe UI", 10F);
            btnNovaCompra.Location = new Point(603, 795);
            btnNovaCompra.Margin = new Padding(4, 5, 4, 5);
            btnNovaCompra.Name = "btnNovaCompra";
            btnNovaCompra.Size = new Size(190, 58);
            btnNovaCompra.TabIndex = 21;
            btnNovaCompra.Text = "Nova Compra";
            btnNovaCompra.UseVisualStyleBackColor = false;
            btnNovaCompra.Click += btnNovaCompra_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Gainsboro;
            btnFechar.FlatAppearance.BorderColor = Color.Black;
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Font = new Font("Segoe UI", 10F);
            btnFechar.Location = new Point(959, 1033);
            btnFechar.Margin = new Padding(4, 5, 4, 5);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(190, 58);
            btnFechar.TabIndex = 22;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // btnNota
            // 
            btnNota.BackColor = Color.Khaki;
            btnNota.FlatAppearance.BorderColor = Color.Black;
            btnNota.FlatStyle = FlatStyle.Popup;
            btnNota.Font = new Font("Segoe UI", 10F);
            btnNota.Location = new Point(840, 795);
            btnNota.Margin = new Padding(4, 5, 4, 5);
            btnNota.Name = "btnNota";
            btnNota.Size = new Size(190, 58);
            btnNota.TabIndex = 23;
            btnNota.Text = "Visualizar Nota";
            btnNota.UseVisualStyleBackColor = false;
            btnNota.Click += btnNota_Click;
            // 
            // UcCompraRealizada
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNota);
            Controls.Add(btnFechar);
            Controls.Add(btnNovaCompra);
            Controls.Add(panelResumoCompra);
            Controls.Add(panelItensCompra);
            Controls.Add(panel1DadosCompra);
            Controls.Add(panel1CompraRealizada);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UcCompraRealizada";
            Size = new Size(1166, 1103);
            panel1CompraRealizada.ResumeLayout(false);
            panel1CompraRealizada.PerformLayout();
            panel1DadosCompra.ResumeLayout(false);
            panel1DadosCompra.PerformLayout();
            panelItensCompra.ResumeLayout(false);
            panelItensCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            panelResumoCompra.ResumeLayout(false);
            panelResumoCompra.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1CompraRealizada;
        private Label lblSubtitulo3;
        private Label lblTitulo6;
        private Panel panel1DadosCompra;
        private Label lblNumNota;
        private Label lblDados;
        private Label lblDataCompra;
        private Label lblAtendente;
        private Label lblPagto;
        private Label lblCliente;
        private Panel panelItensCompra;
        private Label lblItens;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Unitário;
        private DataGridViewTextBoxColumn Total;
        private Panel panelResumoCompra;
        private Label lblResumo;
        private Label lblNotaTotal;
        private Label lblNotaDesconto;
        private Label lblNotaSubtotal;
        private Button btnNovaCompra;
        private Button btnFechar;
        private Button btnNota;
        private TextBox txtPagto;
        private TextBox txtNumNota;
        private TextBox txtDataCompra;
        private TextBox txtAtendente;
        private TextBox txtCliente;
        private TextBox txtNotaDesconto;
        private TextBox txtNotaTotal;
        private TextBox txtNotaSubtotal;
    }
}
