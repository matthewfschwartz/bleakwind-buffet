/*
 * Author: Matthew Schwartz
 * Class name: MarkarthMilk.cs
 * Purpose: Get and set properties for a Dragonborn Waffle Fries object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class for defining a Dragonborn Waffle Fries object
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem, INotifyPropertyChanged
    {
        public const double SMALL_DRAGONBORN_WAFFLE_FRIES_PRICE = 0.42;
        public const double MEDIUM_DRAGONBORN_WAFFLE_FRIES_PRICE = 0.76;
        public const double LARGE_DRAGONBORN_WAFFLE_FRIES_PRICE = 0.96;
        public const uint SMALL_DRAGONBORN_WAFFLE_FRIES_CALORIES = 77;
        public const uint MEDIUM_DRAGONBORN_WAFFLE_FRIES_CALORIES = 89;
        public const uint LARGE_DRAGONBORN_WAFFLE_FRIES_CALORIES = 100;

        /// <summary>
        /// Name of this item, used in the order summary display list
        /// </summary>
        public string Name { get { return this.ToString(); } }

        public string Description { get; } = "Crispy fried potato waffle fries.";

        public string ItemCategory { get; } = "Side";

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
                    case Size.Small: return SMALL_DRAGONBORN_WAFFLE_FRIES_PRICE;
                    case Size.Medium: return MEDIUM_DRAGONBORN_WAFFLE_FRIES_PRICE;
                    case Size.Large: return LARGE_DRAGONBORN_WAFFLE_FRIES_PRICE;
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
                    case Size.Small: return SMALL_DRAGONBORN_WAFFLE_FRIES_CALORIES;
                    case Size.Medium: return MEDIUM_DRAGONBORN_WAFFLE_FRIES_CALORIES;
                    case Size.Large: return LARGE_DRAGONBORN_WAFFLE_FRIES_CALORIES;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Always returns an empty list (no special instructions for waffle fries)
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
            return $"{size} Dragonborn Waffle Fries";
        }
    }
}
