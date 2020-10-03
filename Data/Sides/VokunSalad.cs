/*
 * Author: Matthew Schwartz
 * Class name: MarkarthMilk.cs
 * Purpose: Get and set properties for a Vokun Salad object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for defining a Vokun Salad object
    /// </summary>
    public class VokunSalad : Side, IOrderItem, INotifyPropertyChanged
    {
        public const double SMALL_VOKUN_SALAD_PRICE = 0.93;
        public const double MEDIUM_VOKUN_SALAD_PRICE = 1.28;
        public const double LARGE_VOKUN_SALAD_PRICE = 1.82;
        public const uint SMALL_VOKUN_SALAD_CALORIES = 41;
        public const uint MEDIUM_VOKUN_SALAD_CALORIES = 52;
        public const uint LARGE_VOKUN_SALAD_CALORIES = 73;

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
                    case Size.Small: return SMALL_VOKUN_SALAD_PRICE;
                    case Size.Medium: return MEDIUM_VOKUN_SALAD_PRICE;
                    case Size.Large: return LARGE_VOKUN_SALAD_PRICE;
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
                    case Size.Small: return SMALL_VOKUN_SALAD_CALORIES;
                    case Size.Medium: return MEDIUM_VOKUN_SALAD_CALORIES;
                    case Size.Large: return LARGE_VOKUN_SALAD_CALORIES;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Always returns an empty list (no special instructions for vokun salad)
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
            return $"{size} Vokun Salad";
        }
    }
}
