using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_b1_Click(object sender, EventArgs e)
        {
            tb_t2.Text = tb_t1.Text;
        }

        private void tb_t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_t2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
