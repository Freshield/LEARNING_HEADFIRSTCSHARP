using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chp6_Test5
{
    class BirthdayParty : Party
    {
        public int CakeSize;


        string cakeWriting;
        public string CakeWriting
        {
            get
            {
                return this.cakeWriting;
            }
            set
            {
                int maxLength;
                if (CakeSize == 8)
                {
                    maxLength = 16;
                }
                else
                {
                    maxLength = 40;
                }

                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + " inch cake");

                    if (maxLength > this.cakeWriting.Length)
                    {
                        maxLength = this.cakeWriting.Length;
                    }
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                {
                    this.cakeWriting = value;
                }
            }
        }


        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
            : base(numberOfPeople, fancyDecorations)
        {
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
            {
                CakeSize = 8;
            }
            else
            {
                CakeSize = 16;
            }
        }


        public override decimal CaluculateCost()
        {
            decimal CakeCost;
            if (CakeSize == 8)
            {
                CakeCost = 40 + CakeWriting.Length * 0.25m;
            }
            else
            {
                CakeCost = 75 + CakeWriting.Length * 0.25m;
            }

            return base.CalculateCost() + CakeCost;
        }

        public override int NumberOfPeople
        {
            get
            {
                return base.NumberOfPeople;
            }

            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }
    }

}
