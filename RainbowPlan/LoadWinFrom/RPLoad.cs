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
        public LoadWF()
        {
            InitializeComponent();
        }
        RPobject OB_Load = new RPobject(1);
        private void Load_Word()
        {
            RPconnect CT_Load = new RPconnect(OB_Load);
            OB_Load = CT_Load.captureWord();
        }

        private void LoadWF_Load(object sender, EventArgs e)
        {
            Load_Word();
            this.lbEnglish.Text = OB_Load.eng;
            this.lbChanese.Text = OB_Load.cn;
        }

        private void LoadWF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }

        private void btToHome_Click(object sender, EventArgs e)
        {
            HomeWF ToHome = new HomeWF();
            ToHome.Show();
            this.Hide();
            
        }
    }
}
