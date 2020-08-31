/*
 * Author: Matthew Schwartz
 * Class name: AretineAppleJuice.cs
 * Purpose: Get and set properties for a Arentino Apple Juice object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class ArentinoAppleJuice
    {
        private Size drinkSize = new Size();
        private double price = 0;

        /// <summary>
        /// Get the size and set the size
        /// </summary>
        public Size Size
        {
            get { return drinkSize; }
            set { drinkSize = value; }
        }

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
                    price = 0.62;
                }
                else if (drinkSize == Size.Medium)
                {
                    price = 0.87;
                }
                else
                {
                    price = 1.01;
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
                    calories = 44;
                }
                else if (drinkSize == Size.Medium)
                {
                    calories = 88;
                }
                else
                {
                    calories = 132;
                }
            }
        }

        /// <summary>
        /// Gets whether there is ice or not
        /// Sets whether we want ice or not
        /// Default is no ice
        /// </summary>
        private bool ice = false;
        public bool Ice
        {
            get { return ice; }
            set
            {
                if (!ice)
                {
                    specialInstructions.Add("Add ice");
                }
                else
                {
                    specialInstructions.Remove("Add ice");
                }
                ice = value;
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
            return $"{drinkSize} Arentino Apple Juice";
        }
    }
}
