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

        private void CarregarGrid()
        {
            dataGridView1.DataSource = negocio.SelecionaTodosMotorista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            negocio.Excluir(txtCod.Text);
            limpar();
            CarregarGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCod.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcpf.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdatanascimento.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtrg.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtendereco.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtcidade.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtcep.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txttelefone.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

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
            CarregarGrid();
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
            CarregarGrid();
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
