/*
 * Author: Matthew Schwartz
 * Class name: SailorsSoda.cs
 * Purpose: Get and set properties for a Sailor's Soda object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class SailorSoda
    {
        private Size drinkSize = new Size();
        /// <summary>
        /// Get the size and set the size
        /// </summary>
        public Size Size
        {
            get { return drinkSize; }
            set { drinkSize = value; }
        }

        private double price = 0;
        /// <summary>
        /// Gets price of the drink
        /// Sets price of the drink according to the size
        /// </summary>
        public double Price 
        {
            get { return price; }
            set
            {
                if (drinkSize == Size.Small)
                {
                    price = 1.42;
                }
                else if (drinkSize == Size.Medium)
                {
                    price = 1.74;
                }
                else
                {
                    price = 2.07;
                }
            }
        }

        private uint calories = 0;
        /// <summary>
        /// Gets the calories in a drink
        /// Sets the calories in a drink based on size
        /// </summary>
        public uint Calories
        {
            get { return calories; }
            set
            {
                if (drinkSize == Size.Small)
                {
                    calories = 117;
                }
                else if (drinkSize == Size.Medium)
                {
                    calories = 153;
                }
                else
                {
                    calories = 205;
                }
            }
        }

        /// <summary>
        /// Gets whether there is ice or not
        /// Sets whether we want ice or not
        /// Default is ice in
        /// </summary>
        private bool ice = true;
        public bool Ice
        {
            get { return ice; }
            set
            {
                if (!ice)
                {
                    specialInstructions.Add("Hold ice");
                }
                else
                {
                    specialInstructions.Remove("Hold ice");
                }
                ice = value;
            }
        }


        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// Gets any special instructions
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get { return new List<string>(specialInstructions); }
        }

        /// <summary>
        /// Overrides the ToString method to print the size and flavor
        /// </summary>
        /// <returns>Returns the size and flavor of the drink with the drink name</returns>
        public override string ToString()
        {
            return $"{drinkSize} {flavor} Sailor Soda";
        }
    }
}
