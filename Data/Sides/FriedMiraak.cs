/*
 * Author: Matthew Schwartz
 * Class name: MarkarthMilk.cs
 * Purpose: Get and set properties for a Fried Miraak object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    public class FriedMiraak
    {
        private Size size = Size.Small;
        private double price = 1.78;
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
                    price = 1.78;
                }
                else if (size == Size.Medium)
                {
                    price = 2.01;
                }
                else
                {
                    price = 2.88;
                }
            }
        }

        private uint calories = 151;
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
                    calories = 151;
                }
                else if (size == Size.Medium)
                {
                    calories = 236;
                }
                else
                {
                    calories = 306;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Fried Miraak";
        }
    }
}
