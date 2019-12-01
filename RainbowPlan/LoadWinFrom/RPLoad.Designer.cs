namespace LoadWinFrom
{
    partial class LoadWF
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadWF));
            this.lbWelcome = new System.Windows.Forms.Label();
            this.PBCenter = new System.Windows.Forms.PictureBox();
            this.lbEnglish = new System.Windows.Forms.Label();
            this.lbChinese = new System.Windows.Forms.Label();
            this.btToHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.BackColor = System.Drawing.SystemColors.Control;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWelcome.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbWelcome.Location = new System.Drawing.Point(269, 34);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(199, 52);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "欢迎使用";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBCenter
            // 
            this.PBCenter.Image = ((System.Drawing.Image)(resources.GetObject("PBCenter.Image")));
            this.PBCenter.Location = new System.Drawing.Point(225, 95);
            this.PBCenter.Margin = new System.Windows.Forms.Padding(4);
            this.PBCenter.Name = "PBCenter";
            this.PBCenter.Size = new System.Drawing.Size(291, 363);
            this.PBCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCenter.TabIndex = 1;
            this.PBCenter.TabStop = false;
            // 
            // lbEnglish
            // 
            this.lbEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbEnglish.Location = new System.Drawing.Point(266, 140);
            this.lbEnglish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnglish.Name = "lbEnglish";
            this.lbEnglish.Size = new System.Drawing.Size(212, 35);
            this.lbEnglish.TabIndex = 2;
            this.lbEnglish.Text = "English";
            // 
            // lbChinese
            // 
            this.lbChinese.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbChinese.Location = new System.Drawing.Point(266, 194);
            this.lbChinese.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChinese.Name = "lbChinese";
            this.lbChinese.Size = new System.Drawing.Size(212, 228);
            this.lbChinese.TabIndex = 2;
            this.lbChinese.Text = "Chinese";
            // 
            // btToHome
            // 
            this.btToHome.BackColor = System.Drawing.SystemColors.Control;
            this.btToHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btToHome.BackgroundImage")));
            this.btToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btToHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btToHome.Font = new System.Drawing.Font("楷体_GB2312", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btToHome.ForeColor = System.Drawing.Color.SteelBlue;
            this.btToHome.Location = new System.Drawing.Point(278, 484);
            this.btToHome.Name = "btToHome";
            this.btToHome.Size = new System.Drawing.Size(190, 45);
            this.btToHome.TabIndex = 3;
            this.btToHome.Text = "进入";
            this.btToHome.UseVisualStyleBackColor = false;
            this.btToHome.Click += new System.EventHandler(this.btToHome_Click);
            // 
            // LoadWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.btToHome);
            this.Controls.Add(this.lbChinese);
            this.Controls.Add(this.lbEnglish);
            this.Controls.Add(this.PBCenter);
            this.Controls.Add(this.lbWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎";
            this.Load += new System.EventHandler(this.LoadWF_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoadWF_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PBCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.PictureBox PBCenter;
        private System.Windows.Forms.Label lbEnglish;
        private System.Windows.Forms.Label lbChinese;
        private System.Windows.Forms.Button btToHome;
    }
}

