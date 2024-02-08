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
    public partial class KonuAnlatimi : Form
    {
        public KonuAnlatimi()
        {
            InitializeComponent();
        }

        #region Variables;
        private const int _closeButtonDeactive = 0x200;
        private string _konuAnlatimiHeader = "Olasılık Nedir?", _konuAnlatimiMetin = "Olasılık, günlük yaşamımızda sıkça karşılaştığımız rastgele olayların incelenmesinde kullanılan bir matematik dalıdır.\nBu kavram, belirli bir sonucun gerçekleşme ihtimalini nicel olarak ifade etmemize olanak sağlar.\nOlasılık, özellikle karar verme süreçlerinde ve istatistiksel analizlerde temel bir rol oynar.\r\n\r\nBir olayın olasılığı genellikle 0 ile 1 arasında bir değerle ifade edilir.\n0, olayın hiç gerçekleşmeyeceğini, 1 ise olayın kesinlikle gerçekleşeceğini ifade eder. Örneğin, bir zarın atılması durumunda, her bir yüzün gelme olasılığı 1/6'dır, çünkü zarın altı yüzü vardır ve her birinin gelme olasılığı eşittir.\r\n\r\nOlasılık, iki temel yaklaşımla incelenir: Klasik Olasılık ve İstatistiksel Olasılık.\nKlasik Olasılık, deneyin sonuçlarının eşit olasılığa sahip olduğu durumlar için kullanılır. Örneğin, bir zarın atılması veya bir kartın çekilmesi gibi durumlar klasik olasılıkla incelenir. İstatistiksel Olasılık ise gerçek yaşam verilerine dayalı olarak olayların olasılığını belirler. Örneğin, hava durumu tahminleri veya pazar araştırmaları gibi durumlar istatistiksel olasılıkla incelenir.\r\n\r\nOlasılık, birçok alanda kullanılan bir araçtır. Finansal piyasalardaki risk yönetimi, tıbbi teşhislerde hastalıkların olasılıklarının değerlendirilmesi, mühendislik projelerinde güvenilirlik analizleri ve oyun teorisinde stratejilerin belirlenmesi gibi alanlarda olasılık kavramı önemli bir rol oynar.\r\n\r\nSonuç olarak, olasılık kavramı günlük yaşamımızın bir parçasıdır ve rastgele olayların incelenmesinde bize yol gösterir. Klasik ve istatistiksel olasılık yaklaşımlarıyla, belirsizliklerle dolu dünyamızı anlamaya ve kararlarımızı daha sağlam temellere dayandırmaya yardımcı olur.";
        #endregion

        #region Methods;
        protected override CreateParams CreateParams
        {
            get
            { 
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | _closeButtonDeactive;
                return cp;
            }
        }
        #endregion

        #region Konu Anlatımı Loading;
        private void KonuAnlatimi_Load(object sender, EventArgs e)
        {
            label2.Text = _konuAnlatimiMetin;
        }
        #endregion

        #region ToolStrips;
        private void geriDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            f1.Show();
            this.Close();
        }

        private void programTasarimcisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeTasarim pt = new ProjeTasarim();
            pt.ShowDialog();
        }

        private void uygulamayiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sorularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sorular sorular = new Sorular();
            sorular.Show();
            this.Hide();
        }
        #endregion
    }
}