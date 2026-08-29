using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace H3B
{
    public partial class CollectionsExampleForm : Form
    {
        public CollectionsExampleForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowNames_Click(object sender, EventArgs e)
        {
            for (int intIndex = 0; intIndex < this.Controls.Count;
            intIndex++)
            {
                MessageBox.Show("Control #" + intIndex.ToString() + " Tem o Nome " +this.Controls[intIndex].Name);
                MessageBox.Show("Control #" + intIndex.ToString() + " Tem a Altura " + this.Controls[intIndex].Height);
            }
        }

        private void tb_t1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
