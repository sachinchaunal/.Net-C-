using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text + 1.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + 5.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text + 4.ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " * ";
        }
        private void div_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " / ";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " - ";
        }

        private void add_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " + ";
        }

        private void answer_Click(object sender, EventArgs e)
        {
            String n1 = textBox1.Text.Split(' ')[0];
            String op = textBox1.Text.Split(' ')[1];
            String n2 = textBox1.Text.Split(' ')[2];

            int result = 0;

            int num1 = int.Parse(n1);
            int num2 = int.Parse(n2);


            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Can not divide with 0");
                        break;
                    }
                    else
                    {
                        result = num1 / num2;
                        break;
                    }
                default:
                    MessageBox.Show("Unknown operator");
                    break;
            }

            textBox1.Text = result.ToString();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            Form4 frm=new Form4();
            frm.ShowDialog();
        }
    }
}
