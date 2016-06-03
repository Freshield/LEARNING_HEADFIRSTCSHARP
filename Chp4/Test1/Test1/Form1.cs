using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal myDecimalValue = 10;
            int myIntValue = (int)myDecimalValue;

            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            string myString = "false";
            myString = myInt.ToString();
            short myShort = (short)myInt;
            char myChar = 'x';
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte + myDouble + myChar;


            MessageBox.Show("The myIntValue is"+myString);
        }
    }
}
