using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RPlink;
using FunWinForm;

namespace HomeWinFrom
{
    public partial class HomeWF : Form
    {
        //主页：有“记单词”，“爱收藏”功能
        public HomeWF()
        {
            InitializeComponent();
        }

        public RPobject OB_Home = new RPobject(2);//主页用于命令和数据传递的对象
        public void Home_Word()
        {
            RPconnect CT_Home = new RPconnect(OB_Home);//连接并获取数据
            OB_Home = CT_Home.captureWord();
        }

        private void HomeWF_Load(object sender, EventArgs e)//填充数据到窗体文本框
        {
            Home_Word();
            this.lbEngCenter.Text = OB_Home.eng;
            this.lbCnCenter.Text = OB_Home.cn;
            Home_Word();
            this.lbEngLeft.Text = OB_Home.eng;
            this.lbCnLeft.Text = OB_Home.cn;
            Home_Word();
            this.lbEngRight.Text = OB_Home.eng;
            this.lbCnRight.Text = OB_Home.cn;
        }

        private void HomeWF_KeyPress(object sender, KeyPressEventArgs e)//按ESC退出程序
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                Application.Exit();
                return;
            }
        }

        private void btToWord_Click(object sender, EventArgs e)//前进，通往“记单词”
        {
            WordWF To_Word = new WordWF();
            To_Word.Show();
        }

        private void btToCollect_Click(object sender, EventArgs e)//前进，通往“爱收藏”
        {
            CollectWF To_Collect = new CollectWF();
            To_Collect.Show();
        }
    }
}
