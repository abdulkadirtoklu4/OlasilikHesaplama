using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace OlasilikHesaplama
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Variables;
        //const string _subKey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";

        //private void DetectDotnetVersion()
        //{
        //    using (var ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(_subKey))
        //    {
        //        if (ndpKey != null)
        //        {
        //            MessageBox.Show($".Net Sürümü Tespit Edildi: {CheckFor45PlusVersions((int)ndpKey.GetValue("Release"))}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }

        //        else
        //        {
        //            MessageBox.Show("DotNet yüklü değil veya eski bir sürüm yüklü.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //            DialogResult dialogResult = MessageBox.Show("5.0.17 Sürümünü Kurmak İstiyor Musunuz?", "DotNet Kurulumu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //            if (dialogResult == DialogResult.Yes)
        //            {
        //                string currentDir = AppDomain.CurrentDomain.BaseDirectory;
        //                string exePath = Path.Combine(currentDir, "DotNetService", "dotnet-5.0.17-win-x64.exe");
        //                Process.Start(exePath);
        //            }
        //        }
        //    }
        //}

        //string CheckFor45PlusVersions(int releaseKey)
        //{
        //    if (releaseKey >= 533320) return "4.8.1 veya daha üst bir sürüm mevcut.";
        //    else if (releaseKey >= 528040) return "4.8 sürümü mevcut.";
        //    else if (releaseKey >= 461808) return "4.7.2 sürümü mevcut.";
        //    else if (releaseKey >= 461308) return "4.7.1 sürümü mevcut.";
        //    else if (releaseKey >= 460798) return "4.7 sürümü mevcut.";
        //    else if (releaseKey >= 394802) return "4.6.2 sürümü mevcut.";
        //    else if (releaseKey >= 394254) return "4.6.1 sürümü mevcut.";
        //    else if (releaseKey >= 393295) return "4.6 sürümü mevcut.";
        //    else if (releaseKey >= 379893) return "4.5.2 sürümü mevcut.";
        //    else if (releaseKey >= 478675) return "4.5.1 sürümü mevcut.";

        //    return "4.5 veya daha önceki sürümler tespit edilemedi";
        //}

        private void Main_Load(object sender, EventArgs e)
        {
            //DetectDotnetVersion();
            this.MinimumSize = new System.Drawing.Size(448, 310);
            this.MaximumSize = new System.Drawing.Size(716, 481);
        }

        private void ProjeTasarimButton_Click(object sender, EventArgs e)
        {
            ProjeTasarim pt = new ProjeTasarim();
            pt.ShowDialog();
        }

        private void KonuAnlatimiButton_Click(object sender, EventArgs e)
        {
            // konu anlatımı yeni formda olacak yukarıda yatay seçeneklerde geri tuşu olucak o da buraya geri getirecek.
            KonuAnlatimi konuAnlatimi = new KonuAnlatimi();
            konuAnlatimi.Show();
            this.Hide();
        }

        private void ZarAtmaSimulasyonuButton_Click(object sender, EventArgs e)
        {
            ZarSimulasyonu zarSimulasyonu = new ZarSimulasyonu();
            zarSimulasyonu.Show();
            this.Hide();
        }

        private void ParaAtmaSimulasyonuButton_Click(object sender, EventArgs e)
        {
            ParaAtmaSimulasyonu paraAtmaSimulasyonu = new ParaAtmaSimulasyonu();
            paraAtmaSimulasyonu.Show();
            this.Hide();
        }
    }
}
