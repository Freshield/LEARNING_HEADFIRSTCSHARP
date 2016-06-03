using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test2
{
    public partial class Form1 : Form
    {
        double milesTraveled;
        double reimburseRate = 0.39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (startMile.Value >= endMile.Value)
            {
                MessageBox.Show("The atarting mileage must be less than th ending mileage","Cannot Calculate");
            }
            else
            {
                milesTraveled = (double)(endMile.Value - startMile.Value);
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
        }

    }
}
