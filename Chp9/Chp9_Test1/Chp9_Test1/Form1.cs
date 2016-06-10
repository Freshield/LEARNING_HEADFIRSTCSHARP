using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Chp9_Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"D:\MEGA\LEARN_BYSELF\C#\LEARNING_HEADFIRSTCSHARP\Chp9\secret_plan.txt");
            sw.WriteLine("How I'll defeat Captain Amazing");
            sw.WriteLine("unleash them upon the citizens of Objectville.");
            string location = "the mall";
            for (int i = 0; i < 6; i++)
            {
                sw.WriteLine("Clone #{0} attacks {1}", i, location);
                if (location == "the mall")
                {
                    location = "downtown";
                }
                else
                {
                    location = "the mall";
                }
            }
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"D:\MEGA\LEARN_BYSELF\C#\LEARNING_HEADFIRSTCSHARP\Chp9\secret_plan.txt");
            while (!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                Console.WriteLine(lineFromThePlan);
            }
            reader.Close();
        }
    }
}
