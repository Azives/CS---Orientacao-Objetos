using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H4B
{
    public partial class H4B : Form
    {
        public H4B()
        {
            InitializeComponent();
        }

        private void tb_t1_TextChanged(object sender, EventArgs e)
        {
            tb_t1.Text = tb_t1.Text + "a";
        }
    }
}
