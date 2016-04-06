using System.Windows.Forms;
using naoFazSentido.ObjetoDeTransferencia;
using naoFazSentido.Negocio;
namespace naoFazSentido
{
    public partial class Vistoria : Form
    {
        public Vistoria()
        {
            InitializeComponent();
            cbTipoRevisao.Items.Add("Preventiva");
            cbTipoRevisao.Items.Add("Corretiva");

        }
        DTORevisoa revisao = new DTORevisoa();
        Negocios negocios = new Negocios();
        private void button2_Click(object sender, System.EventArgs e)
        {
            revisao.dataentrada = txtdataentrada.Text;
            revisao.datasaida = txtdatasaida.Text;
            revisao.horaentrada = txthoraentrada.Text;
            revisao.horasaida = txthorasaida.Text;
            revisao.nomeitem = txtnomeitem.Text;
            revisao.oficina = txtNomeOficina.Text;
            revisao.preco = txtvaloritem.Text;
            revisao.tipo = cbTipoRevisao.Text;
            revisao.quilometragem = txtquilometragem.Text;
            revisao.quantidade = textBox1.Text;
            negocios.inserirrevisao(revisao);
<<<<<<< HEAD
          //  limpa();
=======
            limpa();
>>>>>>> origin/master
           
        }

        private void btcancelar_Click(object sender, System.EventArgs e)
        {
            limpa();
        }

        private void limpa()
        {
            txtdataentrada.Text = "";
            txtdatasaida.Text = "";
            txthoraentrada.Text = "";
            txthorasaida.Text = "";
            txtnomeitem.Text = "";
            txtNomeOficina.Text = "";
            txtvaloritem.Text = "";
        }
 
        private void Form1_Load(object sender, System.EventArgs e)
        {
          
        }
    }
}
