namespace FunWinForm
{
    partial class WordWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordWF));
            this.btToShare = new System.Windows.Forms.Button();
            this.btToHome = new System.Windows.Forms.Button();
            this.lbWord = new System.Windows.Forms.Label();
            this.lbCnRight = new System.Windows.Forms.Label();
            this.lbEngRight = new System.Windows.Forms.Label();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.lbCnLeft = new System.Windows.Forms.Label();
            this.lbEngLeft = new System.Windows.Forms.Label();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.lbCnCenter = new System.Windows.Forms.Label();
            this.lbEngCenter = new System.Windows.Forms.Label();
            this.pbCenter = new System.Windows.Forms.PictureBox();
            this.btToLeft = new System.Windows.Forms.Button();
            this.btToRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // btToShare
            // 
            this.btToShare.BackColor = System.Drawing.SystemColors.Control;
            this.btToShare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToShare.BackgroundImage")));
            this.btToShare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btToShare.FlatAppearance.BorderSize = 0;
            this.btToShare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btToShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btToShare.ForeColor = System.Drawing.Color.Black;
            this.btToShare.Image = ((System.Drawing.Image)(resources.GetObject("btToShare.Image")));
            this.btToShare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btToShare.Location = new System.Drawing.Point(301, 386);
            this.btToShare.Margin = new System.Windows.Forms.Padding(2);
            this.btToShare.Name = "btToShare";
            this.btToShare.Size = new System.Drawing.Size(142, 38);
            this.btToShare.TabIndex = 23;
            this.btToShare.Text = "乐分享";
            this.btToShare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btToShare.UseVisualStyleBackColor = false;
            this.btToShare.Click += new System.EventHandler(this.btToShare_Click);
            // 
            // btToHome
            // 
            this.btToHome.BackColor = System.Drawing.SystemColors.Control;
            this.btToHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToHome.BackgroundImage")));
            this.btToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btToHome.FlatAppearance.BorderSize = 0;
            this.btToHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btToHome.ForeColor = System.Drawing.Color.Black;
            this.btToHome.Image = ((System.Drawing.Image)(resources.GetObject("btToHome.Image")));
            this.btToHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btToHome.Location = new System.Drawing.Point(114, 386);
            this.btToHome.Margin = new System.Windows.Forms.Padding(2);
            this.btToHome.Name = "btToHome";
            this.btToHome.Size = new System.Drawing.Size(142, 38);
            this.btToHome.TabIndex = 24;
            this.btToHome.Text = "回主页";
            this.btToHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btToHome.UseVisualStyleBackColor = false;
            this.btToHome.Click += new System.EventHandler(this.btToHome_Click);
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.BackColor = System.Drawing.SystemColors.Control;
            this.lbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWord.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbWord.Location = new System.Drawing.Point(188, 27);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(192, 39);
            this.lbWord.TabIndex = 22;
            this.lbWord.Text = "爱记才会赢";
            this.lbWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCnRight
            // 
            this.lbCnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCnRight.Location = new System.Drawing.Point(492, 155);
            this.lbCnRight.Name = "lbCnRight";
            this.lbCnRight.Size = new System.Drawing.Size(159, 182);
            this.lbCnRight.TabIndex = 21;
            this.lbCnRight.Text = "ChaneseRight";
            // 
            // lbEngRight
            // 
            this.lbEngRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbEngRight.Location = new System.Drawing.Point(492, 112);
            this.lbEngRight.Name = "lbEngRight";
            this.lbEngRight.Size = new System.Drawing.Size(159, 28);
            this.lbEngRight.TabIndex = 20;
            this.lbEngRight.Text = "EnglishRight";
            // 
            // pbRight
            // 
            this.pbRight.Image = ((System.Drawing.Image)(resources.GetObject("pbRight.Image")));
            this.pbRight.Location = new System.Drawing.Point(461, 76);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(218, 290);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRight.TabIndex = 19;
            this.pbRight.TabStop = false;
            // 
            // lbCnLeft
            // 
            this.lbCnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCnLeft.Location = new System.Drawing.Point(-93, 155);
            this.lbCnLeft.Name = "lbCnLeft";
            this.lbCnLeft.Size = new System.Drawing.Size(159, 182);
            this.lbCnLeft.TabIndex = 18;
            this.lbCnLeft.Text = "ChaneseLeft";
            this.lbCnLeft.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbEngLeft
            // 
            this.lbEngLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbEngLeft.Location = new System.Drawing.Point(-93, 112);
            this.lbEngLeft.Name = "lbEngLeft";
            this.lbEngLeft.Size = new System.Drawing.Size(159, 28);
            this.lbEngLeft.TabIndex = 17;
            this.lbEngLeft.Text = "EnglishLeft";
            this.lbEngLeft.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbLeft
            // 
            this.pbLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbLeft.Image")));
            this.pbLeft.Location = new System.Drawing.Point(-124, 76);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(218, 290);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeft.TabIndex = 16;
            this.pbLeft.TabStop = false;
            // 
            // lbCnCenter
            // 
            this.lbCnCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCnCenter.Location = new System.Drawing.Point(200, 155);
            this.lbCnCenter.Name = "lbCnCenter";
            this.lbCnCenter.Size = new System.Drawing.Size(159, 182);
            this.lbCnCenter.TabIndex = 15;
            this.lbCnCenter.Text = "ChaneseCenter";
            // 
            // lbEngCenter
            // 
            this.lbEngCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbEngCenter.Location = new System.Drawing.Point(200, 112);
            this.lbEngCenter.Name = "lbEngCenter";
            this.lbEngCenter.Size = new System.Drawing.Size(159, 28);
            this.lbEngCenter.TabIndex = 14;
            this.lbEngCenter.Text = "EnglishCenter";
            // 
            // pbCenter
            // 
            this.pbCenter.Image = ((System.Drawing.Image)(resources.GetObject("pbCenter.Image")));
            this.pbCenter.Location = new System.Drawing.Point(169, 76);
            this.pbCenter.Name = "pbCenter";
            this.pbCenter.Size = new System.Drawing.Size(218, 290);
            this.pbCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCenter.TabIndex = 13;
            this.pbCenter.TabStop = false;
            // 
            // btToLeft
            // 
            this.btToLeft.BackColor = System.Drawing.Color.Transparent;
            this.btToLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToLeft.BackgroundImage")));
            this.btToLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btToLeft.FlatAppearance.BorderSize = 0;
            this.btToLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btToLeft.Location = new System.Drawing.Point(96, 177);
            this.btToLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btToLeft.Name = "btToLeft";
            this.btToLeft.Size = new System.Drawing.Size(71, 97);
            this.btToLeft.TabIndex = 25;
            this.btToLeft.UseVisualStyleBackColor = false;
            this.btToLeft.Click += new System.EventHandler(this.btToLeft_Click);
            // 
            // btToRight
            // 
            this.btToRight.BackColor = System.Drawing.Color.Transparent;
            this.btToRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToRight.BackgroundImage")));
            this.btToRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btToRight.FlatAppearance.BorderSize = 0;
            this.btToRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btToRight.Location = new System.Drawing.Point(388, 177);
            this.btToRight.Margin = new System.Windows.Forms.Padding(2);
            this.btToRight.Name = "btToRight";
            this.btToRight.Size = new System.Drawing.Size(71, 97);
            this.btToRight.TabIndex = 25;
            this.btToRight.UseVisualStyleBackColor = false;
            this.btToRight.Click += new System.EventHandler(this.btToRight_Click);
            // 
            // WordWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 440);
            this.Controls.Add(this.btToRight);
            this.Controls.Add(this.btToLeft);
            this.Controls.Add(this.btToShare);
            this.Controls.Add(this.btToHome);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.lbCnRight);
            this.Controls.Add(this.lbEngRight);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.lbCnLeft);
            this.Controls.Add(this.lbEngLeft);
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.lbCnCenter);
            this.Controls.Add(this.lbEngCenter);
            this.Controls.Add(this.pbCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WordWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordWF";
            this.Load += new System.EventHandler(this.WordWF_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WordWF_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btToShare;
        private System.Windows.Forms.Button btToHome;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Label lbCnRight;
        private System.Windows.Forms.Label lbEngRight;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.Label lbCnLeft;
        private System.Windows.Forms.Label lbEngLeft;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.Label lbCnCenter;
        private System.Windows.Forms.Label lbEngCenter;
        private System.Windows.Forms.PictureBox pbCenter;
        private System.Windows.Forms.Button btToLeft;
        private System.Windows.Forms.Button btToRight;
    }
}