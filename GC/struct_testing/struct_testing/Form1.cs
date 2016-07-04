using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace struct_testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Canine spot = new Canine("Spot", "pug");
            Canine bob = spot;
            bob.Name = "Spike";
            bob.Breed = "beagle";
            spot.Speak();

            Dog jake = new Dog("Jake", "poodle");
            Dog betty = jake;
            betty.Name = "Betty";
            betty.Breed = "pit bull";
            jake.Speak();

        }
    }
}
