using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void circunfer_Click(object sender, EventArgs e)
        {
            Form6 form6 = new();
            form6.Show();
            this.Hide();
        }

        private void aceler_Click(object sender, EventArgs e)
        {
            Form7 form7 = new();
            form7.Show();
            this.Hide();
        }

        private void potenciar_Click(object sender, EventArgs e)
        {
            Form8 form8 = new();
            form8.Show();
            this.Hide();
        }

        private void volt_Click(object sender, EventArgs e)
        {
            Form1 form1 = new();
            form1.Show();
            this.Hide();
        }
    }
}
