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

        private void button2_Click(object sender, EventArgs e)
        {
            int a=0, b=1, c, i, sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            label1.Text = a + " " + b + " ";
            for(i=2; i<sayi; i++)
            {
                c = a + b;
                a = b;
                b = c;
                label1.Text = c + " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            label1.Text = " ";
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
