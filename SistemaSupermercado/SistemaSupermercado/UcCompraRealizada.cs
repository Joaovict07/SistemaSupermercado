using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
﻿using SistemaSupermercado.Entity;


namespace SistemaSupermercado
{
    public partial class UcCompraRealizada : UserControl
    {
        private List<Produto> produtos = new List<Produto>();
        private Compras comprasRealizadas = new Compras();
        private string dataCompra = "";
        private List<Produto> carrinhoProds = new List<Produto>();
        public UcCompraRealizada()
        {
            InitializeComponent();
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            string pastaDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string caminhoArquivo = Path.Combine(pastaDesktop, "nota_fiscal_" + comprasRealizadas.codigo_compra + ".txt");


            if (produtos == null) MessageBox.Show("Lista nula!");

            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                sw.WriteLine("=============================");
                sw.WriteLine("    SUPERMERCADO C#    ");
                sw.WriteLine("Rua Carlos Silveira, 187 - Centro");
                sw.WriteLine("CNPJ: 198726130001-90");
                sw.WriteLine("Fone: (11) 97802-5658");
                sw.WriteLine("");
                sw.WriteLine("*** NOTA DE COMPRA ***");
                sw.WriteLine("N° da Nota: " + comprasRealizadas.codigo_compra + "      Data:" + dataCompra);
                sw.WriteLine("-----------------------------");
                sw.WriteLine("Produto          Qtd    Unitário(R$)   Total(R$)");
                for (int i = 0; i < produtos.Count; i++)
                {
                    string nome = produtos[i].nome.PadRight(16);
                    string qtd = produtos[i].quantidade.ToString().PadLeft(4);
                    string unit = produtos[i].preco.ToString("F2").PadLeft(13);
                    string total = (produtos[i].preco * produtos[i].quantidade).ToString("F2").PadLeft(11);

                    sw.WriteLine(nome + qtd + unit + total);
                }
                sw.WriteLine("-----------------------------");
                sw.WriteLine("TOTAL DA COMPRA      R$" + comprasRealizadas.total);
                sw.WriteLine("   Obrigado e volte sempre   ");
                sw.WriteLine("=============================");
            }

            MessageBox.Show("Nota fiscal foi criada com sucesso!");
        }
        public void CompraRealizada(List<Produto> listaDeCompras, Compras compras)
        {
            produtos = listaDeCompras;
            comprasRealizadas = compras;

            dataCompra = DateTime.Now.ToString();
            txtNumNota.Text = comprasRealizadas.codigo_compra;
            txtDataCompra.Text = dataCompra;
            txtCliente.Text = "Usuário";
            txtCliente.Enabled = false;
            txtPagto.Text = "Dinheiro";
            txtAtendente.Text = "Administrador";
            txtAtendente.Enabled = false;

            txtNotaSubtotal.Text = comprasRealizadas.subtotal.ToString();
            txtNotaDesconto.Text = comprasRealizadas.desconto.ToString();
            txtNotaTotal.Text = comprasRealizadas.total.ToString();


            dataGridView4.AutoGenerateColumns = false;
            dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            Quantidade.DataPropertyName = "quantidade";
            Unitário.DataPropertyName = "preco";
            Total.DataPropertyName = "total";

            dataGridView4.DataSource = produtos.ToList();
        }

        private void btnNovaCompra_Click(object sender, EventArgs e)
        {

        }

    }
}
