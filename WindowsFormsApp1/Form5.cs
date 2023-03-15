using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.ValidateNames = true;
            ofd.Multiselect = false;
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                textBox2.Text=File.ReadAllText(ofd.FileName);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<decimal> nums = new List<decimal>();
            for (int i = 0; i < textBox2.Lines.Count(); ++i)
            {
                string[] line = textBox2.Lines[i].Split(new char[] { ' ' },
                                                        StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in line)
                {
                    nums.Add(decimal.Parse(s, NumberStyles.Number));
                }
            }

            foreach (decimal d in nums.OrderByDescending(x => x))
            {
                listBox1.Items.Add(d.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
