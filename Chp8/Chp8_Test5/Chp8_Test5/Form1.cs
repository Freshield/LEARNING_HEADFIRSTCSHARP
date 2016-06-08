using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp8_Test5
{
    public partial class Form1 : Form
    {
        public List<Duck> ducks;
        public Form1()
        {
            InitializeComponent();
            ducks = new List<Duck>(){
                new Duck() { Kind = KindOfDuck.Decoy, Size = 17},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14}
            };
            PrintDucks(ducks);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DuckComparerBySize sizeComparer = new DuckComparerBySize();
            DuckComparerByKind kindComparer = new DuckComparerByKind();
            //ducks.Sort();
            //ducks.Sort(sizeComparer);
            ducks.Sort(kindComparer);
            PrintDucks(ducks);
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Size + " : " + duck.Kind.ToString());

            }
        }
    }
}
