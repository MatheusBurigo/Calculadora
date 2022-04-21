using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        float valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            valor2 = int.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if(operacao == "SUBTRACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if(operacao == "MULTIPLICACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUBTRACAO";
            LblOperacao.Text = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULTIPLICACAO";
            LblOperacao.Text = "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIVISAO";
            LblOperacao.Text = "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            LblOperacao.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Criando o método que irá realizar a soma
            valor1 = int.Parse(txtResultado.Text, CultureInfo.InvariantCulture) ;
            //Limpando o Txt do valor para apresentar a soma
            txtResultado.Text = "";
            //estou atribuindo o valor de Soma para a String operacao
            operacao = "SOMA";
            //Estou setando meu Label para apresentar o valor de "+"
            LblOperacao.Text = "+";
        }
    }
}