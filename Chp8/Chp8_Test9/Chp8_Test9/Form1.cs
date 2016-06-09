using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp8_Test9
{
    public partial class Form1 : Form
    {
        Dictionary<int, JerseyNumber> retiredNumbers = new Dictionary<int, JerseyNumber>(){
        
            {3, new JerseyNumber("babe",1948)},
            {4, new JerseyNumber("lou",1939)},
            {5, new JerseyNumber("joe",1952)},
            {7, new JerseyNumber("mickey",1969)},
            {8, new JerseyNumber("yogi",1972)},
            {10, new JerseyNumber("phil",1985)}
        };

        public Form1()
        {
            InitializeComponent();
            foreach (int key in retiredNumbers.Keys)
            {
                number.Items.Add(key);
            }
        }

        private void number_SelectedIndexChanged(object sender, EventArgs e)
        {
            JerseyNumber jerseyNumber = retiredNumbers[(int)number.SelectedItem];// as JerseyNumber;
            nameLabel.Text = jerseyNumber.Player;
            yearLabel.Text = jerseyNumber.YearRetired.ToString();
        }
    }
}
