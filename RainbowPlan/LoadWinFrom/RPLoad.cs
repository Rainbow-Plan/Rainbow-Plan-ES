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
using HomeWinFrom;

namespace LoadWinFrom
{
    public partial class LoadWF : Form
    {
        //登陆欢迎页
        public LoadWF()
        {
            InitializeComponent();
        }
        public RPobject OB_Load = new RPobject(1);//欢迎页用于命令和数据传递接受的连接对象
        private void Load_Word()
        {
            RPconnect CT_Load = new RPconnect(OB_Load);//使用“连接”获取数据
            OB_Load = CT_Load.captureWord();
        }

        private void LoadWF_Load(object sender, EventArgs e)//将数据填充到窗体文本框
        {
            Load_Word();
            this.lbEnglish.Text = OB_Load.eng;
            this.lbChinese.Text = OB_Load.cn;
        }

        private void LoadWF_KeyPress(object sender, KeyPressEventArgs e)//按ESC退出程序
        {
            if(e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }

        private void btToHome_Click(object sender, EventArgs e)//前进，通往主页
        {
            HomeWF ToHome = new HomeWF();
            ToHome.Show();
            this.Hide();
            
        }
    }
}
