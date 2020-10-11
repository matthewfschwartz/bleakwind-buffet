/*
 * Author: Matthew Schwartz
 * Class name: MarkarthMilk.cs
 * Purpose: Get and set properties for a Fried Miraak object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for defining a Fried Miraak object
    /// </summary>
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
    {
        public const double SMALL_FRIED_MIRAAK_PRICE = 1.78;
        public const double MEDIUM_FRIED_MIRAAK_PRICE = 2.01;
        public const double LARGE_FRIED_MIRAAK_PRICE = 2.88;
        public const uint SMALL_FRIED_MIRAAK_CALORIES = 151;
        public const uint MEDIUM_FRIED_MIRAAK_CALORIES = 236;
        public const uint LARGE_FRIED_MIRAAK_CALORIES = 306;

        /// <summary>
        /// Name of this item, used in the order summary display list
        /// </summary>
        public string Name { get { return this.ToString(); } }

        private new Size size = Size.Small;
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                OnPropertyChanged("Size");
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("SpecialInstructions");
                OnPropertyChanged("Name");
            }
        }

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
                    case Size.Small: return SMALL_FRIED_MIRAAK_PRICE;
                    case Size.Medium: return MEDIUM_FRIED_MIRAAK_PRICE;
                    case Size.Large: return LARGE_FRIED_MIRAAK_PRICE;
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
                    case Size.Small: return SMALL_FRIED_MIRAAK_CALORIES;
                    case Size.Medium: return MEDIUM_FRIED_MIRAAK_CALORIES;
                    case Size.Large: return LARGE_FRIED_MIRAAK_CALORIES;
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
