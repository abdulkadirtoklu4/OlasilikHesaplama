namespace OlasilikHesaplama
{
    partial class ParaAtmaSimulasyonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaAtmaSimulasyonu));
            this.ParaAtmaButtonu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konuAnlatımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ParaAtmaButtonu
            // 
            this.ParaAtmaButtonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParaAtmaButtonu.Location = new System.Drawing.Point(12, 196);
            this.ParaAtmaButtonu.Name = "ParaAtmaButtonu";
            this.ParaAtmaButtonu.Size = new System.Drawing.Size(146, 89);
            this.ParaAtmaButtonu.TabIndex = 0;
            this.ParaAtmaButtonu.Text = "Para At";
            this.ParaAtmaButtonu.UseVisualStyleBackColor = true;
            this.ParaAtmaButtonu.Click += new System.EventHandler(this.ParaAtmaButtonu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.sorularToolStripMenuItem,
            this.konuAnlatımıToolStripMenuItem,
            this.programıKapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // sorularToolStripMenuItem
            // 
            this.sorularToolStripMenuItem.Name = "sorularToolStripMenuItem";
            this.sorularToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sorularToolStripMenuItem.Text = "Sorular";
            this.sorularToolStripMenuItem.Click += new System.EventHandler(this.sorularToolStripMenuItem_Click);
            // 
            // konuAnlatımıToolStripMenuItem
            // 
            this.konuAnlatımıToolStripMenuItem.Name = "konuAnlatımıToolStripMenuItem";
            this.konuAnlatımıToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.konuAnlatımıToolStripMenuItem.Text = "Konu Anlatımı";
            this.konuAnlatımıToolStripMenuItem.Click += new System.EventHandler(this.konuAnlatımıToolStripMenuItem_Click);
            // 
            // programıKapatToolStripMenuItem
            // 
            this.programıKapatToolStripMenuItem.Name = "programıKapatToolStripMenuItem";
            this.programıKapatToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.programıKapatToolStripMenuItem.Text = "Programı Kapat";
            this.programıKapatToolStripMenuItem.Click += new System.EventHandler(this.programıKapatToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kaç Adet Para Atılacak:";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(564, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 306);
            this.listBox1.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(313, 66);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 38);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ParaAtmaSimulasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ParaAtmaButtonu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParaAtmaSimulasyonu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Atma Simulasyonu";
            this.Load += new System.EventHandler(this.ParaAtmaSimulasyonu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ParaAtmaButtonu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konuAnlatımıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programıKapatToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}