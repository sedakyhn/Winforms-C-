using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=0;

            for(i=1; i<=200; i++)
            {
                if (i > 100 && i % 15 == 0)
                {
                    listBox1.Items.Add("zagzig");
                }
                else if (i<=100 && i%15 == 0)
                {
                    listBox1.Items.Add("zigzag");
                }

                else if(i%3 ==0)
                {
                    listBox1.Items.Add("zig");
                }
                else if(i%5 ==0)
                {
                    listBox1.Items.Add("zag");
                }
                else
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
