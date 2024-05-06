namespace OlasilikHesaplama
{
    partial class ProjeTasarim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjeTasarim));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GitHubButton = new System.Windows.Forms.Button();
            this.StartingText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GitHubButton
            // 
            this.GitHubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GitHubButton.Location = new System.Drawing.Point(12, 74);
            this.GitHubButton.Name = "GitHubButton";
            this.GitHubButton.Size = new System.Drawing.Size(127, 84);
            this.GitHubButton.TabIndex = 1;
            this.GitHubButton.Text = "Program Kodları";
            this.GitHubButton.UseVisualStyleBackColor = true;
            this.GitHubButton.Click += new System.EventHandler(this.GitHubButton_Click);
            this.GitHubButton.MouseHover += new System.EventHandler(this.GitHubButton_MouseHover);
            // 
            // StartingText
            // 
            this.StartingText.AutoSize = true;
            this.StartingText.BackColor = System.Drawing.Color.Black;
            this.StartingText.ForeColor = System.Drawing.Color.White;
            this.StartingText.Location = new System.Drawing.Point(436, 85);
            this.StartingText.Name = "StartingText";
            this.StartingText.Size = new System.Drawing.Size(169, 13);
            this.StartingText.TabIndex = 2;
            this.StartingText.Text = "Proje Başlangıç Tarihi: 23.12.2023";
            // 
            // ProjeTasarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 432);
            this.Controls.Add(this.StartingText);
            this.Controls.Add(this.GitHubButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjeTasarim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje Tasarım";
            this.Load += new System.EventHandler(this.ProjeTasarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GitHubButton;
        private System.Windows.Forms.Label StartingText;
    }
}