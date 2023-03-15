using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox1.Text) > 15)
                {
                    MessageBox.Show("1 ile 15 arasında bir tamsayı değeri giriniz!");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Tekrar deneyiniz!");
                textBox1.Text = "";
                textBox1.Focus();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, num;
            num = Convert.ToInt32(textBox1.Text);
            
            

            for (j = 0; j <= num; j++)
            {
                textBox2.Text += j.ToString() + "\t";

            }
            textBox2.Text += "\t" + String.Join("\n", Environment.NewLine + new string('\n', 0));

            for (i = 1; i <= num; i++)
            {
                textBox2.Text += i.ToString() + "\t";


                for (j = 1; j <= num; j++)
                {
                    textBox2.Text += (i * j).ToString() + "\t";
                }
                textBox2.Text += Environment.NewLine;
            }

        }
    }
}
