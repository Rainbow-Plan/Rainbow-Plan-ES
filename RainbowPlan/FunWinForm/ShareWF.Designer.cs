namespace FunWinForm
{
    partial class ShareWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShareWF));
            this.lbSlogan1 = new System.Windows.Forms.Label();
            this.btGoBack = new System.Windows.Forms.Button();
            this.lbChanese = new System.Windows.Forms.Label();
            this.lbEnglish = new System.Windows.Forms.Label();
            this.PBShare = new System.Windows.Forms.PictureBox();
            this.lbShare = new System.Windows.Forms.Label();
            this.lbSlogan2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBShare)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSlogan1
            // 
            this.lbSlogan1.AutoSize = true;
            this.lbSlogan1.BackColor = System.Drawing.Color.White;
            this.lbSlogan1.Font = new System.Drawing.Font("仿宋_GB2312", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSlogan1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbSlogan1.Location = new System.Drawing.Point(84, 95);
            this.lbSlogan1.Name = "lbSlogan1";
            this.lbSlogan1.Size = new System.Drawing.Size(55, 190);
            this.lbSlogan1.TabIndex = 0;
            this.lbSlogan1.Text = "不\r\n一\r\n定\r\n最\r\n好";
            // 
            // btGoBack
            // 
            this.btGoBack.BackColor = System.Drawing.SystemColors.Control;
            this.btGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGoBack.BackgroundImage")));
            this.btGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGoBack.Font = new System.Drawing.Font("楷体_GB2312", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGoBack.ForeColor = System.Drawing.Color.SteelBlue;
            this.btGoBack.Location = new System.Drawing.Point(225, 481);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(129, 45);
            this.btGoBack.TabIndex = 8;
            this.btGoBack.Text = "返回";
            this.btGoBack.UseVisualStyleBackColor = false;
            this.btGoBack.Click += new System.EventHandler(this.btGoBack_Click);
            // 
            // lbChanese
            // 
            this.lbChanese.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbChanese.Location = new System.Drawing.Point(266, 194);
            this.lbChanese.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChanese.Name = "lbChanese";
            this.lbChanese.Size = new System.Drawing.Size(212, 228);
            this.lbChanese.TabIndex = 6;
            this.lbChanese.Text = "Chanese";
            // 
            // lbEnglish
            // 
            this.lbEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbEnglish.Location = new System.Drawing.Point(266, 140);
            this.lbEnglish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnglish.Name = "lbEnglish";
            this.lbEnglish.Size = new System.Drawing.Size(212, 35);
            this.lbEnglish.TabIndex = 7;
            this.lbEnglish.Text = "English";
            // 
            // PBShare
            // 
            this.PBShare.Image = ((System.Drawing.Image)(resources.GetObject("PBShare.Image")));
            this.PBShare.Location = new System.Drawing.Point(225, 95);
            this.PBShare.Margin = new System.Windows.Forms.Padding(4);
            this.PBShare.Name = "PBShare";
            this.PBShare.Size = new System.Drawing.Size(291, 363);
            this.PBShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBShare.TabIndex = 5;
            this.PBShare.TabStop = false;
            // 
            // lbShare
            // 
            this.lbShare.AutoSize = true;
            this.lbShare.BackColor = System.Drawing.Color.White;
            this.lbShare.Font = new System.Drawing.Font("楷体_GB2312", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbShare.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbShare.Location = new System.Drawing.Point(160, 37);
            this.lbShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShare.Name = "lbShare";
            this.lbShare.Size = new System.Drawing.Size(459, 43);
            this.lbShare.TabIndex = 4;
            this.lbShare.Text = "知识，是值得分享的。";
            this.lbShare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSlogan2
            // 
            this.lbSlogan2.AutoSize = true;
            this.lbSlogan2.BackColor = System.Drawing.Color.White;
            this.lbSlogan2.Font = new System.Drawing.Font("仿宋_GB2312", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSlogan2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbSlogan2.Location = new System.Drawing.Point(610, 230);
            this.lbSlogan2.Name = "lbSlogan2";
            this.lbSlogan2.Size = new System.Drawing.Size(55, 228);
            this.lbSlogan2.TabIndex = 0;
            this.lbSlogan2.Text = "但\r\n一\r\n定\r\n最\r\n喜\r\n欢";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.Control;
            this.btSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSave.BackgroundImage")));
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Font = new System.Drawing.Font("楷体_GB2312", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.btSave.Location = new System.Drawing.Point(387, 481);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(129, 45);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ShareWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btGoBack);
            this.Controls.Add(this.lbChanese);
            this.Controls.Add(this.lbEnglish);
            this.Controls.Add(this.PBShare);
            this.Controls.Add(this.lbShare);
            this.Controls.Add(this.lbSlogan2);
            this.Controls.Add(this.lbSlogan1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ShareWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShareWF";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShareWF_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PBShare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSlogan1;
        private System.Windows.Forms.Button btGoBack;
        private System.Windows.Forms.Label lbChanese;
        private System.Windows.Forms.Label lbEnglish;
        private System.Windows.Forms.PictureBox PBShare;
        private System.Windows.Forms.Label lbShare;
        private System.Windows.Forms.Label lbSlogan2;
        private System.Windows.Forms.Button btSave;
    }
}