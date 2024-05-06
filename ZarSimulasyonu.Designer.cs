namespace OlasilikHesaplama
{
    partial class ZarSimulasyonu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZarSimulasyonu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.konuAnlatimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruCozumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeTasarimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ZarAtButton = new System.Windows.Forms.Button();
            this.Olasilik = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konuAnlatimiToolStripMenuItem,
            this.soruCozumuToolStripMenuItem,
            this.projeTasarimiToolStripMenuItem,
            this.programiKapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // konuAnlatimiToolStripMenuItem
            // 
            this.konuAnlatimiToolStripMenuItem.Name = "konuAnlatimiToolStripMenuItem";
            this.konuAnlatimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.konuAnlatimiToolStripMenuItem.Text = "Konu Anlatımı";
            this.konuAnlatimiToolStripMenuItem.Click += new System.EventHandler(this.konuAnlatimiToolStripMenuItem_Click);
            // 
            // soruCozumuToolStripMenuItem
            // 
            this.soruCozumuToolStripMenuItem.Name = "soruCozumuToolStripMenuItem";
            this.soruCozumuToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.soruCozumuToolStripMenuItem.Text = "Soru Çözümü";
            this.soruCozumuToolStripMenuItem.Click += new System.EventHandler(this.soruCozumuToolStripMenuItem_Click);
            // 
            // projeTasarimiToolStripMenuItem
            // 
            this.projeTasarimiToolStripMenuItem.Name = "projeTasarimiToolStripMenuItem";
            this.projeTasarimiToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.projeTasarimiToolStripMenuItem.Text = "Proje Tasarımı";
            this.projeTasarimiToolStripMenuItem.Click += new System.EventHandler(this.projeTasarimiToolStripMenuItem_Click);
            // 
            // programiKapatToolStripMenuItem
            // 
            this.programiKapatToolStripMenuItem.Name = "programiKapatToolStripMenuItem";
            this.programiKapatToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.programiKapatToolStripMenuItem.Text = "Programı Kapat";
            this.programiKapatToolStripMenuItem.Click += new System.EventHandler(this.programiKapatToolStripMenuItem_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(318, 66);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 38);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(514, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 290);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kaç Adet Zar Atılacak:";
            // 
            // ZarAtButton
            // 
            this.ZarAtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ZarAtButton.Location = new System.Drawing.Point(12, 218);
            this.ZarAtButton.Name = "ZarAtButton";
            this.ZarAtButton.Size = new System.Drawing.Size(128, 84);
            this.ZarAtButton.TabIndex = 4;
            this.ZarAtButton.Text = "Zar At";
            this.ZarAtButton.UseVisualStyleBackColor = true;
            this.ZarAtButton.Click += new System.EventHandler(this.ZarAtButton_Click);
            // 
            // Olasilik
            // 
            this.Olasilik.AutoSize = true;
            this.Olasilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Olasilik.Location = new System.Drawing.Point(9, 140);
            this.Olasilik.Name = "Olasilik";
            this.Olasilik.Size = new System.Drawing.Size(207, 31);
            this.Olasilik.TabIndex = 5;
            this.Olasilik.Text = "Toplam Olasılık:";
            this.Olasilik.Visible = false;
            // 
            // ZarSimulasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 314);
            this.Controls.Add(this.Olasilik);
            this.Controls.Add(this.ZarAtButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ZarSimulasyonu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zar Simulasyonu";
            this.Load += new System.EventHandler(this.ZarSimulasyonu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem konuAnlatimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruCozumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeTasarimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programiKapatToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ZarAtButton;
        private System.Windows.Forms.Label Olasilik;
    }
}