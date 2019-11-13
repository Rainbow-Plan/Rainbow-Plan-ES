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
    public partial class CollectWF : Form
    {
        //收藏页：进则藏其所好，分之所享，退则另择其选
        public CollectWF()
        {
            InitializeComponent();
            DataToFill();
        }

        int I = 0;//收录计数
        RPobject Record = new RPobject(31);//用于收录数据传递的对象
        RPconnect RcConnect = null;
        public void DataToFill()
        {
            RcConnect = new RPconnect(Record);
            Record = RcConnect.captureCollect();
            I = int.Parse(Record.id);//记录当前最后一条记录id
            this.lbRecord1.Text = Record.cn;
            Record = RcConnect.captureCollect();
            this.lbRecord2.Text = Record.cn;
            Record = RcConnect.captureCollect();
            this.lbRecord3.Text = Record.cn;
        }

        private void btPreserve_Click(object sender, EventArgs e)       //所喜之语，应以录之
        {
            I++;//id编号加一
            Record.id = I.ToString();
            Record.cn = this.rtxCollect.Text;
            RcConnect = new RPconnect(Record);
            int True_F = RcConnect.ToRecordSave();
            if(True_F==1)
            {
                MessageBox.Show("保存成功","保存", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataToFill();//刷新记录显示
            }
            else
            {
                MessageBox.Show("保存失败", "保存", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btToShare_Click(object sender, EventArgs e)       //独乐乐不如众乐乐，喜欢值得分享
        {
            RPobject Share = new RPobject(32);
            Share.eng = null;
            Share.cn = this.rtxCollect.Text;
            ShareWF ToShare = new ShareWF();
            ToShare.TO_Pictrue(Share);
            ToShare.Show();
        }

        private void btToHome_Click(object sender, EventArgs e)     //或许退一步，回去记记单词也不错
        {
            this.Close();
        }

        private void CollectWF_KeyPress(object sender, KeyPressEventArgs e)   //按ESC确实很简单快捷
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }

    }
}
