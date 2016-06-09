using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp8_Test10
{
    
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RedrawList()
        {
            int number = 1;
            lines.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                lines.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (breakfastLine.Count == 0)
            {
                feed.Enabled = false;
                message.Text = "";
            }
            else
            {
                feed.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                message.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapjackCount + " flapjacks";

            }
        }

        private void addFood_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (crispy.Checked == true)
            {
                food = Flapjack.Crispy;
            }
            else if (soggy.Checked == true)
            {
                food = Flapjack.Soggy;
            }
            else if (browried.Checked == true)
            {
                food = Flapjack.Browned;
            }
            else
            {
                food = Flapjack.Banana;
            }

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            RedrawList();
        }

        private void add_Click(object sender, EventArgs e)
        {
            breakfastLine.Enqueue(new Lumberjack(name.Text));
            name.Text = "";
            RedrawList();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            message.Text = "";
            RedrawList();
        }
    }
}
