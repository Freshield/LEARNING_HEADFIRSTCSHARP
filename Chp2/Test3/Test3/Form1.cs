using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (label1.BackColor == Color.White)
                {
                    label1.BackColor = Color.Red;
                }
                else
                {
                    label1.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("The box is not checked");
            }
        }
    }
}
