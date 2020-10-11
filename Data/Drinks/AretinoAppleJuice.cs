/*
 * Author: Matthew Schwartz
 * Class name: AretinoAppleJuice.cs
 * Purpose: Get and set properties for a Aretino Apple Juice object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class defining a AretinoAppleJuice object
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        public const double SMALL_ARETINO_APPLE_JUICE_PRICE = 0.62;
        public const double MEDIUM_ARETINO_APPLE_JUICE_PRICE = 0.87;
        public const double LARGE_ARETINO_APPLE_JUICE_PRICE = 1.01;
        public const uint SMALL_ARETINO_APPLE_JUICE_CALORIES = 44;
        public const uint MEDIUM_ARETINO_APPLE_JUICE_CALORIES = 88;
        public const uint LARGE_ARETINO_APPLE_JUICE_CALORIES = 132;

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
        /// Gets price of the drink
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
                    case Size.Small: return SMALL_ARETINO_APPLE_JUICE_PRICE;
                    case Size.Medium: return MEDIUM_ARETINO_APPLE_JUICE_PRICE;
                    case Size.Large: return LARGE_ARETINO_APPLE_JUICE_PRICE;
                    default: throw new NotImplementedException($"Unknown size {size}");
                }
            }
        }

        /// <summary>
        /// Gets the calories in a drink
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
                    case Size.Small: return SMALL_ARETINO_APPLE_JUICE_CALORIES;
                    case Size.Medium: return MEDIUM_ARETINO_APPLE_JUICE_CALORIES;
                    case Size.Large: return LARGE_ARETINO_APPLE_JUICE_CALORIES;
                    default: throw new NotImplementedException($"Unknown size {size}");
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
                ice = value;
                
                if (ice)
                {
                    specialInstructions.Add("Add ice");
                }
                else
                {
                    specialInstructions.Remove("Add ice");
                }
                OnPropertyChanged("Ice");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets any special instructions
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get { return new List<string>(specialInstructions); }
        }

        /// <summary>
        /// Overrides the ToString method to print the size
        /// </summary>
        /// <returns>Returns the size and flavor of the drink with the drink name</returns>
        public override string ToString()
        {
            return $"{size} Aretino Apple Juice";
        }
    }
}
