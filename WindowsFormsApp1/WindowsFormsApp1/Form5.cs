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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            MessageBox.Show("welcome");

            String[] arr = { "BCA", "MCA", "BBA", "MBA" };
            foreach (String s in arr)
            {
                comboBox1.Items.Add(s);
            }

            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                textBox1.Focus();
                MessageBox.Show("Enter Name");
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals(""))
            {
                textBox2.Focus();
                MessageBox.Show("Enter Roll Number");
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            Form6 frm=new Form6();
            frm.ShowDialog();
        }

       
    }
}
