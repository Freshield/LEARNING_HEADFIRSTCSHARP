using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp11_Test3
{
    public partial class Form1 : Form
    {
        ConvertsIntToString someMethod = new ConvertsIntToString(HiThere);
        

        public Form1()
        {
            InitializeComponent();
        }

        public static string HiThere(int i)
        {
            return "Hi there! #" + (i * 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = someMethod(5);
            Console.WriteLine(message);
        }
    }
}
