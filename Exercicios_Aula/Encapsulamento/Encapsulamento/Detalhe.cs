using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class w_Detalhe: Form
    {
        Livro L;
        public w_Detalhe()
        {
            InitializeComponent();
        }

        public w_Detalhe(Livro Liv):this()
        {
            this.L = Liv;         
        }

        private void w_Detalhe_Load(object sender, EventArgs e)
        {
            tb_codigo.Text = L.codigo.ToString();
            tb_Titulo.Text = L.Titulo;
            tb_Ano.Text = L.Ano;
        }

        public void btn_OK_Click(object sender, EventArgs e)
        {
            L.Titulo = tb_Titulo.Text;
            L.Ano = tb_Ano.Text;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
