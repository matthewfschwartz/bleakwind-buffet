/*
 * Author: Matthew Schwartz
 * Class name: MarkarthMilk.cs
 * Purpose: Get and set properties for a Vokun Salad object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    public class VokunSalad
    {
        private Size size = Size.Small;
        private double price = 0.93;
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
                    price = 0.93;
                }
                else if (size == Size.Medium)
                {
                    price = 1.28;
                }
                else
                {
                    price = 1.82;
                }
            }
        }

        private uint calories = 41;
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
                    calories = 41;
                }
                else if (size == Size.Medium)
                {
                    calories = 52;
                }
                else
                {
                    calories = 73;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Vokun Salad";
        }
    }
}
