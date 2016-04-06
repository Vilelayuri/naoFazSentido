using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using naoFazSentido.ObjetoDeTransferencia;
using naoFazSentido.Negocio;


namespace naoFazSentido.Apresentação
{
    public partial class Combústivel : Form
    {
        public Combústivel()
        {
            InitializeComponent();
        }
        DTOAbastecimento dto = new DTOAbastecimento();
        Negocios negocios = new Negocios();


        private void BTNsalvar_Click(object sender, EventArgs e)
        {
            dto.combustivel = TXTcombustivel.Text;
            dto.data = TXTdata.Text;
            dto.litros = TXTlitros.Text;
            dto.motorista = TXTmotorista.Text;
            dto.placa = TXTplaca.Text;
            dto.quilometragem = TXTkm.Text;
            dto.valor = TXTvalor.Text;
            negocios.InseriAbastecimento(dto);
            limpar();
        }

        private void limpar()
        {

            TXTcombustivel.Text = "";
            TXTdata.Text = "";
            TXTkm.Text = "";
            TXTlitros.Text = "";
            TXTmotorista.Text = "";
            TXTplaca.Text = "";
            TXTvalor.Text = "";

        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }


    }
}
