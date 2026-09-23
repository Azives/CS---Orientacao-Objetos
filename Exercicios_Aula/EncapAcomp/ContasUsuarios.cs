using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulamentoExercicios
{
    public partial class ContasUsuarios : Form
    {
        public List<Conta> ListaContas = new List<Conta>();


        public ContasUsuarios()
        {
            InitializeComponent();
        }


        public void ApagaContas(List<Conta> Lista)
        {
            foreach (Conta C in Lista)
            {
                C.GravaConta(0, 0, 0);
            }
            Lista.Clear();
        }

        public void MostraContas(List<Conta> Lista)
        {

            lbxContas.Items.Clear();
            foreach(Conta C in ListaContas)
            {
                lbxContas.Items.Add(C.DadosConta());
                lbxContas.Items.Add("Saldo Disp: " + C.SaldoDisp() + "\t Limite: " + C.Limite);
                lbxContas.Items.Add("--------------------------------------");
            }
        }

        public void AddConta(List<Conta> Lista, int Numero, double Saldo, double Limite)
        {
            Conta NConta = new Conta(Numero, Saldo, Limite);
            NConta.GravaConta(Numero, Saldo, Limite);

            Lista.Add(NConta);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.AddConta(this.ListaContas, 1234, 1000,500);
            this.AddConta(this.ListaContas, 5678, 2000, 250);
            this.MostraContas(this.ListaContas);
        }

        private void btn_Contas_Click(object sender, EventArgs e)
        {
            this.MostraContas(this.ListaContas);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {            
            lbxContas.Items.Clear();
        }

        private void lbxContas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            this.ApagaContas(this.ListaContas);
            lbxContas.Items.Clear();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            this.AddConta(this.ListaContas, Convert.ToInt32(tb_Conta.Text), Convert.ToDouble(tb_Saldo.Text), Convert.ToDouble(tb_Limite.Text));
            this.MostraContas(this.ListaContas);
        }

        private void btn_Limite_Click(object sender, EventArgs e)
        {
            ListaContas[0].Limite = Convert.ToDouble(tb_Limite.Text);
        }
    }
}
