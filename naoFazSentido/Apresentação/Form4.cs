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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        DTOMotorista motorista = new DTOMotorista();
        Negocios negocio = new Negocios();

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            negocio.Excluir(txtCod.Text);
            limpar();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            motorista.CEP = txtcep.Text;
            motorista.CIDADE = txtcidade.Text;
            motorista.CPF = txtcpf.Text;
            motorista.DATA_NASCIMENTO = txtdatanascimento.Text;
            motorista.ENDERECO = txtendereco.Text;
            motorista.NOME = txtnome.Text;
            motorista.RG = txtrg.Text;
            motorista.TELEFONE = txttelefone.Text;
            negocio.inserirMotorista(motorista);
            limpar();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            motorista.CEP = txtcep.Text;
            motorista.CIDADE = txtcidade.Text;
            motorista.CPF = txtcpf.Text;
            motorista.DATA_NASCIMENTO = txtdatanascimento.Text;
            motorista.ENDERECO = txtendereco.Text;
            motorista.NOME = txtnome.Text;
            motorista.RG = txtrg.Text;
            motorista.TELEFONE = txttelefone.Text;

            negocio.Atualizar(motorista, txtCod.Text);
            limpar();
        }

        private void limpar()
        {
            txtcep.Text="";
            txtcidade.Text = "";
            txtcpf.Text = "";
            txtdatanascimento.Text = "";
            txtendereco.Text = "";
            txtnome.Text = "";
            txtrg.Text = "";
             txttelefone.Text = "";
            txtCod.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
