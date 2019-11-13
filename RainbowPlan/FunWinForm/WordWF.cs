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

namespace FunWinForm
{
    public partial class WordWF : Form
    {
        //记单词页：可以上下跳转单词（五个以内），可以分享单词
        int i = 0;//单词计数
        public WordWF()
        {
            InitializeComponent();
        }

        RPobject OB_Word = new RPobject(3);//单词页用于命令和数据传递的对象
        WordList WordQ = new WordList();//用于储存Word的队列对象
        private void Word()
        {
            RPconnect CT_Word = new RPconnect(OB_Word);
            OB_Word = CT_Word.captureWord();
            WordQ.WordQueue(OB_Word);
            if (i <= 6) { i++; }
        }
        
        private void WordWF_Load(object sender, EventArgs e)//获取数据填到窗体文本框
        {
            Word();
            this.lbEngLeft.Text = OB_Word.eng;
            this.lbCnLeft.Text = OB_Word.cn;
            Word();
            this.lbEngCenter.Text = OB_Word.eng;
            this.lbCnCenter.Text = OB_Word.cn;
            Word();
            this.lbEngRight.Text = OB_Word.eng;
            this.lbCnRight.Text = OB_Word.cn;
        }

        //右滑，下一个单词
        private void btToRight_Click(object sender, EventArgs e)
        {
            Word();
            this.lbEngLeft.Text = this.lbEngCenter.Text;
            this.lbCnLeft.Text = this.lbCnCenter.Text;
            this.lbEngCenter.Text = this.lbEngRight.Text;
            this.lbCnCenter.Text = this.lbCnRight.Text;
            this.lbEngRight.Text = OB_Word.eng;
            this.lbCnRight.Text = OB_Word.cn;
        }
        //左滑，上一个单词
        private void btToLeft_Click(object sender, EventArgs e)
        {
            int a = i;//局部计数
            this.lbEngRight.Text = this.lbEngCenter.Text;
            this.lbCnRight.Text = this.lbCnCenter.Text;
            this.lbEngCenter.Text = this.lbEngLeft.Text;
            this.lbCnCenter.Text = this.lbCnLeft.Text;
            if(a >= 4)//判断是否从队列中拿到之前浏览的单词数据
            {
                this.lbEngLeft.Text = WordQ.Word_Queue[a-4].eng;
                this.lbCnLeft.Text = WordQ.Word_Queue[a-4].cn;
                a--;
            }
            else
            {
                this.lbEngLeft.Text = null;
                this.lbCnLeft.Text = null;
            }
        }

        private void btToShare_Click(object sender, EventArgs e)   //前进，通往“分享”
        {
            RPobject Share = new RPobject();
            Share.eng = this.lbEngCenter.Text;
            Share.cn = this.lbCnCenter.Text;
            ShareWF ToShare = new ShareWF();
            ToShare.TO_Pictrue(Share);
            ToShare.Show();
        }

        private void btToHome_Click(object sender, EventArgs e)    //必要的后退，也是明智的，返回主页
        {
            this.Close();
        }

        private void WordWF_KeyPress(object sender, KeyPressEventArgs e)    //按ESC退出程序
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }
    }
}
