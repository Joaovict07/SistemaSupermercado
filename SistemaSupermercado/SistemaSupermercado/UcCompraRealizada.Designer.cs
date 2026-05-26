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
            lblNumNota = new Label();
            lblDados = new Label();
            lblDataCompra = new Label();
            lblCliente = new Label();
            lblPagto = new Label();
            lblAtendente = new Label();
            panelItensCompra = new Panel();
            lblItens = new Label();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Unitário = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panelResumoCompra = new Panel();
            lblResumo = new Label();
            lblNotaSubtotal = new Label();
            lblNotaDesconto = new Label();
            lblNotaTotal = new Label();
            btnNovaCompra = new Button();
            btnFechar = new Button();
            btnNota = new Button();
            txtPagto = new TextBox();
            txtCliente = new TextBox();
            txtAtendente = new TextBox();
            txtDataCompra = new TextBox();
            txtNumNota = new TextBox();
            txtNotaTotal = new TextBox();
            txtNotaDesconto = new TextBox();
            txtNotaSubtotal = new TextBox();
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
            panel1CompraRealizada.Location = new Point(3, 25);
            panel1CompraRealizada.Name = "panel1CompraRealizada";
            panel1CompraRealizada.Size = new Size(810, 79);
            panel1CompraRealizada.TabIndex = 1;
            // 
            // lblSubtitulo3
            // 
            lblSubtitulo3.AutoSize = true;
            lblSubtitulo3.Location = new Point(16, 49);
            lblSubtitulo3.Name = "lblSubtitulo3";
            lblSubtitulo3.Size = new Size(161, 15);
            lblSubtitulo3.TabIndex = 1;
            lblSubtitulo3.Text = "Detalhes da compra realizada";
            // 
            // lblTitulo6
            // 
            lblTitulo6.AutoSize = true;
            lblTitulo6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo6.Location = new Point(16, 15);
            lblTitulo6.Name = "lblTitulo6";
            lblTitulo6.Size = new Size(159, 25);
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
            panel1DadosCompra.Location = new Point(3, 110);
            panel1DadosCompra.Name = "panel1DadosCompra";
            panel1DadosCompra.Size = new Size(335, 343);
            panel1DadosCompra.TabIndex = 2;
            // 
            // lblNumNota
            // 
            lblNumNota.AutoSize = true;
            lblNumNota.Font = new Font("Segoe UI", 10F);
            lblNumNota.Location = new Point(18, 61);
            lblNumNota.Name = "lblNumNota";
            lblNumNota.Size = new Size(115, 19);
            lblNumNota.TabIndex = 0;
            lblNumNota.Text = "Número da Nota:";
            // 
            // lblDados
            // 
            lblDados.AutoSize = true;
            lblDados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDados.Location = new Point(16, 19);
            lblDados.Name = "lblDados";
            lblDados.Size = new Size(130, 19);
            lblDados.TabIndex = 1;
            lblDados.Text = "Dados da Compra";
            // 
            // lblDataCompra
            // 
            lblDataCompra.AutoSize = true;
            lblDataCompra.Font = new Font("Segoe UI", 10F);
            lblDataCompra.Location = new Point(18, 99);
            lblDataCompra.Name = "lblDataCompra";
            lblDataCompra.Size = new Size(113, 19);
            lblDataCompra.TabIndex = 2;
            lblDataCompra.Text = "Data da Compra:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F);
            lblCliente.Location = new Point(18, 139);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(54, 19);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente:";
            // 
            // lblPagto
            // 
            lblPagto.AutoSize = true;
            lblPagto.Font = new Font("Segoe UI", 10F);
            lblPagto.Location = new Point(18, 178);
            lblPagto.Name = "lblPagto";
            lblPagto.Size = new Size(144, 19);
            lblPagto.TabIndex = 4;
            lblPagto.Text = "Forma de Pagamento:";
            // 
            // lblAtendente
            // 
            lblAtendente.AutoSize = true;
            lblAtendente.Font = new Font("Segoe UI", 10F);
            lblAtendente.Location = new Point(18, 218);
            lblAtendente.Name = "lblAtendente";
            lblAtendente.Size = new Size(93, 19);
            lblAtendente.TabIndex = 5;
            lblAtendente.Text = "Atendido por:";
            // 
            // panelItensCompra
            // 
            panelItensCompra.BackColor = Color.White;
            panelItensCompra.BorderStyle = BorderStyle.FixedSingle;
            panelItensCompra.Controls.Add(dataGridView4);
            panelItensCompra.Controls.Add(lblItens);
            panelItensCompra.Location = new Point(344, 110);
            panelItensCompra.Name = "panelItensCompra";
            panelItensCompra.Size = new Size(469, 343);
            panelItensCompra.TabIndex = 3;
            // 
            // lblItens
            // 
            lblItens.AutoSize = true;
            lblItens.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblItens.Location = new Point(22, 18);
            lblItens.Name = "lblItens";
            lblItens.Size = new Size(119, 19);
            lblItens.TabIndex = 0;
            lblItens.Text = "Itens da Compra";
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
            dataGridView4.Location = new Point(8, 61);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.Size = new Size(451, 150);
            dataGridView4.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Produto";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // Unitário
            // 
            Unitário.HeaderText = "Unitário (R$)";
            Unitário.Name = "Unitário";
            Unitário.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total (R$)";
            Total.Name = "Total";
            Total.ReadOnly = true;
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
            panelResumoCompra.Location = new Point(3, 459);
            panelResumoCompra.Name = "panelResumoCompra";
            panelResumoCompra.Size = new Size(335, 200);
            panelResumoCompra.TabIndex = 4;
            // 
            // lblResumo
            // 
            lblResumo.AutoSize = true;
            lblResumo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResumo.Location = new Point(16, 26);
            lblResumo.Name = "lblResumo";
            lblResumo.Size = new Size(141, 19);
            lblResumo.TabIndex = 0;
            lblResumo.Text = "Resumo da Compra";
            // 
            // lblNotaSubtotal
            // 
            lblNotaSubtotal.AutoSize = true;
            lblNotaSubtotal.Font = new Font("Segoe UI", 10F);
            lblNotaSubtotal.Location = new Point(18, 69);
            lblNotaSubtotal.Name = "lblNotaSubtotal";
            lblNotaSubtotal.Size = new Size(63, 19);
            lblNotaSubtotal.TabIndex = 1;
            lblNotaSubtotal.Text = "Subtotal:";
            // 
            // lblNotaDesconto
            // 
            lblNotaDesconto.AutoSize = true;
            lblNotaDesconto.Font = new Font("Segoe UI", 10F);
            lblNotaDesconto.Location = new Point(18, 112);
            lblNotaDesconto.Name = "lblNotaDesconto";
            lblNotaDesconto.Size = new Size(98, 19);
            lblNotaDesconto.TabIndex = 2;
            lblNotaDesconto.Text = "Desconto (R$):";
            // 
            // lblNotaTotal
            // 
            lblNotaTotal.AutoSize = true;
            lblNotaTotal.Font = new Font("Segoe UI", 10F);
            lblNotaTotal.Location = new Point(18, 160);
            lblNotaTotal.Name = "lblNotaTotal";
            lblNotaTotal.Size = new Size(113, 19);
            lblNotaTotal.TabIndex = 3;
            lblNotaTotal.Text = "Total da Compra:";
            // 
            // btnNovaCompra
            // 
            btnNovaCompra.BackColor = Color.DeepSkyBlue;
            btnNovaCompra.FlatAppearance.BorderColor = Color.Black;
            btnNovaCompra.FlatStyle = FlatStyle.Popup;
            btnNovaCompra.Font = new Font("Segoe UI", 10F);
            btnNovaCompra.Location = new Point(422, 477);
            btnNovaCompra.Name = "btnNovaCompra";
            btnNovaCompra.Size = new Size(133, 35);
            btnNovaCompra.TabIndex = 21;
            btnNovaCompra.Text = "Nova Compra";
            btnNovaCompra.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Gainsboro;
            btnFechar.FlatAppearance.BorderColor = Color.Black;
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Font = new Font("Segoe UI", 10F);
            btnFechar.Location = new Point(671, 620);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(133, 35);
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
            btnNota.Location = new Point(588, 477);
            btnNota.Name = "btnNota";
            btnNota.Size = new Size(133, 35);
            btnNota.TabIndex = 23;
            btnNota.Text = "Visualizar Nota";
            btnNota.UseVisualStyleBackColor = false;
            // 
            // txtPagto
            // 
            txtPagto.Location = new Point(181, 174);
            txtPagto.Name = "txtPagto";
            txtPagto.Size = new Size(100, 23);
            txtPagto.TabIndex = 6;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(181, 135);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 7;
            // 
            // txtAtendente
            // 
            txtAtendente.Location = new Point(181, 214);
            txtAtendente.Name = "txtAtendente";
            txtAtendente.Size = new Size(100, 23);
            txtAtendente.TabIndex = 8;
            // 
            // txtDataCompra
            // 
            txtDataCompra.Location = new Point(181, 95);
            txtDataCompra.Name = "txtDataCompra";
            txtDataCompra.Size = new Size(100, 23);
            txtDataCompra.TabIndex = 9;
            // 
            // txtNumNota
            // 
            txtNumNota.Location = new Point(181, 57);
            txtNumNota.Name = "txtNumNota";
            txtNumNota.Size = new Size(100, 23);
            txtNumNota.TabIndex = 10;
            // 
            // txtNotaTotal
            // 
            txtNotaTotal.Location = new Point(181, 156);
            txtNotaTotal.Name = "txtNotaTotal";
            txtNotaTotal.Size = new Size(100, 23);
            txtNotaTotal.TabIndex = 4;
            // 
            // txtNotaDesconto
            // 
            txtNotaDesconto.Location = new Point(181, 108);
            txtNotaDesconto.Name = "txtNotaDesconto";
            txtNotaDesconto.Size = new Size(100, 23);
            txtNotaDesconto.TabIndex = 5;
            // 
            // txtNotaSubtotal
            // 
            txtNotaSubtotal.Location = new Point(181, 65);
            txtNotaSubtotal.Name = "txtNotaSubtotal";
            txtNotaSubtotal.Size = new Size(100, 23);
            txtNotaSubtotal.TabIndex = 6;
            // 
            // UcCompraRealizada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNota);
            Controls.Add(btnFechar);
            Controls.Add(btnNovaCompra);
            Controls.Add(panelResumoCompra);
            Controls.Add(panelItensCompra);
            Controls.Add(panel1DadosCompra);
            Controls.Add(panel1CompraRealizada);
            Name = "UcCompraRealizada";
            Size = new Size(816, 662);
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
