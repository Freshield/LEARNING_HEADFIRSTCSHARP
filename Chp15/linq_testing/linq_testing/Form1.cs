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

            Random random = new Random();
            List<int> list = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
            {
                list.Add(random.Next(100));
            }

            Console.WriteLine("There are {0} numbers", list.Count());
            Console.WriteLine("The smallest is {0}", list.Min());
            Console.WriteLine("The biggest is {0}", list.Max());
            Console.WriteLine("The sum is {0}", list.Sum());
            Console.WriteLine("The average is {0:F2}", list.Average());
             
        }
    }
}
