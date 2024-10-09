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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        ClassLibrary1Assemly.Class2 abc=new ClassLibrary1Assemly.Class2();
        private void button1_Click(object sender, EventArgs e)
        {
            int p=abc.subt(1, 1);
            MessageBox.Show(p.ToString());
        }
    }
}
