using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWinForm
{
    public partial class CollectWF : Form
    {
        public CollectWF()
        {
            InitializeComponent();
        }

        private void btToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CollectWF_KeyPress(object sender, KeyPressEventArgs e)
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
