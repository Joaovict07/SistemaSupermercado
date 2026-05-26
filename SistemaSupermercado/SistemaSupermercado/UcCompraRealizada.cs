using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SistemaSupermercado
{
    public partial class UcCompraRealizada : UserControl
    {
        public UcCompraRealizada()
        {
            InitializeComponent();
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            string pastaDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string caminhoArquivo = Path.Combine(pastaDesktop, "nota_fiscal" + numNota + ".txt");

            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                sw.WriteLine("=============================");
                sw.WriteLine("    SUPERMERCADO C#    ");
                sw.WriteLine("Rua sla, 187 - Vila não sei");
                sw.WriteLine("CNPJ: 198726130001-90");
                sw.WriteLine("Fone: (11) 97802-5658");
                sw.WriteLine("");
                sw.WriteLine("*** NOTA DE COMPRA ***");
                sw.WriteLine("N° da Nota: " + numAleatorio + "      Data:" + DateTime.Now);
                sw.WriteLine("-----------------------------");
                sw.WriteLine("Produto         Qtd    Unitário(R$)   Total(R$)");
                for (int i = 0; i < prod.lenght; i++)
                {
                    sw.WriteLine("" + nomeProduto + "    " + qtdProduto + "   " + precoUnitario + "   " + valorTotal);
                }
                sw.WriteLine("-----------------------------");
                sw.WriteLine("TOTAL DA COMPRA      " + valorTotal);
                sw.WriteLine("   Obrigado e volte sempre   ");
                sw.WriteLine("=============================");
            }
        }
    }
}
