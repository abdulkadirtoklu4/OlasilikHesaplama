namespace OlasilikHesaplama
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ProjeTasarimButton = new System.Windows.Forms.Button();
            this.KonuAnlatimiButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HataliSoruBildir = new System.Windows.Forms.Button();
            this.ZarAtmaSimulasyonuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjeTasarimButton
            // 
            this.ProjeTasarimButton.Location = new System.Drawing.Point(315, 60);
            this.ProjeTasarimButton.Name = "ProjeTasarimButton";
            this.ProjeTasarimButton.Size = new System.Drawing.Size(105, 69);
            this.ProjeTasarimButton.TabIndex = 0;
            this.ProjeTasarimButton.Text = "Proje Tasarımcısı";
            this.ProjeTasarimButton.UseVisualStyleBackColor = true;
            this.ProjeTasarimButton.Click += new System.EventHandler(this.ProjeTasarimButton_Click);
            // 
            // KonuAnlatimiButton
            // 
            this.KonuAnlatimiButton.Location = new System.Drawing.Point(12, 60);
            this.KonuAnlatimiButton.Name = "KonuAnlatimiButton";
            this.KonuAnlatimiButton.Size = new System.Drawing.Size(105, 69);
            this.KonuAnlatimiButton.TabIndex = 1;
            this.KonuAnlatimiButton.Text = "Konu Anlatımı";
            this.KonuAnlatimiButton.UseVisualStyleBackColor = true;
            this.KonuAnlatimiButton.Click += new System.EventHandler(this.KonuAnlatimiButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // HataliSoruBildir
            // 
            this.HataliSoruBildir.Location = new System.Drawing.Point(12, 158);
            this.HataliSoruBildir.Name = "HataliSoruBildir";
            this.HataliSoruBildir.Size = new System.Drawing.Size(105, 69);
            this.HataliSoruBildir.TabIndex = 3;
            this.HataliSoruBildir.Text = "Hatalı Soru Bildir";
            this.HataliSoruBildir.UseVisualStyleBackColor = true;
            this.HataliSoruBildir.Click += new System.EventHandler(this.HataliSoruBildir_Click);
            // 
            // ZarAtmaSimulasyonuButton
            // 
            this.ZarAtmaSimulasyonuButton.Location = new System.Drawing.Point(315, 158);
            this.ZarAtmaSimulasyonuButton.Name = "ZarAtmaSimulasyonuButton";
            this.ZarAtmaSimulasyonuButton.Size = new System.Drawing.Size(105, 69);
            this.ZarAtmaSimulasyonuButton.TabIndex = 4;
            this.ZarAtmaSimulasyonuButton.Text = "Zar Atma Simulasyonu";
            this.ZarAtmaSimulasyonuButton.UseVisualStyleBackColor = true;
            this.ZarAtmaSimulasyonuButton.Click += new System.EventHandler(this.ZarAtmaSimulasyonuButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 271);
            this.Controls.Add(this.ZarAtmaSimulasyonuButton);
            this.Controls.Add(this.HataliSoruBildir);
            this.Controls.Add(this.KonuAnlatimiButton);
            this.Controls.Add(this.ProjeTasarimButton);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olasılık Hesaplama";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProjeTasarimButton;
        private System.Windows.Forms.Button KonuAnlatimiButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HataliSoruBildir;
        private System.Windows.Forms.Button ZarAtmaSimulasyonuButton;
    }
}

