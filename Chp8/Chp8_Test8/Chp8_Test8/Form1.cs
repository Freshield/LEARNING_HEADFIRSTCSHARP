using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp8_Test8
{
    public partial class Form1 : Form
    {
        Card cardToCheck;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cardToCheck = new Card(3, Kind.Ace);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Kind.Four);
            MessageBox.Show(doesItMatch.ToString());
        }
    }
}
