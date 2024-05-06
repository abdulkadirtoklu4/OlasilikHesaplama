using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlasilikHesaplama
{
    public partial class ParaAtmaSimulasyonu : Form
    {
        public ParaAtmaSimulasyonu()
        {
            InitializeComponent();
        }

        // Variables;
        private int _paraSayisi;

        private void ParaAtmaButtonu_Click(object sender, EventArgs e)
        {
            ParaAt();
        }

        private void ParaAtmaSimulasyonu_Load(object sender, EventArgs e)
        {
        }

        private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void konuAnlatımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KonuAnlatimi kO = new KonuAnlatimi();
            kO.Show();
            this.Hide();
        }

        private void sorularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sorular s = new Sorular();
            s.Show();
            this.Hide();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void ParaAt()
        {
            Random rnd = new Random();
            listBox1.BeginUpdate();
            for (int i = 0; i < _paraSayisi; i++)
            {
                int a = rnd.Next(0, 2); // 0 veya 1 üret.
                string olasilik = (a == 1) ? "Tura" : "Yazı";
                listBox1.Items.Add(olasilik);
            }
            listBox1.EndUpdate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _paraSayisi = (int)numericUpDown1.Value;
        }
    }
}
