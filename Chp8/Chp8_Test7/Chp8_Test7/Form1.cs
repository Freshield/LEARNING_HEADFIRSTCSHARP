using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp8_Test7
{
    public partial class Form1 : Form
    {
        List<Duck> ducks;
        List<Bird> birds;
        public Form1()
        {
            InitializeComponent();
            ducks = new List<Duck>(){
                new Duck() { Kind = KindOfDuck.Decoy, Size = 17, Name = "duck1"},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18, Name = "duck2"},
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14, Name = "duck3"}
            };
            IEnumerable<Bird> upcastDucks = ducks;

            birds = new List<Bird>(){
                new Bird(){ Name = "Feathers"}
            };
            birds.AddRange(upcastDucks);
            birds.Add(new Penguin() { Name = "George" });
            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
