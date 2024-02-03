using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppNetFramwork
{
    public partial class Calculadora : Form
    {
        private Operaçao OperaçaoSelecionas { get; set; }
        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }
        private enum Operaçao
        {
            Adiçao,
            Subtracao,
            Divisao,
            Multiplicacao,
        }
        private void AdicionarExpressaoAoHistorico(string expressao)
        {
            txthistori.Text += expressao + Environment.NewLine;
        }



        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            txthistori.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            txthistori.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            txthistori.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            txthistori.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            txthistori.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            txthistori.Text += "5";
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            txthistori.Text += "6";
        }

        private void btnsete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            txthistori.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            txthistori.Text += "8";
        }

        private void btnnove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            txthistori.Text += "9";  
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResultado.Text))
                {
                    MessageBox.Show("Digite um valor válido antes de clicar em virgula .", "",  MessageBoxButtons.OK);
                    return;
                }

                if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
                txthistori.Text += ",";

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de conversão: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {

            txtResultado.Text = "";
            txthistori.Text += "";

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResultado.Text))
                {
                    MessageBox.Show("Digite um valor válido antes de clicar em igual.", "", MessageBoxButtons.OK);
                    return;
                }

                switch (OperaçaoSelecionas)
                {
                    case Operaçao.Adiçao:
                        Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                        txthistori.Text = "  " + Convert.ToString(Resultado);
                        break;

                    case Operaçao.Subtracao:
                        Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                        txthistori.Text = " " + Convert.ToString(Resultado);
                        break;

                    case Operaçao.Divisao:
                        Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                        txthistori.Text = " " + Convert.ToString(Resultado);
                        break;

                    case Operaçao.Multiplicacao:
                        Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                        txthistori.Text = " = " + Convert.ToString(Resultado);
                        break;
                }
                txtResultado.Text = Convert.ToString(Resultado);
                txthistori.Text = " " + Convert.ToString(Resultado) ;
            }
            catch (FormatException ex)
            {
               
            }
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResultado.Text))
                {
                    MessageBox.Show("Digite um valor válido antes de clicar em +.", "", MessageBoxButtons.OK);
                    return;
                }

                OperaçaoSelecionas = Operaçao.Adiçao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                txthistori.Text += " +";
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de conversão: {ex.Message}", "", MessageBoxButtons.OK);
            }
            
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResultado.Text))
                {
                    MessageBox.Show("Digite um valor válido antes de clicar em -.", "", MessageBoxButtons.OK);
                    return;
                }


                OperaçaoSelecionas = Operaçao.Subtracao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                txthistori.Text += "-";
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de conversão: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }


        private void btnmultiplica_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResultado.Text))
                {
                    MessageBox.Show("Digite um valor válido antes de clicar em  x .", "", MessageBoxButtons.OK);
                    return;
                }


                OperaçaoSelecionas = Operaçao.Multiplicacao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                txthistori.Text += "x";
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de conversão: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResultado.Text))
                {
                    MessageBox.Show("Digite um valor válido antes de clicar em  ÷ .", "", MessageBoxButtons.OK);
                    return;
                }
                OperaçaoSelecionas = Operaçao.Divisao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                txthistori.Text += "÷";
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de conversão: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void menosoumais_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResultado.Text))
                {
                    MessageBox.Show("Digite um valor válido antes de clicar em ± .", "", MessageBoxButtons.OK);
                    return;
                }

                if (txtResultado.Text.Length > 0 && txtResultado.Text[0] == '-')
                {

                    txtResultado.Text = txtResultado.Text.Substring(1);
                }
                else
                {

                    txtResultado.Text = "-" + txtResultado.Text;
                    txthistori.Text += "-" + txtResultado.Text;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de conversão: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void porcentagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtResultado.Text))
                {
                    MessageBox.Show("Digite um valor válido antes de clicar em % .", "", MessageBoxButtons.OK);
                    return;
                }
                if (!string.IsNullOrEmpty(txtResultado.Text))
                {
                    decimal valorAtual = Convert.ToDecimal(txtResultado.Text);
                    decimal resultadoPercentual = valorAtual / 100;


                    txtResultado.Text = resultadoPercentual.ToString();
                    txthistori.Text += "%"; 
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de conversão: {ex.Message}", "", MessageBoxButtons.OK);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            // Verifica se o comprimento atual do texto é maior que 15
            if (txtResultado.Text.Length > 15)
            {
                
                txtResultado.Text = txtResultado.Text.Substring(0, Math.Min(15, txtResultado.Text.Length));
            }
        }



    }

}


