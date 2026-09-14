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
    public partial class frm_Filho1 : Form
    {
        public frm_Filho1()
        {
            InitializeComponent();
        }

        private void btn_MostrarFilho2_Click(object sender, EventArgs e)
        {
            frm_Filho2 objChild = new frm_Filho2();
            objChild.MdiParent = this.MdiParent;
            objChild.Show();
        }

        private void btn_PassarLista_Click(object sender, EventArgs e)
        {
            if (ltb_lista1.SelectedItem != null)
            {

                ltb_lista2.Items.Add(ltb_lista1.SelectedItem);

                ltb_lista1.Items.Remove(ltb_lista1.SelectedItem);
            }
        }
    }
}
