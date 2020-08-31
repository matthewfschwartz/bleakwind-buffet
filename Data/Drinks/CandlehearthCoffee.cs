/*
 * Author: Matthew Schwartz
 * Class name: CandlehearthCoffee.cs
 * Purpose: Get and set properties for a Candleheart Coffee object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class CandlehearthCoffee
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
                    price = 0.75;
                }
                else if (drinkSize == Size.Medium)
                {
                    price = 1.25;
                }
                else
                {
                    price = 1.75;
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
                    calories = 7;
                }
                else if (drinkSize == Size.Medium)
                {
                    calories = 10;
                }
                else
                {
                    calories = 20;
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
        /// Gets whether there is room for cream or not
        /// Sets whether we want room for cream or not
        /// Default is no room for cream
        /// </summary>
        private bool roomForCream = false;
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                if (!roomForCream)
                {
                    specialInstructions.Add("Add cream");
                }
                else
                {
                    specialInstructions.Remove("Add cream");
                }
                roomForCream = value;
            }
        }

        /// <summary>
        /// Gets if coffee is decaf or not
        /// Sets whether we want decaf or not
        /// Default is no decaf
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
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
            if (decaf == false)
            {
                return $"{drinkSize} Candleheart Coffee";
            }
            else
            {
                return $"{drinkSize} Decaf Candleheart Coffee";
            }
        }
    }
}
