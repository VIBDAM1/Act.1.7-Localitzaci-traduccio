using System.Windows.Forms;

namespace Conversor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Tabcontrol = new TabControl();
            Conversor = new TabPage();
            button12 = new Button();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            Borrar = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            Gestio = new TabPage();
            Ajuda = new Button();
            labelError = new Label();
            textBox6 = new TextBox();
            Descompte2 = new CheckBox();
            Descompte1 = new CheckBox();
            Venta = new RadioButton();
            Compra = new RadioButton();
            Divisa2 = new Label();
            Divisa1 = new Label();
            Importe2 = new Label();
            Importe1 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            data_transaccio = new Label();
            Eliminar = new Button();
            Afegir = new Button();
            textBox3 = new TextBox();
            Email = new Label();
            textBox2 = new TextBox();
            Client = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            helpProvider1 = new HelpProvider();
            toolTip1 = new ToolTip(components);
            button13 = new Button();
            Tabcontrol.SuspendLayout();
            Conversor.SuspendLayout();
            Gestio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Tabcontrol
            // 
            Tabcontrol.Controls.Add(Conversor);
            Tabcontrol.Controls.Add(Gestio);
            resources.ApplyResources(Tabcontrol, "Tabcontrol");
            Tabcontrol.Name = "Tabcontrol";
            Tabcontrol.SelectedIndex = 0;
            Tabcontrol.KeyDown += Tabcontrol_KeyDown;
            // 
            // Conversor
            // 
            Conversor.Controls.Add(button13);
            Conversor.Controls.Add(button12);
            Conversor.Controls.Add(label4);
            Conversor.Controls.Add(comboBox3);
            Conversor.Controls.Add(label2);
            Conversor.Controls.Add(comboBox2);
            Conversor.Controls.Add(comboBox1);
            Conversor.Controls.Add(button1);
            Conversor.Controls.Add(Borrar);
            Conversor.Controls.Add(button11);
            Conversor.Controls.Add(button10);
            Conversor.Controls.Add(button9);
            Conversor.Controls.Add(button8);
            Conversor.Controls.Add(button7);
            Conversor.Controls.Add(button6);
            Conversor.Controls.Add(button5);
            Conversor.Controls.Add(button4);
            Conversor.Controls.Add(button3);
            Conversor.Controls.Add(button2);
            Conversor.Controls.Add(textBox1);
            Conversor.Controls.Add(label1);
            resources.ApplyResources(Conversor, "Conversor");
            Conversor.Name = "Conversor";
            Conversor.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            resources.ApplyResources(button12, "button12");
            button12.Name = "button12";
            helpProvider1.SetShowHelp(button12, (bool)resources.GetObject("button12.ShowHelp"));
            toolTip1.SetToolTip(button12, resources.GetString("button12.ToolTip"));
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { resources.GetString("comboBox3.Items"), resources.GetString("comboBox3.Items1"), resources.GetString("comboBox3.Items2"), resources.GetString("comboBox3.Items3"), resources.GetString("comboBox3.Items4"), resources.GetString("comboBox3.Items5") });
            resources.ApplyResources(comboBox3, "comboBox3");
            comboBox3.Name = "comboBox3";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.AddRange(new object[] { resources.GetString("comboBox2.Items"), resources.GetString("comboBox2.Items1"), resources.GetString("comboBox2.Items2"), resources.GetString("comboBox2.Items3"), resources.GetString("comboBox2.Items4"), resources.GetString("comboBox2.Items5") });
            resources.ApplyResources(comboBox2, "comboBox2");
            comboBox2.Name = "comboBox2";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2"), resources.GetString("comboBox1.Items3"), resources.GetString("comboBox1.Items4"), resources.GetString("comboBox1.Items5") });
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Name = "comboBox1";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += conversor;
            // 
            // Borrar
            // 
            resources.ApplyResources(Borrar, "Borrar");
            Borrar.Name = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            resources.ApplyResources(button11, "button11");
            button11.Name = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            resources.ApplyResources(button10, "button10");
            button10.Name = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            resources.ApplyResources(button9, "button9");
            button9.Name = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            resources.ApplyResources(button8, "button8");
            button8.Name = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            resources.ApplyResources(button7, "button7");
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            toolTip1.SetToolTip(textBox1, resources.GetString("textBox1.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // Gestio
            // 
            Gestio.Controls.Add(Ajuda);
            Gestio.Controls.Add(labelError);
            Gestio.Controls.Add(textBox6);
            Gestio.Controls.Add(Descompte2);
            Gestio.Controls.Add(Descompte1);
            Gestio.Controls.Add(Venta);
            Gestio.Controls.Add(Compra);
            Gestio.Controls.Add(Divisa2);
            Gestio.Controls.Add(Divisa1);
            Gestio.Controls.Add(Importe2);
            Gestio.Controls.Add(Importe1);
            Gestio.Controls.Add(textBox5);
            Gestio.Controls.Add(textBox4);
            Gestio.Controls.Add(comboBox6);
            Gestio.Controls.Add(comboBox5);
            Gestio.Controls.Add(data_transaccio);
            Gestio.Controls.Add(Eliminar);
            Gestio.Controls.Add(Afegir);
            Gestio.Controls.Add(textBox3);
            Gestio.Controls.Add(Email);
            Gestio.Controls.Add(textBox2);
            Gestio.Controls.Add(Client);
            Gestio.Controls.Add(label3);
            Gestio.Controls.Add(dataGridView1);
            resources.ApplyResources(Gestio, "Gestio");
            Gestio.Name = "Gestio";
            Gestio.UseVisualStyleBackColor = true;
            // 
            // Ajuda
            // 
            resources.ApplyResources(Ajuda, "Ajuda");
            Ajuda.Name = "Ajuda";
            toolTip1.SetToolTip(Ajuda, resources.GetString("Ajuda.ToolTip"));
            Ajuda.UseVisualStyleBackColor = true;
            Ajuda.Click += Ajuda_Click;
            // 
            // labelError
            // 
            resources.ApplyResources(labelError, "labelError");
            labelError.ForeColor = Color.Red;
            labelError.Name = "labelError";
            // 
            // textBox6
            // 
            resources.ApplyResources(textBox6, "textBox6");
            textBox6.Name = "textBox6";
            // 
            // Descompte2
            // 
            resources.ApplyResources(Descompte2, "Descompte2");
            Descompte2.Name = "Descompte2";
            Descompte2.UseVisualStyleBackColor = true;
            // 
            // Descompte1
            // 
            resources.ApplyResources(Descompte1, "Descompte1");
            Descompte1.Name = "Descompte1";
            Descompte1.UseVisualStyleBackColor = true;
            // 
            // Venta
            // 
            resources.ApplyResources(Venta, "Venta");
            Venta.Name = "Venta";
            Venta.TabStop = true;
            Venta.UseVisualStyleBackColor = true;
            // 
            // Compra
            // 
            resources.ApplyResources(Compra, "Compra");
            Compra.Name = "Compra";
            Compra.TabStop = true;
            Compra.UseVisualStyleBackColor = true;
            // 
            // Divisa2
            // 
            resources.ApplyResources(Divisa2, "Divisa2");
            Divisa2.Name = "Divisa2";
            // 
            // Divisa1
            // 
            resources.ApplyResources(Divisa1, "Divisa1");
            Divisa1.Name = "Divisa1";
            Divisa1.Click += Divisa1_Click;
            // 
            // Importe2
            // 
            resources.ApplyResources(Importe2, "Importe2");
            Importe2.Name = "Importe2";
            // 
            // Importe1
            // 
            resources.ApplyResources(Importe1, "Importe1");
            Importe1.Name = "Importe1";
            // 
            // textBox5
            // 
            resources.ApplyResources(textBox5, "textBox5");
            textBox5.Name = "textBox5";
            // 
            // textBox4
            // 
            resources.ApplyResources(textBox4, "textBox4");
            textBox4.Name = "textBox4";
            textBox4.LostFocus += conversor1;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { resources.GetString("comboBox6.Items"), resources.GetString("comboBox6.Items1"), resources.GetString("comboBox6.Items2"), resources.GetString("comboBox6.Items3"), resources.GetString("comboBox6.Items4"), resources.GetString("comboBox6.Items5") });
            resources.ApplyResources(comboBox6, "comboBox6");
            comboBox6.Name = "comboBox6";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { resources.GetString("comboBox5.Items"), resources.GetString("comboBox5.Items1"), resources.GetString("comboBox5.Items2"), resources.GetString("comboBox5.Items3"), resources.GetString("comboBox5.Items4"), resources.GetString("comboBox5.Items5") });
            resources.ApplyResources(comboBox5, "comboBox5");
            comboBox5.Name = "comboBox5";
            // 
            // data_transaccio
            // 
            resources.ApplyResources(data_transaccio, "data_transaccio");
            data_transaccio.Name = "data_transaccio";
            // 
            // Eliminar
            // 
            resources.ApplyResources(Eliminar, "Eliminar");
            Eliminar.Name = "Eliminar";
            toolTip1.SetToolTip(Eliminar, resources.GetString("Eliminar.ToolTip"));
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += buttonEsborrar_Click;
            // 
            // Afegir
            // 
            resources.ApplyResources(Afegir, "Afegir");
            Afegir.Name = "Afegir";
            toolTip1.SetToolTip(Afegir, resources.GetString("Afegir.ToolTip"));
            Afegir.UseVisualStyleBackColor = true;
            Afegir.Click += buttonAfegir_Click;
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            // 
            // Email
            // 
            resources.ApplyResources(Email, "Email");
            Email.Name = "Email";
            Email.Click += Email_Click;
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // Client
            // 
            resources.ApplyResources(Client, "Client");
            Client.Name = "Client";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            // 
            // helpProvider1
            // 
            resources.ApplyResources(helpProvider1, "helpProvider1");
            // 
            // button13
            // 
            resources.ApplyResources(button13, "button13");
            button13.Name = "button13";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Tabcontrol);
            helpProvider1.SetHelpNavigator(this, (HelpNavigator)resources.GetObject("$this.HelpNavigator"));
            Name = "Form1";
            helpProvider1.SetShowHelp(this, (bool)resources.GetObject("$this.ShowHelp"));
            Tabcontrol.ResumeLayout(false);
            Conversor.ResumeLayout(false);
            Conversor.PerformLayout();
            Gestio.ResumeLayout(false);
            Gestio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private TabControl Tabcontrol;
        private TabPage Conversor;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Button Borrar;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private TabPage Gestio;
        private DataGridView dataGridView1;
        private Label Client;
        private Label label3;
        private TextBox textBox3;
        private Label Email;
        private TextBox textBox2;
        private Button Eliminar;
        private Button Afegir;
        private Label data_transaccio;
        private TextBox textBox5;
        private TextBox textBox4;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private CheckBox Descompte2;
        private CheckBox Descompte1;
        private RadioButton Venta;
        private RadioButton Compra;
        private Label Divisa2;
        private Label Divisa1;
        private Label Importe2;
        private Label Importe1;
        private TextBox textBox6;
        private Label labelError;
        private Button Ajuda;
        private Label label4;
        private ComboBox comboBox3;
        private HelpProvider helpProvider1;
        private Button button12;
        private ToolTip toolTip1;
        private Button button13;
    }
}
