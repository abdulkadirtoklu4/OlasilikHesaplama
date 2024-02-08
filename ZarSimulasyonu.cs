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
    public partial class ZarSimulasyonu : Form
    {
        public ZarSimulasyonu()
        {
            InitializeComponent();
            numericUpDown1.ValueChanged += AtilacakZarSayisi_ValueChanged;
        }

        // Variables;
        int _zarSayisi;

        private void konuAnlatimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KonuAnlatimi konuAnlatimi = new KonuAnlatimi();
            konuAnlatimi.Show();
            this.Close();
        }

        private void AtilacakZarSayisi_ValueChanged(object sender, EventArgs e)
        {
            _zarSayisi = (int)numericUpDown1.Value;
        }

        private void ZarAtButton_Click(object sender, EventArgs e)
        {
            // Toplam Olasılığı Hesaplamak İçin.
            int pay = 0, payda;

            if (_zarSayisi == 0)
            {
                MessageBox.Show("Geçersiz zar sayısı, 0 adet zar atılamaz.", "Zar Sayısı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            listBox1.Items.Clear();

            Random rnd = new Random();

            for (int i = 1; i <= _zarSayisi; i++)
            {
                int random = rnd.Next(1, 6);
                listBox1.Items.Add(i + ". Zar: " + random);
                pay += random;
            }

            payda = _zarSayisi * 6;
            Olasilik.Text = "Toplam Olasılık: " + pay + "/" + payda;
            Olasilik.Visible = true;
        }

        private void ZarSimulasyonu_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(520, 353);
            this.MaximumSize = new System.Drawing.Size(620, 453);
        }
    }
}
