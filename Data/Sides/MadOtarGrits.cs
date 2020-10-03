/*
 * Author: Matthew Schwartz
 * Class name: MarkarthMilk.cs
 * Purpose: Get and set properties for a Mad Otar Grits object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for defining a Mad Otar Grits object
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem, INotifyPropertyChanged
    {
        public const double SMALL_MAD_OTAR_GRITS_PRICE = 1.22;
        public const double MEDIUM_MAD_OTAR_GRITS_PRICE = 1.58;
        public const double LARGE_MAD_OTAR_GRITS_PRICE = 1.93;
        public const uint SMALL_MAD_OTAR_GRITS_CALORIES = 105;
        public const uint MEDIUM_MAD_OTAR_GRITS_CALORIES = 142;
        public const uint LARGE_MAD_OTAR_GRITS_CALORIES = 179;

        public event PropertyChangedEventHandler PropertyChanged;

        private new Size size = Size.Small;
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
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
                    case Size.Small: return SMALL_MAD_OTAR_GRITS_PRICE;
                    case Size.Medium: return MEDIUM_MAD_OTAR_GRITS_PRICE;
                    case Size.Large: return LARGE_MAD_OTAR_GRITS_PRICE;
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
                    case Size.Small: return SMALL_MAD_OTAR_GRITS_CALORIES;
                    case Size.Medium: return MEDIUM_MAD_OTAR_GRITS_CALORIES;
                    case Size.Large: return LARGE_MAD_OTAR_GRITS_CALORIES;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Always returns an empty list (no special instructions for grits)
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
            return $"{size} Mad Otar Grits";
        }
    }
}
