namespace TRABALHO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void aceler_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            form2.Show();
            this.Hide();
        }

        private void circunfer_Click(object sender, EventArgs e)
        {
            Form4 form4 = new();
            form4.Show();
            this.Hide();
        }

        private void potenciar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new();
            form3.Show();
            this.Hide();
        }

        private void tutor_Click(object sender, EventArgs e)
        {
            Form5 form5 = new();
            form5.Show();
            this.Hide();
        }
    }
}