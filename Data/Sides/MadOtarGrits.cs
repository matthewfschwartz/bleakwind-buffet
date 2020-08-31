/*
 * Author: Matthew Schwartz
 * Class name: MarkarthMilk.cs
 * Purpose: Get and set properties for a Mad Otar Grits object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    public class MadOtarGrits
    {
        private Size size = Size.Small;
        private double price = 1.22;
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
                    price = 1.22;
                }
                else if (size == Size.Medium)
                {
                    price = 1.58;
                }
                else
                {
                    price = 1.93;
                }
            }
        }

        private uint calories = 105;
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
                    calories = 105;
                }
                else if (size == Size.Medium)
                {
                    calories = 142;
                }
                else
                {
                    calories = 179;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Mad Otar Grits";
        }
    }
}
