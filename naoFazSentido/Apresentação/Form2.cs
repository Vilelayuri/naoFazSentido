using System;
using System.Windows.Forms;
using naoFazSentido.Negocio;

namespace naoFazSentido
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        combustivelNegocio conbustivel = new combustivelNegocio();

      

        private void button2_Click(object sender, EventArgs e)
        {
         conbustivel.combustivelQCompensa(Convert.ToDouble(txtpgasolina.Text), Convert.ToDouble(txtpEtanol.Text));
            txtresultado.Text = conbustivel.resultado;
            textBox4.Text = Convert.ToString(conbustivel.diferencas())+"%";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para saber qual a melhor opção, o motorista deve fazer uma conta simples.Embora mais barato, o etanol é um combustível que é consumido mais rápido pelo motor flex de um carro em relação à gasolina. Por isso, para identificar qual dos dois é mais vantajoso é preciso dividir o preço do litro do etanol pelo valor do litro da gasolina. Se o resultado da conta for maior que 70%, vale a pena colocar gasolina, se for menor, o melhor é o consumidor abastecer com etanol. ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtpEtanol.Text="";
            txtpgasolina.Text = "";
            txtresultado.Text = "";
            textBox4.Text = "";
        }
    }
}
