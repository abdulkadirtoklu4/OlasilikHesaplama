namespace OlasilikHesaplama
{
    partial class KonuAnlatimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KonuAnlatimi));
            this.Secenekler = new System.Windows.Forms.MenuStrip();
            this.geriDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programTasarimcisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamayiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Secenekler.SuspendLayout();
            this.SuspendLayout();
            // 
            // Secenekler
            // 
            this.Secenekler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriDonToolStripMenuItem,
            this.sorularToolStripMenuItem,
            this.programTasarimcisiToolStripMenuItem,
            this.uygulamayiKapatToolStripMenuItem});
            this.Secenekler.Location = new System.Drawing.Point(0, 0);
            this.Secenekler.Name = "Secenekler";
            this.Secenekler.Size = new System.Drawing.Size(557, 24);
            this.Secenekler.TabIndex = 0;
            this.Secenekler.Text = "menuStrip1";
            // 
            // geriDonToolStripMenuItem
            // 
            this.geriDonToolStripMenuItem.Name = "geriDonToolStripMenuItem";
            this.geriDonToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.geriDonToolStripMenuItem.Text = "Geri Dön";
            this.geriDonToolStripMenuItem.Click += new System.EventHandler(this.geriDonToolStripMenuItem_Click);
            // 
            // sorularToolStripMenuItem
            // 
            this.sorularToolStripMenuItem.Name = "sorularToolStripMenuItem";
            this.sorularToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sorularToolStripMenuItem.Text = "Sorular";
            this.sorularToolStripMenuItem.Click += new System.EventHandler(this.sorularToolStripMenuItem_Click);
            // 
            // programTasarimcisiToolStripMenuItem
            // 
            this.programTasarimcisiToolStripMenuItem.Name = "programTasarimcisiToolStripMenuItem";
            this.programTasarimcisiToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.programTasarimcisiToolStripMenuItem.Text = "Program Tasarımcısı";
            this.programTasarimcisiToolStripMenuItem.Click += new System.EventHandler(this.programTasarimcisiToolStripMenuItem_Click);
            // 
            // uygulamayiKapatToolStripMenuItem
            // 
            this.uygulamayiKapatToolStripMenuItem.Name = "uygulamayiKapatToolStripMenuItem";
            this.uygulamayiKapatToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.uygulamayiKapatToolStripMenuItem.Text = "Uygulamayı Kapat";
            this.uygulamayiKapatToolStripMenuItem.Click += new System.EventHandler(this.uygulamayiKapatToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // KonuAnlatimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Secenekler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Secenekler;
            this.Name = "KonuAnlatimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konu Anlatımı";
            this.Load += new System.EventHandler(this.KonuAnlatimi_Load);
            this.Secenekler.ResumeLayout(false);
            this.Secenekler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Secenekler;
        private System.Windows.Forms.ToolStripMenuItem geriDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programTasarimcisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamayiKapatToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}