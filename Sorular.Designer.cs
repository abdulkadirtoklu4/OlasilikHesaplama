namespace OlasilikHesaplama
{
    partial class Sorular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorular));
            this.labelSoru = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ShowAnswersButton = new System.Windows.Forms.Button();
            this.PrintQuestionsButton = new System.Windows.Forms.Button();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.rdOnly = new System.Windows.Forms.RadioButton();
            this.TextBuyut = new System.Windows.Forms.Button();
            this.TextKucult = new System.Windows.Forms.Button();
            this.TextSifirla = new System.Windows.Forms.Button();
            this.labelCevap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSoru
            // 
            this.labelSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoru.Location = new System.Drawing.Point(8, 18);
            this.labelSoru.Name = "labelSoru";
            this.labelSoru.Size = new System.Drawing.Size(771, 109);
            this.labelSoru.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(12, 204);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(89, 52);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Soruyu Yenile";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ShowAnswersButton
            // 
            this.ShowAnswersButton.Location = new System.Drawing.Point(120, 204);
            this.ShowAnswersButton.Name = "ShowAnswersButton";
            this.ShowAnswersButton.Size = new System.Drawing.Size(98, 52);
            this.ShowAnswersButton.TabIndex = 2;
            this.ShowAnswersButton.Text = "Cevapları Göster";
            this.ShowAnswersButton.UseVisualStyleBackColor = true;
            this.ShowAnswersButton.Click += new System.EventHandler(this.ShowAnswersButton_Click);
            // 
            // PrintQuestionsButton
            // 
            this.PrintQuestionsButton.Location = new System.Drawing.Point(239, 204);
            this.PrintQuestionsButton.Name = "PrintQuestionsButton";
            this.PrintQuestionsButton.Size = new System.Drawing.Size(98, 52);
            this.PrintQuestionsButton.TabIndex = 4;
            this.PrintQuestionsButton.Text = "Soruları Yazdır";
            this.PrintQuestionsButton.UseVisualStyleBackColor = true;
            this.PrintQuestionsButton.Click += new System.EventHandler(this.PrintQuestionsButton_Click);
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Location = new System.Drawing.Point(362, 204);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(112, 17);
            this.rdAll.TabIndex = 5;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "Hepsini Dışa Aktar";
            this.rdAll.UseVisualStyleBackColor = true;
            // 
            // rdOnly
            // 
            this.rdOnly.AutoSize = true;
            this.rdOnly.Location = new System.Drawing.Point(362, 239);
            this.rdOnly.Name = "rdOnly";
            this.rdOnly.Size = new System.Drawing.Size(172, 17);
            this.rdOnly.TabIndex = 6;
            this.rdOnly.TabStop = true;
            this.rdOnly.Text = "Sadece Bir Tanesini Dışa Aktar";
            this.rdOnly.UseVisualStyleBackColor = true;
            // 
            // TextBuyut
            // 
            this.TextBuyut.Location = new System.Drawing.Point(554, 208);
            this.TextBuyut.Name = "TextBuyut";
            this.TextBuyut.Size = new System.Drawing.Size(65, 48);
            this.TextBuyut.TabIndex = 7;
            this.TextBuyut.Text = "A+";
            this.TextBuyut.UseVisualStyleBackColor = true;
            this.TextBuyut.Click += new System.EventHandler(this.TextBuyut_Click);
            // 
            // TextKucult
            // 
            this.TextKucult.Enabled = false;
            this.TextKucult.Location = new System.Drawing.Point(625, 208);
            this.TextKucult.Name = "TextKucult";
            this.TextKucult.Size = new System.Drawing.Size(65, 48);
            this.TextKucult.TabIndex = 8;
            this.TextKucult.Text = "A-";
            this.TextKucult.UseVisualStyleBackColor = true;
            this.TextKucult.Click += new System.EventHandler(this.TextKucult_Click);
            // 
            // TextSifirla
            // 
            this.TextSifirla.Location = new System.Drawing.Point(696, 208);
            this.TextSifirla.Name = "TextSifirla";
            this.TextSifirla.Size = new System.Drawing.Size(65, 48);
            this.TextSifirla.TabIndex = 9;
            this.TextSifirla.Text = "Sıfırla";
            this.TextSifirla.UseVisualStyleBackColor = true;
            this.TextSifirla.Click += new System.EventHandler(this.TextSifirla_Click);
            // 
            // labelCevap
            // 
            this.labelCevap.AutoSize = true;
            this.labelCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCevap.Location = new System.Drawing.Point(8, 151);
            this.labelCevap.Name = "labelCevap";
            this.labelCevap.Size = new System.Drawing.Size(0, 20);
            this.labelCevap.TabIndex = 10;
            // 
            // Sorular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 268);
            this.Controls.Add(this.labelCevap);
            this.Controls.Add(this.TextSifirla);
            this.Controls.Add(this.TextKucult);
            this.Controls.Add(this.TextBuyut);
            this.Controls.Add(this.rdOnly);
            this.Controls.Add(this.rdAll);
            this.Controls.Add(this.PrintQuestionsButton);
            this.Controls.Add(this.ShowAnswersButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.labelSoru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sorular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorular";
            this.Load += new System.EventHandler(this.Sorular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoru;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button ShowAnswersButton;
        private System.Windows.Forms.Button PrintQuestionsButton;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.RadioButton rdOnly;
        private System.Windows.Forms.Button TextBuyut;
        private System.Windows.Forms.Button TextKucult;
        private System.Windows.Forms.Button TextSifirla;
        private System.Windows.Forms.Label labelCevap;
    }
}