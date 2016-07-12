using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LAST_POOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Line[] lines = 
            {
                new Line(new string[] {"eating","carrots,","but","enjoy","horses"},1),
                new Line(new string[] {"zebras?","hay,","cows","bridge.","bolted"},2),
                new Line(new string[] {"fork","dogs!,","engine","and"},3),
                new Line(new string[] {"love","they,","apples","eating"},2),
                new Line(new string[] {"whistled.","bump,"},1)

            };

            var words =
                from line in lines
                group line by line.Value
                    into wordGroups
                    orderby wordGroups.Key
                    select wordGroups;

            var twoGroups = words.Take(2);

            foreach (var group in twoGroups)
            {
                int i = 0;
                foreach (var inner in group)
                {
                    i++;
                    if (i == group.Key)
                    {
                        var poem =
                            from word in inner.Words
                            orderby word descending
                            select word + " ";
                        foreach (var word in poem)
                        {
                            Console.Write(word);
                        }
                    }
                }
            }

        }
    }
}
