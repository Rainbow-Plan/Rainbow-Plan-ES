using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging;
using RPlink;

namespace FunWinForm
{
    public partial class ShareWF : Form
    {
        //分享页：进则保存分享图片，退则返回上一窗体
        public ShareWF()
        {
            InitializeComponent();
        }

        public void TO_Pictrue(RPobject Share)//接收上一窗体的分享数据并填充到窗体文本框
        {
            if (Share.eng != null)
            {
                this.lbEnglish.Text = Share.eng;
                this.lbChanese.Text = Share.cn;
            }
            else
            {
                this.lbEnglish.Hide();
                this.lbChanese.Text = Share.cn;
            }
        }

        private void btGoBack_Click(object sender, EventArgs e)//合适的退步，反而有更多的经常
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)//执行截图保存图片
        {
            CaptureImage();
        }

        private void ShareWF_KeyPress(object sender, KeyPressEventArgs e)//按ESC是很聪明简单的
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }

        public void CaptureImage()     //截图并保存分享图片的方法
        {
            int Fleft = this.Left, Ftop = this.Top;
            Rectangle rect = System.Windows.Forms.SystemInformation.VirtualScreen;
            double Fwidth = 1920;
            double factor = Fwidth / rect.Width;
            //判断缩放倍数
            if(factor == 1.0)
            {
                Fleft = this.Left;
                Ftop = this.Top;
            }
            if (factor == 1.25)
            {
                Fleft = this.Left + 192;
                Ftop = this.Top + 108;
            }
            if (factor == 1.5)
            {
                Fleft = this.Left + 320;
                Ftop = this.Top + 180;
             }

            Bitmap image = new Bitmap(this.Width, this.Height);
            Graphics imgGraphics = Graphics.FromImage(image);
            imgGraphics.CopyFromScreen(Fleft, Ftop, 0, 0, new Size(this.Width, this.Height));
            SaveFileDialog op = new SaveFileDialog();
            op.Filter = "图片文件|*.bmp;*,jpg;*.png";
            if (op.ShowDialog() == DialogResult.OK)//显示保存文件对话框
            {
                image.Save(op.FileName);//保存图片
                MessageBox.Show("图片保存成功！");
            }
            imgGraphics.Dispose();
            image.Dispose();
        }
    }
}
