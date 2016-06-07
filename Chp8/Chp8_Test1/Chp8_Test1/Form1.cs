using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp8_Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum TrickScore
        {
            sit = 7,
            beg = 25,
            rollover = 50,
            fetch = 10,
            comehere = 5,
            speak = 30
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = (int)TrickScore.fetch * 3;
            TrickScore score = (TrickScore)value;
            MessageBox.Show(value.ToString() + score.ToString());
        }
    }
}
