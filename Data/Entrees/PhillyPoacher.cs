/*
 * Author: Matthew Schwartz
 * Class name: PhillyPoacher.cs
 * Purpose: Get and set properties for a Philly Poacher object
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class PhillyPoacher
    {
        private double price = 7.23;
        private uint calories = 784; // Uint is unsigned integer (calories can't be negative)

        /// <summary>
        /// Gets the price of the sandwich
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the number of calories
        /// </summary>
        public uint Calories
        {
            get { return calories; }
        }

        /// <summary>
        /// Gets whether there is sirloin or not
        /// Sets whether we want sirloin or not
        /// Default is sirloin on
        /// </summary>
        private bool sirloin = true;
        public bool Sirloin
        {
            get { return sirloin; }
            set
            {
                if (!sirloin)
                {
                    specialInstructions.Add("Hold sirloin");
                }
                else
                {
                    specialInstructions.Remove("Hold sirloin");
                }
                sirloin = value;
            }
        }

        /// <summary>
        /// Gets whether there is onion or not
        /// Sets whether we want onion or not
        /// Default is onion on
        /// </summary>
        private bool onion = true;
        public bool Onion
        {
            get { return onion; }
            set
            {
                if (!onion)
                {
                    specialInstructions.Add("Hold onions");
                }
                else
                {
                    specialInstructions.Remove("Hold onions");
                }
                onion = value;
            }
        }

        /// <summary>
        /// Gets whether there is a roll or not
        /// Sets whether we want a roll or not
        /// Default is roll on
        /// </summary>
        private bool roll = true;
        public bool Roll
        {
            get { return roll; }
            set
            {
                if (!roll)
                {
                    specialInstructions.Add("Hold roll");
                }
                else
                {
                    specialInstructions.Remove("Hold roll");
                }
                roll = value;
            }
        }

        /// <summary>
        /// Gets any special instructions in cooking the sandwich
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get { return new List<string>(specialInstructions); }
        }

        /// <summary>
        /// Overrides the ToString method to print the item name
        /// </summary>
        /// <returns>Returns a string containing the item name</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
