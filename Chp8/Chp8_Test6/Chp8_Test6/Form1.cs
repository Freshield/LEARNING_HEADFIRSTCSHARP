using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp8_Test6
{
    public partial class Form1 : Form
    {
        List<Card> cards;
        public Form1()
        {
            InitializeComponent();
            cards = new List<Card>();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card() { kind = (Kind)random.Next(1, 4), number = random.Next(1, 14) });
                Console.WriteLine(cards[i]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Sort");
            cards.Sort(new CardComparerByValue());
            
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}
