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
    public partial class Form4 : Form
    {
        private Stack<string> s1 = new Stack<string>();
        
        public Form4()
        {
            InitializeComponent();
        }
        String[] arr = { "hi", "kasa", "ho" };
        private int currentIndex = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(arr.Length > currentIndex)
            {
            s1.Push(arr[currentIndex]);
            currentIndex++;
            UpdateListBox();
            }
            else
            {
                MessageBox.Show("All items have been pushed to the stack!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (s1.Count > 0)
            {
                MessageBox.Show(s1.Pop());
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Stack is empty!");
            }
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (string item in s1.Reverse())
            {
                listBox1.Items.Add(item);
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            Form5 frn= new Form5();
            frn.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}