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
    public partial class Form2 : Form
    {
        public Form2()
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
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
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

        int num1;
        int num2;
        int estado = 0;

        private void mais_Click(object sender, EventArgs e)
        {
            if(estado == 0)
            {
                num1 = int.Parse(NumInser.Text);
                NumInser.Text = "";
                estado = 1;
            }
            else
            {
                num2 = int.Parse(NumInser.Text);
                NumInser.Text = (num1 / num2).ToString();
                estado = 0;
            }
        }

        private void menos_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                num1 = int.Parse(NumInser.Text);
                NumInser.Text = "";
                estado = 1;
            }
            else
            {
                num2 = int.Parse(NumInser.Text);
                NumInser.Text = (num1 - num2).ToString();
                estado = 0;
            }
        }

        private void vezes_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                num1 = int.Parse(NumInser.Text);
                NumInser.Text = "";
                estado = 1;
            }
            else
            {
                num2 = int.Parse(NumInser.Text);
                NumInser.Text = (num1 * num2).ToString();
                estado = 0;
            }
        }

        private void dividir_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string text = NumInser.Text;
            int tamanho = text.Length;
            text = text.Remove((tamanho-1), 1);
            NumInser.Text = text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
