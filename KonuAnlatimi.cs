using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        private const int _slipRate = 55, _closeButtonDeactive = 0x200;
        private int _standardLabelFont = 12;
        private int _label1X = 390, _label1Y = 37;
        private int _thisX = 910, _thisY = 657;
        private int _textBuyutButtonX = 643, _textBuyutButtonY = 558;
        private int _textKucultButtonX = 714, _textKucultButtonY = 558;
        private int _textSifirlaButtonX = 785, _textSifirlaButtonY = 558;
        private string _konuAnlatimiHeader = "Olasılık Nedir?", _konuAnlatimiMetin = "Olasılık, günlük yaşamımızda sıkça karşılaştığımız rastgele olayların incelenmesinde kullanılan bir matematik dalıdır.\nBu kavram, belirli bir sonucun gerçekleşme ihtimalini nicel olarak ifade etmemize olanak sağlar.\nOlasılık, özellikle karar verme süreçlerinde ve istatistiksel analizlerde temel bir rol oynar.\r\n\r\nBir olayın olasılığı genellikle 0 ile 1 arasında bir değerle ifade edilir.\n0, olayın hiç gerçekleşmeyeceğini, 1 ise olayın kesinlikle gerçekleşeceğini ifade eder.\nÖrneğin, bir zarın atılması durumunda, her bir yüzün gelme olasılığı 1/6'dır, çünkü zarın altı yüzü vardır ve her birinin\n gelme olasılığı eşittir.\r\n\r\nOlasılık, iki temel yaklaşımla incelenir: Klasik Olasılık ve İstatistiksel Olasılık.\nKlasik Olasılık, deneyin sonuçlarının eşit olasılığa sahip olduğu durumlar için kullanılır. Örneğin, bir zarın atılması\n veya bir kartın çekilmesi gibi durumlar klasik olasılıkla incelenir. İstatistiksel Olasılık ise gerçek yaşam verilerine\n dayalı olarak olayların olasılığını belirler. Örneğin, hava durumu tahminleri veya pazar araştırmaları gibi durumlar\n istatistiksel olasılıkla incelenir.\r\n\r\nOlasılık, birçok alanda kullanılan bir araçtır. Finansal piyasalardaki risk yönetimi, tıbbi teşhislerde hastalıkların\n olasılıklarının değerlendirilmesi, mühendislik projelerinde güvenilirlik analizleri ve oyun teorisinde stratejilerin\n belirlenmesi gibi alanlarda olasılık kavramı önemli bir rol oynar.\r\n\r\nSonuç olarak, olasılık kavramı günlük yaşamımızın bir parçasıdır ve rastgele olayların incelenmesinde bize yol gösterir.\n Klasik ve istatistiksel olasılık yaklaşımlarıyla, belirsizliklerle dolu dünyamızı anlamaya ve kararlarımızı daha sağlam\n temellere dayandırmaya yardımcı olur.";
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

        #region Konu Anlatımı LoadHandle;
        private void KonuAnlatimi_Load(object sender, EventArgs e)
        {
            // width: 878
            // heigh: 657
            label1.Text = _konuAnlatimiHeader;
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
        private void TextBuyut_Click(object sender, EventArgs e)
        {
            _standardLabelFont += 1;
            label1.Font = new Font("Microsoft Sans Serif", _standardLabelFont);
            label2.Font = new Font("Microsoft Sans Serif", _standardLabelFont);

            if (_standardLabelFont >= 5)
            {
                TextKucult.Enabled = true;

                //  y +=10 px;
                //_label1X += _slipRate;
                _label1X = this.Width / 2;
                _label1Y += _slipRate;
                _textBuyutButtonX += _slipRate +10;
                _textBuyutButtonY += _slipRate;
                _textKucultButtonX += _slipRate +10;
                _textKucultButtonY += _slipRate;
                _textSifirlaButtonX += _slipRate + 10;
                _textSifirlaButtonY += _slipRate;
                _thisX += _slipRate + 10;
                _thisY += _slipRate;
                this.Size = new System.Drawing.Size(_thisX, _thisY);
                TextBuyut.Location = new Point(_textBuyutButtonX, _textBuyutButtonY);
                TextKucult.Location = new Point(_textKucultButtonX, _textKucultButtonY);
                TextSifirla.Location = new Point(_textSifirlaButtonX, _textSifirlaButtonY);
            }
        }

        private void TextKucult_Click(object sender, EventArgs e)
        {
            if (_standardLabelFont == 12)
            {
                TextKucult.Enabled = false;
                MessageBox.Show("Daha fazla küçültülme yapılamaz.", "Maksimum Küçültmeye Ulaştınız.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                _standardLabelFont -= 1;
                label1.Font = new Font("Microsoft Sans Serif", _standardLabelFont);
                label2.Font = new Font("Microsoft Sans Serif", _standardLabelFont);
                _label1X -= this.Width / 2;
                _label1Y -= _slipRate;
                _textBuyutButtonX -= _slipRate -10;
                _textBuyutButtonY -= _slipRate;
                _textKucultButtonX -= _slipRate -10;
                _textKucultButtonY -= _slipRate;
                _textSifirlaButtonX -= _slipRate - 10;
                _textSifirlaButtonY -= _slipRate;
                _thisX -= _slipRate - 10;
                _thisY -= _slipRate;
                this.Size = new System.Drawing.Size(_thisX, _thisY);
                TextBuyut.Location = new Point(_textBuyutButtonX, _textBuyutButtonY);
                TextKucult.Location = new Point(_textKucultButtonX, _textKucultButtonY);
                TextSifirla.Location = new Point(_textSifirlaButtonX, _textSifirlaButtonY);
            }
        }

        private void TextSifirla_Click(object sender, EventArgs e)
        {
            _standardLabelFont = 12;
            label1.Font = new Font("Microsoft Sans Serif", _standardLabelFont);
            label2.Font = new Font("Microsoft Sans Serif", _standardLabelFont);
            TextKucult.Enabled = true;

            _label1X = 390; _label1Y = 37;
            _thisX = 910; _thisY = 657;
            _textBuyutButtonX = 643; _textBuyutButtonY = 558;
            _textKucultButtonX = 714; _textKucultButtonY = 558;
            _textSifirlaButtonX = 785; _textSifirlaButtonY = 558;
            this.Size = new System.Drawing.Size(_thisX, _thisY);
            TextBuyut.Location = new Point(_textBuyutButtonX, _textBuyutButtonY);
            TextKucult.Location = new Point(_textKucultButtonX, _textKucultButtonY);
            TextSifirla.Location = new Point(_textSifirlaButtonX, _textSifirlaButtonY);
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