namespace ExercicioTDS
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
            gb1 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            gb2 = new GroupBox();
            textBox4 = new TextBox();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            gb3 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            gb1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            gb3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(comboBox2);
            gb1.Controls.Add(comboBox1);
            gb1.Controls.Add(textBox3);
            gb1.Controls.Add(textBox2);
            gb1.Controls.Add(textBox1);
            gb1.Controls.Add(label5);
            gb1.Controls.Add(label4);
            gb1.Controls.Add(label3);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(label1);
            gb1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb1.Location = new Point(12, 88);
            gb1.Name = "gb1";
            gb1.Size = new Size(776, 160);
            gb1.TabIndex = 1;
            gb1.TabStop = false;
            gb1.Text = "Dados Principais";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Fornecedor A", "Fornecedor B", "Fornecedor C", "Outros" });
            comboBox2.Location = new Point(17, 104);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 27);
            comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Eletronico", "Informatica", "Moveis", "Vestuario", "Outros" });
            comboBox1.Location = new Point(564, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 27);
            comboBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(217, 91);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(539, 63);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 26);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(17, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 26);
            textBox1.TabIndex = 5;
            textBox1.Text = "000000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(564, 22);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 4;
            label5.Text = "Categoria;";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(217, 71);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 3;
            label4.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(182, 22);
            label3.Name = "label3";
            label3.Size = new Size(122, 17);
            label3.TabIndex = 2;
            label3.Text = "Nome do Produto:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 84);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 1;
            label2.Text = "Fornecedor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 22);
            label1.Name = "label1";
            label1.Size = new Size(54, 17);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 83);
            panel1.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(119, 21);
            label11.Name = "label11";
            label11.Size = new Size(315, 40);
            label11.TabIndex = 10;
            label11.Text = "Cadastro de Produtos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.bloquear;
            pictureBox1.Location = new Point(35, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // gb2
            // 
            gb2.Controls.Add(textBox4);
            gb2.Controls.Add(numericUpDown4);
            gb2.Controls.Add(numericUpDown3);
            gb2.Controls.Add(numericUpDown2);
            gb2.Controls.Add(numericUpDown1);
            gb2.Controls.Add(label10);
            gb2.Controls.Add(label9);
            gb2.Controls.Add(label8);
            gb2.Controls.Add(label7);
            gb2.Controls.Add(label6);
            gb2.Font = new Font("Arial", 12F, FontStyle.Bold);
            gb2.Location = new Point(12, 254);
            gb2.Name = "gb2";
            gb2.Size = new Size(470, 123);
            gb2.TabIndex = 2;
            gb2.TabStop = false;
            gb2.Text = "Precificação e Estoque";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(133, 61);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(109, 26);
            textBox4.TabIndex = 14;
            textBox4.Text = "0,00";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(371, 91);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(93, 26);
            numericUpDown4.TabIndex = 13;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(371, 32);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(93, 26);
            numericUpDown3.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(142, 91);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(93, 26);
            numericUpDown2.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(142, 32);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(93, 26);
            numericUpDown1.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(241, 100);
            label10.Name = "label10";
            label10.Size = new Size(94, 17);
            label10.TabIndex = 9;
            label10.Text = "Stock Minimo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(241, 35);
            label9.Name = "label9";
            label9.Size = new Size(132, 17);
            label9.TabIndex = 8;
            label9.Text = "Preço de Vende (R$);";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 103);
            label8.Name = "label8";
            label8.Size = new Size(81, 17);
            label8.TabIndex = 7;
            label8.Text = "stock Inicial:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 65);
            label7.Name = "label7";
            label7.Size = new Size(89, 17);
            label7.TabIndex = 6;
            label7.Text = "Margem (R$):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 32);
            label6.Name = "label6";
            label6.Size = new Size(130, 17);
            label6.TabIndex = 5;
            label6.Text = "Preço de Custo (R$);";
            label6.Click += label6_Click;
            // 
            // gb3
            // 
            gb3.Controls.Add(dateTimePicker1);
            gb3.Controls.Add(checkBox1);
            gb3.Font = new Font("Arial", 12F, FontStyle.Bold);
            gb3.Location = new Point(504, 254);
            gb3.Name = "gb3";
            gb3.Size = new Size(284, 123);
            gb3.TabIndex = 2;
            gb3.TabStop = false;
            gb3.Text = "Situação / Detalhes";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(27, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(175, 26);
            dateTimePicker1.TabIndex = 15;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(27, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 20);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Produto Ativo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(-2, 396);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 52);
            panel2.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Image = Properties.Resources.deletar;
            button4.Location = new Point(540, 8);
            button4.Name = "button4";
            button4.Size = new Size(103, 37);
            button4.TabIndex = 3;
            button4.Text = "Excluir";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Image = Properties.Resources.Limpar;
            button3.Location = new Point(399, 8);
            button3.Name = "button3";
            button3.Size = new Size(103, 37);
            button3.TabIndex = 2;
            button3.Text = "Limpar";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Image = Properties.Resources.Salvar;
            button2.Location = new Point(253, 8);
            button2.Name = "button2";
            button2.Size = new Size(103, 37);
            button2.TabIndex = 1;
            button2.Text = "Salvar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Image = Properties.Resources.Novo;
            button1.Location = new Point(119, 8);
            button1.Name = "button1";
            button1.Size = new Size(103, 37);
            button1.TabIndex = 0;
            button1.Text = "Novo";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(gb3);
            Controls.Add(gb2);
            Controls.Add(panel1);
            Controls.Add(gb1);
            Name = "Form1";
            Text = "Form1";
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            gb3.ResumeLayout(false);
            gb3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private Panel panel1;
        private GroupBox gb2;
        private GroupBox gb3;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label11;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox4;
    }
}
