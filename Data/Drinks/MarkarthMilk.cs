/*
 * Author: Matthew Schwartz
 * Class name: MarkarthMilk.cs
 * Purpose: Get and set properties for a Markarth Milk object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class defining a MarkarthMilk object
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem, INotifyPropertyChanged
    {
        public const double SMALL_MARKARTH_MILK_PRICE = 1.05;
        public const double MEDIUM_MARKARTH_MILK_PRICE = 1.11;
        public const double LARGE_MARKARTH_MILK_PRICE = 1.22;
        public const uint SMALL_MARKARTH_MILK_CALORIES = 56;
        public const uint MEDIUM_MARKARTH_MILK_CALORIES = 72;
        public const uint LARGE_MARKARTH_MILK_CALORIES = 93;

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
                    case Size.Small: return SMALL_MARKARTH_MILK_PRICE;
                    case Size.Medium: return MEDIUM_MARKARTH_MILK_PRICE;
                    case Size.Large: return LARGE_MARKARTH_MILK_PRICE;
                    default: throw new NotImplementedException($"Unknown size {Size}");
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
                    case Size.Small: return SMALL_MARKARTH_MILK_CALORIES;
                    case Size.Medium: return MEDIUM_MARKARTH_MILK_CALORIES;
                    case Size.Large: return LARGE_MARKARTH_MILK_CALORIES;
                    default: throw new NotImplementedException($"Unknown size {Size}");
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                if (ice)
                {
                    specialInstructions.Add("Add ice");
                }
                else
                {
                    specialInstructions.Remove("Add ice");
                }
                
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
            return $"{size} Markarth Milk";
        }
    }
}
