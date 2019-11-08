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
        public WordWF()
        {
            InitializeComponent();
        }

        RPobject OB_Word = new RPobject(3);
        private void Word()
        {
            RPconnect CT_Word = new RPconnect(OB_Word);
            OB_Word = CT_Word.captureWord();
        }
        private void WordWF_Load(object sender, EventArgs e)
        {
            Word();
            this.lbEngCenter.Text = OB_Word.eng;
            this.lbCnCenter.Text = OB_Word.cn;
            Word();
            this.lbEngLeft.Text = OB_Word.eng;
            this.lbCnLeft.Text = OB_Word.cn;
            Word();
            this.lbEngRight.Text = OB_Word.eng;
            this.lbCnRight.Text = OB_Word.cn;
        }
        
        private void btToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WordWF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }

        private void btToShare_Click(object sender, EventArgs e)
        {
            ShareWF ToShare = new ShareWF();
            ToShare.Show();
        }
    }
}
