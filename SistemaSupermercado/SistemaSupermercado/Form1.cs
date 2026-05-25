namespace SistemaSupermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            }

        }

        private void btn2Menu_Click(object sender, EventArgs e)
        {
            if (ucCompras1.Visible != true)
            {
                ucProdutos1.Visible = false;
                ucCompras1.Visible = true;
            }

        }

        private void btn3Menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
