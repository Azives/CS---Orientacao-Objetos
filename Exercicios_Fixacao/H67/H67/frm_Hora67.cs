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
    public partial class frm_Hora67 : Form
    {
        public frm_Hora67()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_opcoes opt = new frm_opcoes();
            opt.Show();
        }

        private void Hora67_Load(object sender, EventArgs e)
        {
            frm_Filho2 objFilho = new frm_Filho2(); objFilho.MdiParent = this;
            objFilho.Show();
        }
    }
}
