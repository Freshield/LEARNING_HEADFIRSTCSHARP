using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp10_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("1");
                int[] a = new int[3];
                a[5] = 10;
                Console.WriteLine("1.5");
            }
            catch (Exception ex)
            {
                Console.WriteLine("2");
                Console.WriteLine(ex.Message + " : " + ex.StackTrace);
            }
            Console.WriteLine("3");
        }
    }
}
