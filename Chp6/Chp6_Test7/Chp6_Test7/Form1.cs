using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp6_Test7
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacting" },175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby Bee Tutoring" },114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol"},149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacting",
                "Egg care","Hive maintenance","Baby Bee Tutoring","Sting patrol" },155);
            queen = new Queen(workers);
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shift.Value) == false)
            {
                MessageBox.Show("No workers are available to do the job '" +
                    workerBeeJob.Text + "'", "The queen bee says...");
            }
            else
            {
                MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in "
                    + shift.Value + " shifts", "The queen bee says...");
            }
        }

        private void shift_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }






    }
}
