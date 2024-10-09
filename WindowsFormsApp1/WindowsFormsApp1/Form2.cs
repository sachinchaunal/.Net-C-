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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=1.ToString();
            textBox2.Text = 2.ToString();
            textBox3.Text = 3.ToString();
            textBox4.Text = 4.ToString();
            textBox5.Text = 5.ToString();
            textBox6.Text = 6.ToString();
            textBox7.Text = 7.ToString();
            textBox8.Text = 8.ToString();
            textBox9.Text = 9.ToString();
            textBox10.Text = 10.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
            textBox2.Text = (int.Parse(textBox2.Text) + 1).ToString();
            textBox3.Text = (int.Parse(textBox3.Text) + 1).ToString();
            textBox4.Text = (int.Parse(textBox4.Text) + 1).ToString();
            textBox5.Text = (int.Parse(textBox5.Text) + 1).ToString();
            textBox6.Text = (int.Parse(textBox6.Text) + 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) + 1).ToString();
            textBox8.Text = (int.Parse(textBox8.Text) + 1).ToString();
            textBox9.Text = (int.Parse(textBox9.Text) + 1).ToString();
            textBox10.Text = (int.Parse(textBox10.Text) + 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = (int.Parse(textBox2.Text) - 1).ToString();
            textBox3.Text = (int.Parse(textBox3.Text) - 1).ToString();
            textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
            textBox4.Text = (int.Parse(textBox4.Text) - 1).ToString();
            textBox5.Text = (int.Parse(textBox5.Text) - 1).ToString();
            textBox6.Text = (int.Parse(textBox6.Text) - 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) - 1).ToString();
            textBox8.Text = (int.Parse(textBox8.Text) - 1).ToString();
            textBox9.Text = (int.Parse(textBox9.Text) - 1).ToString();
            textBox10.Text = (int.Parse(textBox10.Text) -1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
