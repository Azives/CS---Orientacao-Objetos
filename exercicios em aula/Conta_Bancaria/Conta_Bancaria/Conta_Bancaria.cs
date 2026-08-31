namespace Conta_Bancaria
{
    public partial class Conta_Bancaria : Form
    {
        Contas Conta;
        public Conta_Bancaria()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncriarconta_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "" || txtsaldo.Text == "" || txtlimite.Text == "")
            {
                MessageBox.Show("Porfavor informe os valores");
            }
            else
            {
                Conta = new Contas(txtnome.Text, double.Parse(txtsaldo.Text), double.Parse(txtlimite.Text));
                txtnome.ReadOnly = true;
                txtsaldo.ReadOnly = true;
                txtlimite.ReadOnly = true;

                MessageBox.Show("Conta criada com sucesso");
            }
        }

        private void btnsacar_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                MessageBox.Show("Porfavor informe o valor da operação");
            }
            else
            {
                Conta.Saca(double.Parse(txtvalor.Text));
                txtvalor.Text = "";
                txtvalor.Text = Conta.Consulta().ToString();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndepositar_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "")
            {
                MessageBox.Show("Porfavor informe o valor da operação");
            }
            else
            {
                Conta.Deposita(double.Parse(txtvalor.Text));
                txtvalor.Text = "";
                txtvalor.Text = Conta.Consulta().ToString();

            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo atual: "+Conta.Consulta().ToString());
        }
    }
}
