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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void volt_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bot9_Click(object sender, EventArgs e)
        {
            string numero = NumInser.Text;
            NumInser.Text = numero + 9;
        }

        private void bot8_Click(object sender, EventArgs e)
        {
            string numero = NumInser.Text;
            NumInser.Text = numero + 8;
        }

        private void bot7_Click(object sender, EventArgs e)
        {
            string numero = NumInser.Text;
            NumInser.Text = numero + 7;
        }

        private void bot6_Click(object sender, EventArgs e)
        {
            string numero = NumInser.Text;
            NumInser.Text = numero + 6;
        }

        private void bot5_Click(object sender, EventArgs e)
        {
            string numero = NumInser.Text;
            NumInser.Text = numero + 5;
        }

        private void bot4_Click(object sender, EventArgs e)
        {
            string numero = NumInser.Text;
            NumInser.Text = numero + 4;
        }

        private void bot3_Click(object sender, EventArgs e)
        {
            string numero = NumInser.Text;
            NumInser.Text = numero + 3;
        }

        private void bot2_Click(object sender, EventArgs e)
        {
            string numero = NumInser.Text;
            NumInser.Text = numero + 2;
        }

        private void bot1_Click(object sender, EventArgs e)
        {
            string numero = NumInser.Text;
            NumInser.Text = numero + 1;
        }

        private void bot0_Click(object sender, EventArgs e)
        {
            string numero = NumInser.Text;
            NumInser.Text = numero + 0;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string text = NumInser.Text;
            int tamanho = text.Length;
            text = text.Remove((tamanho - 1), 1);
            NumInser.Text = text;
        }

        private void eleva4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(NumInser.Text);
            NumInser.Text = Math.Pow(num1, 4).ToString();
        }

        int num1;
        int num2;
        int estado = 0;
        private void igual_Click(object sender, EventArgs e)
        {

                num1 = int.Parse(NumInser.Text);
                NumInser.Text = (num1 * num1).ToString();
                estado = 1;
        }

        private void eleva3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(NumInser.Text);
            NumInser.Text = Math.Pow(num1, 3).ToString();
        }

        private void eleva2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(NumInser.Text);
            NumInser.Text = Math.Pow(num1, 2).ToString();
        }
    }
}
