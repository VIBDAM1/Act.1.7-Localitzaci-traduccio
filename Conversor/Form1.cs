namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void posarNumero(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void euroPeseta(object sender, EventArgs e)
        {
            var dinero = Convert.ToDouble(textBox1.Text);
            dinero *= 166.386;
            textBox1.Text = dinero.ToString();
        }

        private void pesetaEuro(object sender, EventArgs e)
        {
            var dinero = Convert.ToDouble(textBox1.Text);
            dinero *= 0.006;
            textBox1.Text = dinero.ToString();
        }

        private void borrar(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}
