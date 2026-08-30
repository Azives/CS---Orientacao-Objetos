using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H35
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            this.Left -= 2;
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            this.Left += 2;
        }

        private void btn_transftext_Click(object sender, EventArgs e)
        {
            tb_textreceptor.Text = tb_textemisor.Text;
        }

        private void tb_textreceptor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void tb_stackoverflow_TextChanged(object sender, EventArgs e)
        {
            tb_stackoverflow.Text = tb_stackoverflow.Text + 'a';
        }

        private void btn_mostrainf_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                for (int intIndex = 0; intIndex < this.Controls.Count; intIndex++)
                {
                    MessageBox.Show("Control #" + intIndex.ToString() + " Tem Nome " + this.Controls[intIndex].Name);
                    MessageBox.Show("Control #" + intIndex.ToString() + " Tem Altura " + this.Controls[intIndex].Height);
                }
            }
            else
            {
                for (int intIndex = 0; intIndex < this.Controls.Count; intIndex++)
                {
                    MessageBox.Show("Control #" + intIndex.ToString() + " Tem Altura " + this.Controls[intIndex].Height);
                }
            }
        }

        private void btn_mostrarbola_Click(object sender, EventArgs e)
        {
            Bola bola = new Bola();
            bola.Show();
        }

        private void btn_mostrarmanto_Click(object sender, EventArgs e)
        {
            Manto manto = new Manto();
            manto.Show();   
        }
    }
}
