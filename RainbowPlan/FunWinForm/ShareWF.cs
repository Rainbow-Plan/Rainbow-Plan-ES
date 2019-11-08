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
    public partial class ShareWF : Form
    {
        public ShareWF()
        {
            InitializeComponent();
        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShareWF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }
    }
}
