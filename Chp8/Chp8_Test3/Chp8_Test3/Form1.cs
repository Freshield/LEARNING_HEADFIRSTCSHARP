using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp8_Test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Shoe> shoeCloset = new List<Shoe>();

            shoeCloset.Add(new Shoe() { Style = Style.sneakers, Color = "black"});
            shoeCloset.Add(new Shoe() { Style = Style.clogs, Color = "brown" });
            shoeCloset.Add(new Shoe() { Style = Style.wingtips, Color = "black" });
            shoeCloset.Add(new Shoe() { Style = Style.loafers, Color = "whilte" });
            shoeCloset.Add(new Shoe() { Style = Style.sneakers, Color = "green" });

            int numberOfShoes = shoeCloset.Count;
            foreach (Shoe shoe in shoeCloset)
            {
                shoe.Style = Style.flipflops;
                shoe.Color = "orange";
            }

            shoeCloset.RemoveAt(4);

            Shoe thirdShoe = shoeCloset[3];
            Shoe secondShoe = shoeCloset[2];
            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);
            if (shoeCloset.Contains(secondShoe))
            {
                MessageBox.Show("That's surprising.");
            }
        }
    }
}
