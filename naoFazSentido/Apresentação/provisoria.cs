using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using naoFazSentido.Apresentação;



namespace naoFazSentido.Apresentação
{
    public partial class provisoria : Form
    {
        public provisoria()
        {
            InitializeComponent();

        }

       

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroDeMotoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
            Vistoria frmAzul = new Vistoria();

            // Atribui um titulo ao formulário
            frmAzul.Text = "Formulário Azul";


            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // Define quem o pai desta janela
            frmAzul.MdiParent = this;

            // exibe o formulário
            frmAzul.Show();
        }

    }
}
