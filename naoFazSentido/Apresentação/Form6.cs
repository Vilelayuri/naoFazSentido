using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using naoFazSentido.Negocio;

namespace naoFazSentido.Apresentação
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Negocios negocio = new Negocios();

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Carros")
            {
              dataGridView1.DataSource = negocio.SelecionarVeiculo();
            }
            else if (comboBox1.Text == "Motorista")
            {
                dataGridView1.DataSource = negocio.SelecionaTodosMotorista();
            }
            else if (comboBox1.Text == "Vistoria")
            {
                dataGridView1.DataSource = negocio.SelecionaTodasRevisoes();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
