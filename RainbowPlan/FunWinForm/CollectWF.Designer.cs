namespace FunWinForm
{
    partial class CollectWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectWF));
            this.pbCollect = new System.Windows.Forms.PictureBox();
            this.gbCollect = new System.Windows.Forms.GroupBox();
            this.btPreserve = new System.Windows.Forms.Button();
            this.btToShare = new System.Windows.Forms.Button();
            this.rtxCollect = new System.Windows.Forms.RichTextBox();
            this.lbSlogan = new System.Windows.Forms.Label();
            this.gbRecord = new System.Windows.Forms.GroupBox();
            this.btToHome = new System.Windows.Forms.Button();
            this.btRToShare3 = new System.Windows.Forms.Button();
            this.btRToShare2 = new System.Windows.Forms.Button();
            this.btRToShare1 = new System.Windows.Forms.Button();
            this.lbRecord3 = new System.Windows.Forms.Label();
            this.lbRecord2 = new System.Windows.Forms.Label();
            this.lbRecord1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollect)).BeginInit();
            this.gbCollect.SuspendLayout();
            this.gbRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCollect
            // 
            this.pbCollect.Image = ((System.Drawing.Image)(resources.GetObject("pbCollect.Image")));
            this.pbCollect.Location = new System.Drawing.Point(0, 0);
            this.pbCollect.Name = "pbCollect";
            this.pbCollect.Size = new System.Drawing.Size(255, 258);
            this.pbCollect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCollect.TabIndex = 0;
            this.pbCollect.TabStop = false;
            // 
            // gbCollect
            // 
            this.gbCollect.Controls.Add(this.btPreserve);
            this.gbCollect.Controls.Add(this.btToShare);
            this.gbCollect.Controls.Add(this.rtxCollect);
            this.gbCollect.Font = new System.Drawing.Font("楷体_GB2312", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbCollect.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gbCollect.Location = new System.Drawing.Point(255, 0);
            this.gbCollect.Name = "gbCollect";
            this.gbCollect.Size = new System.Drawing.Size(495, 258);
            this.gbCollect.TabIndex = 1;
            this.gbCollect.TabStop = false;
            this.gbCollect.Text = "在此处输入啦！";
            // 
            // btPreserve
            // 
            this.btPreserve.Font = new System.Drawing.Font("楷体_GB2312", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPreserve.ForeColor = System.Drawing.Color.Black;
            this.btPreserve.Image = ((System.Drawing.Image)(resources.GetObject("btPreserve.Image")));
            this.btPreserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPreserve.Location = new System.Drawing.Point(305, 200);
            this.btPreserve.Name = "btPreserve";
            this.btPreserve.Size = new System.Drawing.Size(156, 52);
            this.btPreserve.TabIndex = 1;
            this.btPreserve.Text = "保存";
            this.btPreserve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPreserve.UseVisualStyleBackColor = true;
            this.btPreserve.Click += new System.EventHandler(this.btPreserve_Click);
            // 
            // btToShare
            // 
            this.btToShare.Font = new System.Drawing.Font("楷体_GB2312", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btToShare.ForeColor = System.Drawing.Color.Black;
            this.btToShare.Image = ((System.Drawing.Image)(resources.GetObject("btToShare.Image")));
            this.btToShare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btToShare.Location = new System.Drawing.Point(108, 200);
            this.btToShare.Name = "btToShare";
            this.btToShare.Size = new System.Drawing.Size(156, 52);
            this.btToShare.TabIndex = 1;
            this.btToShare.Text = "分享";
            this.btToShare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btToShare.UseVisualStyleBackColor = true;
            this.btToShare.Click += new System.EventHandler(this.btToShare_Click);
            // 
            // rtxCollect
            // 
            this.rtxCollect.Font = new System.Drawing.Font("楷体_GB2312", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxCollect.Location = new System.Drawing.Point(1, 37);
            this.rtxCollect.Name = "rtxCollect";
            this.rtxCollect.Size = new System.Drawing.Size(486, 157);
            this.rtxCollect.TabIndex = 0;
            this.rtxCollect.Text = "Learning is a cumulative process.";
            // 
            // lbSlogan
            // 
            this.lbSlogan.Font = new System.Drawing.Font("楷体_GB2312", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSlogan.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbSlogan.Image = ((System.Drawing.Image)(resources.GetObject("lbSlogan.Image")));
            this.lbSlogan.Location = new System.Drawing.Point(0, 258);
            this.lbSlogan.Name = "lbSlogan";
            this.lbSlogan.Size = new System.Drawing.Size(130, 292);
            this.lbSlogan.TabIndex = 2;
            this.lbSlogan.Text = "日\r\n 积\r\n月\r\n 累";
            this.lbSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbRecord
            // 
            this.gbRecord.Controls.Add(this.btToHome);
            this.gbRecord.Controls.Add(this.btRToShare3);
            this.gbRecord.Controls.Add(this.btRToShare2);
            this.gbRecord.Controls.Add(this.btRToShare1);
            this.gbRecord.Controls.Add(this.lbRecord3);
            this.gbRecord.Controls.Add(this.lbRecord2);
            this.gbRecord.Controls.Add(this.lbRecord1);
            this.gbRecord.Font = new System.Drawing.Font("楷体_GB2312", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbRecord.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gbRecord.Location = new System.Drawing.Point(126, 258);
            this.gbRecord.Name = "gbRecord";
            this.gbRecord.Size = new System.Drawing.Size(622, 292);
            this.gbRecord.TabIndex = 3;
            this.gbRecord.TabStop = false;
            this.gbRecord.Text = "以前的收集！";
            // 
            // btToHome
            // 
            this.btToHome.Font = new System.Drawing.Font("楷体_GB2312", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btToHome.ForeColor = System.Drawing.Color.Black;
            this.btToHome.Image = ((System.Drawing.Image)(resources.GetObject("btToHome.Image")));
            this.btToHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btToHome.Location = new System.Drawing.Point(549, 117);
            this.btToHome.Name = "btToHome";
            this.btToHome.Size = new System.Drawing.Size(67, 164);
            this.btToHome.TabIndex = 5;
            this.btToHome.Text = "主\r\n页";
            this.btToHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btToHome.UseVisualStyleBackColor = true;
            this.btToHome.Click += new System.EventHandler(this.btToHome_Click);
            // 
            // btRToShare3
            // 
            this.btRToShare3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRToShare3.BackgroundImage")));
            this.btRToShare3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRToShare3.Font = new System.Drawing.Font("楷体_GB2312", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRToShare3.ForeColor = System.Drawing.Color.Black;
            this.btRToShare3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRToShare3.Location = new System.Drawing.Point(480, 220);
            this.btRToShare3.Name = "btRToShare3";
            this.btRToShare3.Size = new System.Drawing.Size(53, 53);
            this.btRToShare3.TabIndex = 4;
            this.btRToShare3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRToShare3.UseVisualStyleBackColor = true;
            // 
            // btRToShare2
            // 
            this.btRToShare2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRToShare2.BackgroundImage")));
            this.btRToShare2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRToShare2.Font = new System.Drawing.Font("楷体_GB2312", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRToShare2.ForeColor = System.Drawing.Color.Black;
            this.btRToShare2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRToShare2.Location = new System.Drawing.Point(480, 136);
            this.btRToShare2.Name = "btRToShare2";
            this.btRToShare2.Size = new System.Drawing.Size(53, 53);
            this.btRToShare2.TabIndex = 3;
            this.btRToShare2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRToShare2.UseVisualStyleBackColor = true;
            // 
            // btRToShare1
            // 
            this.btRToShare1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRToShare1.BackgroundImage")));
            this.btRToShare1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRToShare1.Font = new System.Drawing.Font("楷体_GB2312", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRToShare1.ForeColor = System.Drawing.Color.Black;
            this.btRToShare1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRToShare1.Location = new System.Drawing.Point(549, 54);
            this.btRToShare1.Name = "btRToShare1";
            this.btRToShare1.Size = new System.Drawing.Size(53, 53);
            this.btRToShare1.TabIndex = 2;
            this.btRToShare1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRToShare1.UseVisualStyleBackColor = true;
            // 
            // lbRecord3
            // 
            this.lbRecord3.BackColor = System.Drawing.Color.White;
            this.lbRecord3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRecord3.Font = new System.Drawing.Font("楷体_GB2312", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRecord3.ForeColor = System.Drawing.Color.Black;
            this.lbRecord3.Location = new System.Drawing.Point(1, 201);
            this.lbRecord3.Name = "lbRecord3";
            this.lbRecord3.Size = new System.Drawing.Size(545, 80);
            this.lbRecord3.TabIndex = 0;
            this.lbRecord3.Text = "Record2";
            // 
            // lbRecord2
            // 
            this.lbRecord2.BackColor = System.Drawing.Color.White;
            this.lbRecord2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRecord2.Font = new System.Drawing.Font("楷体_GB2312", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRecord2.ForeColor = System.Drawing.Color.Black;
            this.lbRecord2.Location = new System.Drawing.Point(1, 117);
            this.lbRecord2.Name = "lbRecord2";
            this.lbRecord2.Size = new System.Drawing.Size(545, 80);
            this.lbRecord2.TabIndex = 0;
            this.lbRecord2.Text = "Record2";
            // 
            // lbRecord1
            // 
            this.lbRecord1.BackColor = System.Drawing.Color.White;
            this.lbRecord1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRecord1.Font = new System.Drawing.Font("楷体_GB2312", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRecord1.ForeColor = System.Drawing.Color.Black;
            this.lbRecord1.Location = new System.Drawing.Point(1, 34);
            this.lbRecord1.Name = "lbRecord1";
            this.lbRecord1.Size = new System.Drawing.Size(615, 80);
            this.lbRecord1.TabIndex = 0;
            this.lbRecord1.Text = "Record1";
            // 
            // CollectWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.gbRecord);
            this.Controls.Add(this.lbSlogan);
            this.Controls.Add(this.gbCollect);
            this.Controls.Add(this.pbCollect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "CollectWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CollectWF";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CollectWF_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbCollect)).EndInit();
            this.gbCollect.ResumeLayout(false);
            this.gbRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCollect;
        private System.Windows.Forms.GroupBox gbCollect;
        private System.Windows.Forms.Button btPreserve;
        private System.Windows.Forms.Button btToShare;
        private System.Windows.Forms.RichTextBox rtxCollect;
        private System.Windows.Forms.Label lbSlogan;
        private System.Windows.Forms.GroupBox gbRecord;
        private System.Windows.Forms.Label lbRecord3;
        private System.Windows.Forms.Label lbRecord2;
        private System.Windows.Forms.Label lbRecord1;
        private System.Windows.Forms.Button btToHome;
        private System.Windows.Forms.Button btRToShare3;
        private System.Windows.Forms.Button btRToShare2;
        private System.Windows.Forms.Button btRToShare1;
    }
}