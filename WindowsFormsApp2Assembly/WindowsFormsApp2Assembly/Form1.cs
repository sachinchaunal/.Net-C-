using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2Assembly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int adds(int x, int y) { 
            //private assembly
            return x + y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a=adds(1, 2);
            MessageBox.Show(a.ToString());
        }
    }
}
