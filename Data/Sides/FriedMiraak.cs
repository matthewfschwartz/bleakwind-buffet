﻿/*
 * Author: Matthew Schwartz
 * Class name: MarkarthMilk.cs
 * Purpose: Get and set properties for a Fried Miraak object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for defining a Fried Miraak object
    /// </summary>
    public class FriedMiraak : Side, IOrderItem
    {
        /// <summary>
        /// Gets price of the side
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if size is unknown
        /// </exception>
        public override double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 1.78;
                    case Size.Medium: return 2.01;
                    case Size.Large: return 2.88;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Gets the calories in the side
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if size is unknown
        /// </exception>
        public override uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 151;
                    case Size.Medium: return 236;
                    case Size.Large: return 306;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Always returns an empty list (no special instructions for fried miraak)
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get { return new List<string>(); }
        }

        /// <summary>
        /// Overrides the ToString method to print the item name
        /// </summary>
        /// <returns>Returns a string containing the item name</returns>
        public override string ToString()
        {
            return $"{size} Fried Miraak";
        }
    }
}
