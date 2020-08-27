/*
 * Author: Matthew Schwartz
 * Class name: WarriorWater.cs
 * Purpose: Get and set properties for a Warrior Water object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class WarriorWater
    {
        private Size drinkSize = new Size();
        private double price = 0;
        /// <summary>
        /// Gets price of the drink
        /// Sets price of the drink according to the size
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        private uint calories = 0;
        /// <summary>
        /// Gets the calories in a drink
        /// Sets the calories in a drink based on size
        /// </summary>
        public uint Calories
        {
            get { return calories; }
        }

        /// <summary>
        /// Gets whether there is ice or not
        /// Sets whether we want ice or not
        /// Default is ice
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


        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                if (!lemon)
                {
                    specialInstructions.Add("Add lemon");
                }
                else
                {
                    specialInstructions.Remove("Add lemon");
                }
                lemon = value;
            }
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
        /// Overrides the ToString method to print the size
        /// </summary>
        /// <returns>Returns the size and flavor of the drink with the drink name</returns>
        public override string ToString()
        {
            return $"{drinkSize} Warrior Water";
        }
    }
}
