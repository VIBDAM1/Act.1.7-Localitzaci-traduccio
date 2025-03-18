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
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            Borrar = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 53);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Conversor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 71);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(51, 124);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 3;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += posarNumero;
            // 
            // button3
            // 
            button3.Location = new Point(131, 124);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 4;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += posarNumero;
            // 
            // button4
            // 
            button4.Location = new Point(209, 124);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 5;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += posarNumero;
            // 
            // button5
            // 
            button5.Location = new Point(51, 209);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 6;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += posarNumero;
            // 
            // button6
            // 
            button6.Location = new Point(131, 209);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 7;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += posarNumero;
            // 
            // button7
            // 
            button7.Location = new Point(209, 209);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 8;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += posarNumero;
            // 
            // button8
            // 
            button8.Location = new Point(51, 299);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 9;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += posarNumero;
            // 
            // button9
            // 
            button9.Location = new Point(131, 299);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 10;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += posarNumero;
            // 
            // button10
            // 
            button10.Location = new Point(209, 299);
            button10.Name = "button10";
            button10.Size = new Size(60, 60);
            button10.TabIndex = 11;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += posarNumero;
            // 
            // button11
            // 
            button11.Location = new Point(51, 378);
            button11.Name = "button11";
            button11.Size = new Size(218, 60);
            button11.TabIndex = 12;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += posarNumero;
            // 
            // Borrar
            // 
            Borrar.Location = new Point(369, 378);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(170, 60);
            Borrar.TabIndex = 14;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += borrar;
            // 
            // button1
            // 
            button1.Location = new Point(369, 310);
            button1.Name = "button1";
            button1.Size = new Size(170, 49);
            button1.TabIndex = 15;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += conversor;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Euro", "Peseta", "Dolar", "Leu", "Yen", "Rupia" });
            comboBox1.Location = new Point(479, 268);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.AddRange(new object[] { "Euro", "Peseta", "Dolar", "Leu", "Yen", "Rupia" });
            comboBox2.Location = new Point(299, 268);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 271);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 18;
            label2.Text = "-->";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 517);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(Borrar);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button Borrar;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
    }
}
