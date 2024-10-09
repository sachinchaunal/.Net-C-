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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s1 = textBox1.Text.ToString();
            String s2 = textBox2.Text.ToString();

            s1=s1+s2;
            s2=s1.Substring(0, s1.Length-s2.Length);
            s1 = s1.Substring(s2.Length);

            textBox1.Text= s1;
            textBox2.Text= s2;
        }
    }
}
