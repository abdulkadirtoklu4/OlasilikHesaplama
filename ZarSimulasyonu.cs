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
            this.Hide();
        }

        private void AtilacakZarSayisi_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value > 15)
            {
                MessageBox.Show("Maksimum 15 zar atabilirsiniz.","Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDown1.Value -= 1;
                return;
            }
            _zarSayisi = (int)numericUpDown1.Value;
        }

        private void ZarAtButton_Click(object sender, EventArgs e)
        {
            int toplamZarDegeri = 0;
            int girisSayisi = _zarSayisi;
            if (_zarSayisi == 0)
            {
                MessageBox.Show("Geçersiz zar sayısı, 0 adet zar atılamaz.", "Zar Sayısı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Hatalı durumda kodun devamını çalıştırmamak için
            }

            listBox1.Items.Clear();
            Random rnd = new Random();

            // Zar atma işlemi ve her bir zarın değerini listeye ekleme
            for (int i = 1; i <= _zarSayisi; i++)
            {
                int randomZarDegeri = rnd.Next(1, 7); // 1 ile 6 arasında rastgele zar değeri
                listBox1.Items.Add(i + ". Zar: " + randomZarDegeri);
                toplamZarDegeri += randomZarDegeri;
            }

            // Toplam durum sayısını hesaplama
            long toplamDurumSayisi = (long)Math.Pow(6, girisSayisi); // 6 üzeri zar sayısı kadar
            Olasilik.Text = "Toplam Zar Değeri: " + toplamZarDegeri + "/" + toplamDurumSayisi;
            Olasilik.Visible = true;

        }

        private void ZarSimulasyonu_Load(object sender, EventArgs e)
        {
            // NULL.
        }

        private void programiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void projeTasarimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeTasarim pt = new ProjeTasarim();
            pt.ShowDialog();
        }

        private void soruCozumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sorular s = new Sorular();
            s.Show();
            this.Hide();
        }
    }
}
