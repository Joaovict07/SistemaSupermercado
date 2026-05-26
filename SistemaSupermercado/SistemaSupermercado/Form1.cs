using SistemaSupermercado.Entity;

namespace SistemaSupermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ucCompras1.AoEnviarLista += ReceberDados_E_TrocarTela;
            
        }
        private void ReceberDados_E_TrocarTela(List<Produto> listaRecebida, Compras compra)
        {
            ucCompraRealizada1.CompraRealizada(listaRecebida, compra);
            ucCompras1.Visible = false;
            ucProdutos1.Visible = false;
            ucCompraRealizada1.Visible = true;
            ucCompraRealizada1.BringToFront();
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1Menu_Click(object sender, EventArgs e)
        {

            if (ucProdutos1.Visible != true)
            {
                ucProdutos1.Visible = true;
                ucCompras1.Visible = false;
                ucCompraRealizada1.Visible = false;
            }

        }

        private void btn2Menu_Click(object sender, EventArgs e)
        {
            if (ucCompras1.Visible != true)
            {
                ucProdutos1.Visible = false;
                ucCompras1.Visible = true;
                ucCompraRealizada1.Visible = false;
            }

        }

        private void btn3Menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   
    }
}
