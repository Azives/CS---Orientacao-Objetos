using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H67
{
    public partial class frm_Filho2 : Form
    {
        public frm_Filho2()
        {
            InitializeComponent();
        }

        private void btn_MostrarFilho1_Click(object sender, EventArgs e)
        {
            frm_Filho1 objChild = new frm_Filho1();
            objChild.MdiParent = this.MdiParent;
            objChild.Show();
        }
    }
}
