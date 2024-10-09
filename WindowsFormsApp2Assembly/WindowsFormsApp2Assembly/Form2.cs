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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Class1 class1 = new Class1();
        private void button1_Click(object sender, EventArgs e)
        {
            int b=class1.multi(2, 2);
            MessageBox.Show(b.ToString());
        }
    }
}
