/*
 * Author: Matthew Schwartz
 * Class name: MarkarthMilk.cs
 * Purpose: Get and set properties for a Dragonborn Waffle Fries object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    public class DragonbornWaffleFries
    {
        private Size size = Size.Small;
        private double price = 0.42;

        /// <summary>
        /// Get the size and set the size
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Gets price of the side
        /// Sets price of the side according to the size
        /// </summary>
        public double Price
        {
            get { return price; }
            set
            {
                if (size == Size.Small)
                {
                    price = 0.42;
                }
                else if (size == Size.Medium)
                {
                    price = 0.76;
                }
                else
                {
                    price = 0.96;
                }
            }
        }

        private uint calories = 77;
        /// <summary>
        /// Gets the calories in the side
        /// Sets the calories in the side based on size
        /// </summary>
        public uint Calories
        {
            get { return calories; }
            set
            {
                if (size == Size.Small)
                {
                    calories = 77;
                }
                else if (size == Size.Medium)
                {
                    calories = 89;
                }
                else
                {
                    calories = 100;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Dragonborn Waffle Fries";
        }
    }
}
