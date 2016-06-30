using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace linq_testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            var result = from v in values
                         where v < 37
                         orderby v
                         select v + 1;
            foreach (int i in result)
            {
                Console.WriteLine("{0} ", i);

            }

            string[] words = new string[] { "a", "b", "c" };
            var results = from word in words
                          select word + " 233 ";
            foreach (var i in results)
            {
                Console.WriteLine(i);
            }
             
        }
    }
}
