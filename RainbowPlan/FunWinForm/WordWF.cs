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

        public WordWF()
        {
            InitializeComponent();
        }

        public RPobject OB_Word = new RPobject(3);//单词页用于命令和数据传递的对象

        public void Word()
        {
            RPconnect CT_Word = new RPconnect(OB_Word);
            OB_Word = CT_Word.captureWord();
            WordQueue(OB_Word);

        }

        public int I = 0;  //单词计数
        public RPobject[] Word_Queue = new RPobject[10];  //使用对象队列存储,大小为6

        public void WordQueue(RPobject OB_Word)   //进队，出队调整
        {

            if (I <= 9)
            {
                Word_Queue[I] = new RPobject(10);
                Word_Queue[I].id = OB_Word.id;
                Word_Queue[I].eng = OB_Word.eng;
                Word_Queue[I].cn = OB_Word.cn;
                I++;
            }
            else
            {
                for (int i = 0; i < 9; i++ )
                {
                    Word_Queue[i].id = Word_Queue[i+1].id;
                    Word_Queue[i].eng = Word_Queue[i + 1].eng;
                    Word_Queue[i].cn = Word_Queue[i + 1].cn;
                }
                Word_Queue[9].id = OB_Word.id;
                Word_Queue[9].eng = OB_Word.eng;
                Word_Queue[9].cn = OB_Word.cn;
            }
        }
        
        private void WordWF_Load(object sender, EventArgs e)//获取数据填到窗体文本框
        {
            for (int i = 1; i <= 10; i++)//填充满整个单词队列
            {
                Word();
            }
            //填充到窗体文本框
            this.lbEngLeft.Text = Word_Queue[0].eng;
            this.lbCnLeft.Text = Word_Queue[0].cn;

            this.lbEngCenter.Text = Word_Queue[1].eng;
            this.lbCnCenter.Text = Word_Queue[1].cn;

            this.lbEngRight.Text = Word_Queue[2].eng;
            this.lbCnRight.Text = Word_Queue[2].cn;

        }

        int L_R = 0;//判断左右滑动的次数
        //右滑，下一个单词
        private void btToRight_Click(object sender, EventArgs e)
        {
            this.lbEngLeft.Text = this.lbEngCenter.Text;
            this.lbCnLeft.Text = this.lbCnCenter.Text;
            this.lbEngCenter.Text = this.lbEngRight.Text;
            this.lbCnCenter.Text = this.lbCnRight.Text;
            if (L_R < 0)
            {
                this.lbEngRight.Text = Word_Queue[2].eng;
                this.lbCnRight.Text = Word_Queue[2].cn;
                L_R = 0;
            }
            else if (L_R >= 0 && L_R < 7)
            {
                this.lbEngRight.Text = Word_Queue[L_R + 3].eng;
                this.lbCnRight.Text = Word_Queue[L_R + 3].cn;
                L_R++;
            }
            else if (L_R >= 7)
            {
                Word();
                this.lbEngRight.Text = Word_Queue[9].eng;
                this.lbCnRight.Text = Word_Queue[9].cn;
            }

        }

        //左滑，上一个单词
        private void btToLeft_Click(object sender, EventArgs e)
        {
            if (L_R > 0)
            {
                this.lbEngRight.Text = this.lbEngCenter.Text;
                this.lbCnRight.Text = this.lbCnCenter.Text;
                this.lbEngCenter.Text = this.lbEngLeft.Text;
                this.lbCnCenter.Text = this.lbCnLeft.Text;
                this.lbEngLeft.Text = Word_Queue[L_R-1].eng;
                this.lbCnLeft.Text = Word_Queue[L_R-1].cn;
                L_R--;
            }
            else if (L_R == 0)
            {
                this.lbEngRight.Text = this.lbEngCenter.Text;
                this.lbCnRight.Text = this.lbCnCenter.Text;
                this.lbEngCenter.Text = this.lbEngLeft.Text;
                this.lbCnCenter.Text = this.lbCnLeft.Text;
                this.lbEngLeft.Text = "无";
                this.lbCnLeft.Text = "无";
                L_R--;
            }
            else
            {
                MessageBox.Show("没有更早的数据啦！");

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
