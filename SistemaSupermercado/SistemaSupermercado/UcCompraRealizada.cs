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
        public UcCompraRealizada()
        {
            InitializeComponent();

        }

        private List<Produto> produtos = new List<Produto>();
        private Compras comprasRealizadas = new Compras();

        private void btnNota_Click(object sender, EventArgs e)
        {
            string pastaDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string caminhoArquivo = Path.Combine(pastaDesktop, "nota_fiscal_" + comprasRealizadas.codigo_compra + ".txt");

            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                sw.WriteLine("=============================");
                sw.WriteLine("    SUPERMERCADO C#    ");
                sw.WriteLine("Rua sla, 187 - Vila não sei");
                sw.WriteLine("CNPJ: 198726130001-90");
                sw.WriteLine("Fone: (11) 97802-5658");
                sw.WriteLine("");
                sw.WriteLine("*** NOTA DE COMPRA ***");
                sw.WriteLine("N° da Nota: " + comprasRealizadas.codigo_compra + "      Data:" + DateTime.Now);
                sw.WriteLine("-----------------------------");
                sw.WriteLine("Produto         Qtd    Unitário(R$)   Total(R$)");
                for (int i = 0; i < produtos.Count; i++)
                {
                    sw.WriteLine("" + produtos[i].nome + "    " + produtos[i].quantidade + "   " + produtos[i].preco + "   " + (produtos[i].preco * produtos[i].quantidade));
                }
                sw.WriteLine("-----------------------------");
                sw.WriteLine("TOTAL DA COMPRA      " + comprasRealizadas.total);
                sw.WriteLine("   Obrigado e volte sempre   ");
                sw.WriteLine("=============================");
            }
        }
        public void CompraRealizada(List<Produto> listaDeCompras, Compras compras)
        {
            produtos = listaDeCompras;
            comprasRealizadas = compras;
        }

        private void btnNovaCompra_Click(object sender, EventArgs e)
        {
            
        }
    }
}
