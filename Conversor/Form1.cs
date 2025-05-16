using System;
using System.Transactions;
using System.Globalization;

namespace Conversor
{
    public partial class Form1 : Form
    {
        private BindingSource bs;
        public Form1()
        {

            this.KeyPreview = true;
            InitializeComponent();
            Transaccio transaccio1 = new Transaccio("Amadeo", "amca@gmail.com", "12/03/2025", "Euro", "Peseta", 1, 166.38, true, true, false);

            List<Transaccio> transaccio = new List<Transaccio>();
            transaccio.Add(transaccio1);

            bs = new BindingSource();
            bs.DataSource = transaccio;

            dataGridView1.DataSource = bs;

            textBox2.DataBindings.Add("Text", bs, "Client");
            textBox3.DataBindings.Add("Text", bs, "Email");
            textBox6.DataBindings.Add("Text", bs, "Data_transaccio");
            comboBox5.DataBindings.Add("Text", bs, "Divisa1");
            comboBox6.DataBindings.Add("Text", bs, "Divisa2");
            textBox4.DataBindings.Add("Text", bs, "Import1");
            textBox5.DataBindings.Add("Text", bs, "Import2");
            Descompte1.DataBindings.Add("Checked", bs, "Descompte1");
            Descompte2.DataBindings.Add("Checked", bs, "Descompte2");
            Compra.DataBindings.Add("Checked", bs, "Comprat");
            Venta.DataBindings.Add("Checked", bs, "Venut");

            ToolTip tip = new ToolTip();
            tip.SetToolTip(Afegir, "Ctrl+F5");
            tip.SetToolTip(Eliminar, "Ctrl+F8");


        }

        private void posarNumero(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private double insertaMonedes(String moneda)
        {
            if (moneda == "Euro")
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
            var diners = 3.0;
            diners /= moneda1;
            diners *= moneda2;
            textBox1.Text = diners.ToString();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
        }

        private void conversor1(object sender, EventArgs e)
        {
            var diners = 0.0;
            var moneda1 = insertaMonedes(comboBox5.Text);
            var moneda2 = insertaMonedes(comboBox6.Text);
            if (textBox4 != null)
            {
                diners = Convert.ToDouble(textBox4.Text);
            }
            var resultado = diners;
            resultado /= moneda1;
            resultado *= moneda2;
            textBox5.Text = diners.ToString();

            ((Transaccio)bs.Current).Import1 = diners;
            ((Transaccio)bs.Current).Import2 = resultado;
            dataGridView1.Refresh();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            Transaccio transaccio = new Transaccio("", "", "", "", "", 0, 0, true, true, false);
            bs.Add(transaccio);
            int rowIndex = bs.IndexOf(transaccio);
            dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[1];
        }

        private void buttonEsborrar_Click(object sender, EventArgs e)
        {
            // Comprova si hi ha alguna fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obté la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Pregunta si l'usuari està segur de voler esborrar la fila
                DialogResult result = MessageBox.Show("Estàs segur que vols esborrar aquesta fila?", "Confirma acció destructiva", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);

                // Si l'usuari està segur, esborra la fila
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(selectedRow);
                }
            }
            else
            {
                // Mostra el missatge d'error
                labelError.Visible = true;

                // Inicia el temporitzador per amagar el missatge
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 2500; // 2,5 segons
                timer.Tick += (s, ev) =>
                {
                    labelError.Visible = false;
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void Tabcontrol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8 && e.Control)
            {
                buttonEsborrar_Click(sender, e);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5 && e.Control)
            {
                Afegir.PerformClick();
                e.Handled = true;
            }
        }

        private void Ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Per afegir una nova transaccio pulsa (CTRL+F5)" +
                "\nPer eliminar una transaccio selecciona-la i pulsa (CTRL+F8)");
        }

        private void Divisa1_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
            if (comboBox3.Text == "Catalan")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ca");
            }
            else if (comboBox3.Text == "Español")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
            }
            else if (comboBox3.Text == "Ruso")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
            }
            else if (comboBox3.Text == "Chino")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh");
            }
            else if (comboBox3.Text == "Ingles")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-150");
            }
            else if (comboBox3.Text == "Japones")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja");
            }
            this.Controls.Clear();
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Program Files\\Microsoft Visual Studio\\ajuda.html");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Program Files\\Microsoft Visual Studio\\preguntes.html");
        }
    }
}
