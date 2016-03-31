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
using naoFazSentido.ObjetoDeTransferencia;

namespace naoFazSentido.Apresentação
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            comboBox1.Items.Add("Etanol");
            comboBox1.Items.Add("Gasolina");
            comboBox1.Items.Add("Flex");
        }
        DTOCarro car = new DTOCarro();
        Negocios control = new Negocios(); 
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            car.Combustivel = comboBox1.Text;
            car.Cor = Mtbcor.Text;
            car.Marca = mtbMarca.Text;
            car.Modelo = mtbModelo.Text;
            car.Placa = MtbPlaca.Text;
            car.Quilometragem = MtbKM.Text;
            car.Renavam = mtbRenavam.Text;
            control.Insericar(car);
            

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            control.ExcluirCar(MtbPlaca.Text);
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           comboBox1.Text = "";
           Mtbcor.Text = "";
           mtbMarca.Text = "";
           mtbModelo.Text = "";
           MtbPlaca.Text = "";
           MtbKM.Text = "";
          mtbRenavam.Text = "";
        }

        private void procurarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
