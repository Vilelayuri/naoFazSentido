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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        Negocios Negocio = new Negocios();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Negocio.SelecionaAbastecimento();

        }

    }
}
