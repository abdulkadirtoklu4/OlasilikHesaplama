using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace OlasilikHesaplama
{
    public partial class Sorular : Form
    {
        public Sorular()
        {
            InitializeComponent();
        }

        // to-do-list;
        // buttonlar daha çok inmeli ve çıkmalı
        // ayrıca RichTextBox'da ayarlanmalı

        // Variables;
        private int randomSayi;
        private bool _showAnswer = false, _showExportError = true;
        Random _random;

        // Responsive Variables;
        private int _standardLabelFont = 12;
        private int _refreshButtonX = 12, _refreshButtonY = 204;
        private int _printQuestionButtonX = 239, _printQuestionButtonY = 204;
        private int _showAnswerButtonX = 120, _showAnswerButtonY = 204;
        private int _textBuyutButtonX = 564, _textBuyutButtonY = 208;
        private int _textKucultButtonX = 635, _textKucultButtonY = 208;
        private int _textSifirlaButtonX = 706, _textSifirlaButtonY = 208;
        private int _richTextBoxX = 803, _richTextBoxY = 12;
        private int _rdAllButtonX = 362, _rdAllButtonY = 204;
        private int _rdOnlyButtonX = 362, _rdOnlyButtonY = 239;
        private int _thisX = 807, _thisY = 307;

        private readonly string[] _sorular = {
            "1- Bir zar atışında, 2 farklı zarın toplamının 7 gelme olasılığı nedir?",
            "2- Bir desteden bir kart çekildiğinde, kırmızı bir kartın çekilme olasılığı nedir?",
            "3- Bir madeni paranın iki kez atılması durumunda, her iki atışta da tura gelme olasılığı nedir?",
            "4- Bir torbadan dört top çekildiğinde, en az birinin kırmızı olma olasılığı nedir?",
            "5- Bir zarın atılması durumunda, çift sayı gelme olasılığı nedir?",
            "6- Bir torbadan 2 beyaz, 3 mavi ve 4 sarı top olduğunu varsayalım. Bir topun mavi olma olasılığı nedir?",
            "7- Bir zarın atılması durumunda, 4 veya 5 gelme olasılığı nedir?",
            "8- Bir desteden üç kart çekildiğinde, en az birinin kupa olma olasılığı nedir?",
            "9- Bir torbadan çekilen bir topun kırmızı olma olasılığı, 2 kırmızı, 3 mavi ve 5 sarı top içeren torbada nedir?",
            "10- İki madeni paranın atılması durumunda, en az birinin tura gelme olasılığı nedir?",
            "11- Bir zarın atılması durumunda, 3 gelme veya bir çift sayı gelme olasılığı nedir?",
            "12- Bir torbadan çekilen iki topun da kırmızı olma olasılığı, 4 kırmızı, 2 mavi ve 3 yeşil top içeren torbada nedir?",
            "13- Bir desteden bir kart çekildiğinde, bir as çekme olasılığı nedir?",
            "14- Bir torbadan çekilen üç topun da aynı renk olma olasılığı nedir?",
            "15- Bir zarın atılması durumunda, tek sayı gelme olasılığı nedir?",
            "16- Bir desteden iki kart çekildiğinde, her iki kartın da kupa olma olasılığı nedir?",
            "17- Bir torbadan 2 siyah, 4 beyaz ve 3 gri top olduğunu varsayalım. Bir topun beyaz olma olasılığı nedir?",
            "18- Bir zarın atılması durumunda, 6 gelme veya çift sayı gelme olasılığı nedir?",
            "19- Bir desteden üç kart çekildiğinde, hiç vale çekmeme olasılığı nedir?",
            "20- Bir torbadan çekilen bir topun mavi olma olasılığı, 3 kırmızı, 4 mavi ve 2 sarı top içeren torbada nedir?",
            "21- İki zarın atılması durumunda, toplamın 9 gelme olasılığı nedir?",
            "22- Bir desteden bir kart çekildiğinde, bir kupa veya bir vale çekme olasılığı nedir?",
            "23- Bir torbadan çekilen iki topun da farklı renklerde olma olasılığı nedir?",
            "24- Bir zarın atılması durumunda, 2 gelme ve bir çift sayı gelme olasılığı nedir?",
            "25- Bir desteden iki kart çekildiğinde, en az birinin kupa ve diğerinin karo olma olasılığı nedir?"
        };

        private string[] _cevaplar = {"6/36 -> 1/6", "26/52 -> 1/2", "1/4", ""/*Soruların doğru cevapları için*/};

        private int[] _yapilanSorular = {/*Yapılan soruların indexleri burada saklanacak, sorunun daha önce kullanıcıya gösterilip gösterilmediği buradan teyit edilecek.*/ };

        private void Sorular_Load(object sender, EventArgs e)
        {
            rdAll.Visible = false;
            rdOnly.Visible = false;
            richTextBox1.ReadOnly = true;
            SoruGetir();

            // Background Remove;
            rdAll.BackColor = Color.Transparent;
            rdOnly.BackColor = Color.Transparent;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SoruGetir();
        }

        private void ShowAnswersButton_Click(object sender, EventArgs e)
        {
            if (!_showAnswer)
            {
                ShowAnswersButton.Text = "Cevapları Kapat";
                this.Size = new Size(1162, 307);
                //richTextBox1.Size = new Size(343, 244);
                _showAnswer = true;
            }

            else
            {
                ShowAnswersButton.Text = "Cevapları Göster";
                this.Size = new Size(807, 307);
                _showAnswer = false;
            }
        }

        private void YapilanSorulariEkle()
        {
            
        }

        private void SoruGetir()
        {
            _random = new Random();
            randomSayi = _random.Next(1, _sorular.Length + 1);

            if (randomSayi >= 1 && randomSayi <= _sorular.Length)
            {
                labelSoru.Text = _sorular[randomSayi - 1];
            }
        }

        private void TextBuyut_Click(object sender, EventArgs e)
        {
            _standardLabelFont += 1;
            labelSoru.Font = new Font("Microsoft Sans Serif", _standardLabelFont + 1);

            if (_standardLabelFont >= 5)
            {
                TextKucult.Enabled = true;
                //  y +=10 px;
                //_refreshButtonX += 10;
                _refreshButtonY += 10;
                //_showAnswerButtonX += 10;
                _showAnswerButtonY += 10;
                //_printQuestionButtonX += 10;
                _printQuestionButtonY += 10;
                //_textBuyutButtonX += 10;
                _textBuyutButtonY += 10;
                //_textKucultButtonX += 10;
                _textKucultButtonY += 10;
                //_textSifirlaButtonX += 10;
                _textSifirlaButtonY += 10;
                //_rdAllButtonX += 10;
                _rdAllButtonY += 10;
                //_rdOnlyButtonX += 10;
                _rdOnlyButtonY += 10;
                _thisX += 15;
                _thisY += 15;
                _richTextBoxX += 20;
                //_richTextBoxY += 10;

                this.Size = new System.Drawing.Size(_thisX, _thisY);
                RefreshButton.Location = new Point(_refreshButtonX, _refreshButtonY);
                ShowAnswersButton.Location = new Point(_showAnswerButtonX, _showAnswerButtonY);
                PrintQuestionsButton.Location = new Point(_printQuestionButtonX, _printQuestionButtonY);
                TextBuyut.Location = new Point(_textBuyutButtonX, _textBuyutButtonY);
                TextKucult.Location = new Point(_textKucultButtonX, _textKucultButtonY);
                TextSifirla.Location = new Point(_textSifirlaButtonX, _textSifirlaButtonY);
                richTextBox1.Location = new Point(803, 22);
                rdAll.Location = new Point(_rdAllButtonX, _rdAllButtonY);
                rdOnly.Location = new Point(_rdOnlyButtonX, _rdOnlyButtonY);
                richTextBox1.Location = new Point(_richTextBoxX, _richTextBoxY);
            }
        }

        private void TextKucult_Click(object sender, EventArgs e)
        {
            if (_standardLabelFont == 5)
            {
                MessageBox.Show("Daha fazla küçültülme yapılamaz.", "Maksimum Küçültmeye Ulaştınız.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextKucult.Enabled = false;
            }

            else
            {
                _standardLabelFont -= 1;
                labelSoru.Font = new Font("Microsoft Sans Serif", _standardLabelFont);

                //_refreshButtonX -= 10;
                _refreshButtonY -= 10;
                //_showAnswerButtonX -= 10;
                _showAnswerButtonY -= 10;
                //_printQuestionButtonX -= 10;
                _printQuestionButtonY -= 10;
                //_textBuyutButtonX -= 10;
                _textBuyutButtonY -= 10;
                //_textKucultButtonX -= 10;
                _textKucultButtonY -= 10;
                //_textSifirlaButtonX -= 10;
                _textSifirlaButtonY -= 10;
                //_rdAllButtonX -= 10;
                _rdAllButtonY -= 10;
                //_rdOnlyButtonX -= 10;
                _rdOnlyButtonY -= 10;
                _thisX -= 15;
                _thisY -= 15;
                _richTextBoxX -= 20;
                //_richTextBoxY -= 10;

                this.Size = new System.Drawing.Size(_thisX, _thisY);
                RefreshButton.Location = new Point(_refreshButtonX, _refreshButtonY);
                ShowAnswersButton.Location = new Point(_showAnswerButtonX, _showAnswerButtonY);
                PrintQuestionsButton.Location = new Point(_printQuestionButtonX, _printQuestionButtonY);
                TextBuyut.Location = new Point(_textBuyutButtonX, _textBuyutButtonY);
                TextKucult.Location = new Point(_textKucultButtonX, _textKucultButtonY);
                TextSifirla.Location = new Point(_textSifirlaButtonX, _textSifirlaButtonY);
                richTextBox1.Location = new Point(803, 22);
                rdAll.Location = new Point(_rdAllButtonX, _rdAllButtonY);
                rdOnly.Location = new Point(_rdOnlyButtonX, _rdOnlyButtonY);
                richTextBox1.Location = new Point(_richTextBoxX, _richTextBoxY);
            }
        }

        private void TextSifirla_Click(object sender, EventArgs e)
        {
            _standardLabelFont = 12;
            labelSoru.Font = new Font("Microsoft Sans Serif", _standardLabelFont);
            TextKucult.Enabled = true;

            // this max-min res. && listbox position;
            _standardLabelFont = 12;
            _refreshButtonX = 12; _refreshButtonY = 204;
            _printQuestionButtonX = 239; _printQuestionButtonY = 204;
            _showAnswerButtonX = 120; _showAnswerButtonY = 204;
            _textBuyutButtonX = 564; _textBuyutButtonY = 208;
            _textKucultButtonX = 635; _textKucultButtonY = 208;
            _textSifirlaButtonX = 706; _textSifirlaButtonY = 208;
            _richTextBoxX = 803; _richTextBoxY = 12;
            _rdAllButtonX = 362; _rdAllButtonY = 204;
            _rdOnlyButtonX = 362; _rdOnlyButtonY = 239;
            _thisX = 807; _thisY = 307;

            this.Size = new System.Drawing.Size(_thisX, _thisY);
            RefreshButton.Location = new Point(_refreshButtonX, _refreshButtonY);
            ShowAnswersButton.Location = new Point(_showAnswerButtonX, _showAnswerButtonY);
            PrintQuestionsButton.Location = new Point(_printQuestionButtonX, _printQuestionButtonY);
            TextBuyut.Location = new Point(_textBuyutButtonX, _textBuyutButtonY);
            TextKucult.Location = new Point(_textKucultButtonX, _textKucultButtonY);
            TextSifirla.Location = new Point(_textSifirlaButtonX, _textSifirlaButtonY);
            richTextBox1.Location = new Point(803, 22);
            rdAll.Location = new Point(_rdAllButtonX, _rdAllButtonY);
            rdOnly.Location = new Point(_rdOnlyButtonX, _rdOnlyButtonY);
            richTextBox1.Location = new Point(_richTextBoxX, _richTextBoxY);
        }

        private void PrintQuestionsButton_Click(object sender, EventArgs e)
        {
            if (_showExportError)
            {
                _showExportError = false;
            }

            else
            {
                if (rdAll.Checked == false && rdOnly.Checked == false)
                {
                    MessageBox.Show("Hiçbir Dışa Aktarma Seçeneği Seçmediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else 
                {
                    _showExportError = true;
                }
            }

            rdAll.Visible = true;
            rdOnly.Visible = true;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Belgeleri|*.docx";

            if (rdAll.Checked == true)
            {
                sfd.Title = "Tüm Soruları Word Dosyası Olarak Kaydet";
                sfd.ShowDialog();

                if (!string.IsNullOrWhiteSpace(sfd.FileName))
                {
                    try
                    {
                        Word.Application word = new Word.Application();
                        word.Visible = true;

                        string exportData = string.Join("\n\n", _sorular);

                        Word.Document doc = word.Documents.Add();
                        doc.Content.Text = exportData;

                        // Word belgesini kaydedin.
                        object fileName = sfd.FileName;
                        doc.SaveAs2(ref fileName);

                        // Word Object is Equated to 0;
                        word = null;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else if (rdOnly.Checked == true)
            {
                sfd.Title = "Geçerli Soruyu Word Dosyası Olarak Kaydet";
                sfd.ShowDialog();

                if (!string.IsNullOrWhiteSpace(sfd.FileName))
                {
                    try
                    {
                        Word.Application word = new Word.Application();
                        word.Visible = true;
                        
                        string exportData = labelSoru.Text;

                        Word.Document doc = word.Documents.Add();
                        doc.Content.Text = exportData;

                        object fileName = sfd.FileName;
                        doc.SaveAs2(ref fileName);
                        
                        word = null;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}