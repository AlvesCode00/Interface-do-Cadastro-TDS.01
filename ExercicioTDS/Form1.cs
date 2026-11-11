using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ExercicioTDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Eventos dos preços
            numericUpDown1.ValueChanged += CalcularMargem;
            numericUpDown3.ValueChanged += CalcularMargem;

            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button1.Click += button1_Click;
            button4.Click += button4_Click;


            checkBox1.Checked = true;

            textBox1.ReadOnly = true;
            textBox4.ReadOnly = true;

            numericUpDown1.DecimalPlaces = 2;
            numericUpDown3.DecimalPlaces = 2;

            numericUpDown1.Maximum = 1000000;
            numericUpDown3.Maximum = 1000000;

            numericUpDown2.Maximum = 1000000;
            numericUpDown4.Maximum = 1000000;


            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            textBox1.Text = "000001";
        }

        private void CalcularMargem(object sender, EventArgs e)
        {
            decimal custo = numericUpDown1.Value;
            decimal venda = numericUpDown3.Value;

            decimal margem = venda - custo;

            textBox4.Text = margem.ToString("N2");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;

            textBox4.Text = "0,00";

            checkBox1.Checked = true;
            dateTimePicker1.Value = DateTime.Today;

            textBox2.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Informe o nome do produto!");
                textBox2.Focus();
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria!");
                comboBox1.Focus();
                return;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um fornecedor!");
                comboBox2.Focus();
                return;
            }

            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("O preço de custo deve ser maior que zero!");
                numericUpDown1.Focus();
                return;
            }

            if (numericUpDown3.Value <= 0)
            {
                MessageBox.Show("O preço de venda deve ser maior que zero!");
                numericUpDown3.Focus();
                return;
            }

            if (numericUpDown3.Value < numericUpDown1.Value)
            {
                MessageBox.Show("O preço de venda não pode ser menor que o custo!");
                numericUpDown3.Focus();
                return;
            }

            if (numericUpDown4.Value > numericUpDown2.Value)
            {
                MessageBox.Show("O estoque mínimo não pode ser maior que o estoque inicial!");
                numericUpDown4.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Informe a descrição do produto!");
                textBox3.Focus();
                return;
            }

            MessageBox.Show(
                "Produto cadastrado com sucesso!\n\n" +
                "Código: " + textBox1.Text +
                "\nProduto: " + textBox2.Text +
                "\nCategoria: " + comboBox1.Text +
                "\nFornecedor: " + comboBox2.Text +
                "\nMargem: R$ " + textBox4.Text,
                "Cadastro de Produtos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);

            textBox1.Text =
                DateTime.Now.ToString("HHmmss");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
              "Deseja limpar os dados deste produto?",
              "Confirmar",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
          );

            if (resposta == DialogResult.Yes)
            {
                button3_Click(sender, e);
            }
        }
    }
}
    
