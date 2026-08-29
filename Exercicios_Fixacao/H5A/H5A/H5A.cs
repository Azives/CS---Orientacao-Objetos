using System;
using System.Drawing;
using System.Windows.Forms;

namespace H5A
{
    public partial class H5A : Form
    {
        public H5A()
        {
            InitializeComponent();
        }

        private void H5A_Load(object sender, EventArgs e)
        {
            btn_b1.ForeColor = Color.White;
            btn_b2.ForeColor = Color.White;
        }

        private void btn_b1_Click(object sender, EventArgs e)
        {
            this.Left += 2;
        }

        private void btn_b2_Click(object sender, EventArgs e)
        {
            this.Left -= 2;
        }
    }
}