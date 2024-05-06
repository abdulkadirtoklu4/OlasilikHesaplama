using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlasilikHesaplama
{
    public partial class ProjeTasarim : Form
    {
        public ProjeTasarim()
        {
            InitializeComponent();
        }

        private bool IsInternelAvilable()
        {
            try
            {
                TcpClient internetControl = new TcpClient("www.google.com", 80);
                internetControl.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Variables; 
        public string _url;

        private void OpenWebsite(string url)
        {
            try
            {
                if (IsInternelAvilable() == true)
                {
                    Process.Start(_url);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Mesajı: " + ex.Message, "Bir Hata Oldu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GitHubButton_Click(object sender, EventArgs e)
        {
            _url = "https://www.github.com/abdulkadirtoklu4/OlasilikHesaplama";
            OpenWebsite(_url);
        }

        private void ProjeTasarim_Load(object sender, EventArgs e)
        {   
            this.StartPosition = FormStartPosition.CenterScreen;

            // Text'lerin Arka Planını Transparan Yapma.
            StartingText.Parent = pictureBox1;
            StartingText.BackColor = Color.Transparent;
        }

        private void GitHubButton_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
    }
}
