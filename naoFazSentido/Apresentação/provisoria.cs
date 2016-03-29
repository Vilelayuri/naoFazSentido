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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 tel1 = new Form1();
            tel1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 tel2 = new Form2();
            tel2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 tel3 = new Form3();
            tel3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 tel4 = new Form4();
            tel4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 tel5 = new Form5();
            tel5.Show();
        }
    }
}
