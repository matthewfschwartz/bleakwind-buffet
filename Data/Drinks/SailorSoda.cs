﻿/*
 * Author: Matthew Schwartz
 * Class name: SailorsSoda.cs
 * Purpose: Get and set properties for a Sailor's Soda object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class defining a SailorSoda object
    /// </summary>
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {
        public const double SMALL_SAILOR_SODA_PRICE = 1.42;
        public const double MEDIUM_SAILOR_SODA_PRICE = 1.74;
        public const double LARGE_SAILOR_SODA_PRICE = 2.07;
        public const uint SMALL_SAILOR_SODA_CALORIES = 117;
        public const uint MEDIUM_SAILOR_SODA_CALORIES = 153;
        public const uint LARGE_SAILOR_SODA_CALORIES = 205;

        /// <summary>
        /// Name of this item, used in the order summary display list
        /// </summary>
        public string Name { get { return this.ToString(); } }

        public string Description { get; } = "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";

        public string ItemCategory { get; } = "Drink";

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
                    case Size.Small: return SMALL_SAILOR_SODA_PRICE;
                    case Size.Medium: return MEDIUM_SAILOR_SODA_PRICE;
                    case Size.Large: return LARGE_SAILOR_SODA_PRICE;
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
                    case Size.Small: return SMALL_SAILOR_SODA_CALORIES;
                    case Size.Medium: return MEDIUM_SAILOR_SODA_CALORIES;
                    case Size.Large: return LARGE_SAILOR_SODA_CALORIES;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Gets whether there is ice or not
        /// Sets whether we want ice or not
        /// Default is ice in
        /// </summary>
        private bool ice = true;
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                OnPropertyChanged("Ice");
                if (!ice)
                {
                    specialInstructions.Add("Hold ice");
                }
                else
                {
                    specialInstructions.Remove("Hold ice");
                }
                OnPropertyChanged("SpecialInstructions");
            }
        }


        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set 
            {
                flavor = value;
                OnPropertyChanged("Flavor");
                OnPropertyChanged("SpecialInstructions");
                OnPropertyChanged("Name");
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
        /// Overrides the ToString method to print the size and flavor
        /// </summary>
        /// <returns>Returns the size and flavor of the drink with the drink name</returns>
        public override string ToString()
        {
            return $"{size} {flavor} Sailor Soda";
        }
    }
}
