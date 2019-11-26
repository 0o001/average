using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace average
{
    public partial class usr_lesson : UserControl
    {
        public usr_lesson()
        {
            InitializeComponent();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_average_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            e.Handled = true;
        }
    }
}
