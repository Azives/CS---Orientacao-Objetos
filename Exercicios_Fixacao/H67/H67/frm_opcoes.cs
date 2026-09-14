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
    public partial class frm_opcoes : Form
    {
        public frm_opcoes()
        {
            InitializeComponent();
        }

        private void tb_NomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (chk_PronptSair.Checked)
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if(chk_PronptSair.Checked)
            this.Close();

        }
    }
}
