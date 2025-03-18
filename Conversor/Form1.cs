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

        private double insertaMonedes(String moneda)
        {
            if(moneda == "Euro")
            {
                return 1;
            }
            else if (moneda == "Peseta")
            {
                return 166.38;
            }
            else if (moneda == "Dolar")
            {
                return 1.09;
            }
            else if (moneda == "Leu")
            {
                return 19.78;
            }
            else if (moneda == "Yen")
            {
                return 162.1;
            }
            else if (moneda == "Rupia")
            {
                return 94.58;
            }
            return 0;
        }

        private void borrar(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void conversor(object sender, EventArgs e)
        {
            var moneda1 = insertaMonedes(comboBox1.Text);
            var moneda2 = insertaMonedes(comboBox2.Text);
            var diners = Convert.ToDouble(textBox1.Text);
            diners /= moneda1;
            diners *= moneda2;
            textBox1.Text = diners.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
