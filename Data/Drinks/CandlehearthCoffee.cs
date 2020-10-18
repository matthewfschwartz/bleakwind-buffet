/*
 * Author: Matthew Schwartz
 * Class name: CandlehearthCoffee.cs
 * Purpose: Get and set properties for a Candleheart Coffee object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class defining a CandlehearthCoffee object
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        public const double SMALL_CANDLEHEARTH_COFFEE_PRICE = 0.75;
        public const double MEDIUM_CANDLEHEARTH_COFFEE_PRICE = 1.25;
        public const double LARGE_CANDLEHEARTH_COFFEE_PRICE = 1.75;
        public const uint SMALL_CANDLEHEARTH_COFFEE_CALORIES = 7;
        public const uint MEDIUM_CANDLEHEARTH_COFFEE_CALORIES = 10;
        public const uint LARGE_CANDLEHEARTH_COFFEE_CALORIES = 20;

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
                    case Size.Small: return SMALL_CANDLEHEARTH_COFFEE_PRICE;
                    case Size.Medium: return MEDIUM_CANDLEHEARTH_COFFEE_PRICE;
                    case Size.Large: return LARGE_CANDLEHEARTH_COFFEE_PRICE;
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
                    case Size.Small: return SMALL_CANDLEHEARTH_COFFEE_CALORIES;
                    case Size.Medium: return MEDIUM_CANDLEHEARTH_COFFEE_CALORIES;
                    case Size.Large: return LARGE_CANDLEHEARTH_COFFEE_CALORIES;
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
        /// Gets whether there is room for cream or not
        /// Sets whether we want room for cream or not
        /// Default is no room for cream
        /// </summary>
        private bool roomForCream = false;
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                OnPropertyChanged("RoomForCream");
                if (roomForCream)
                {
                    specialInstructions.Add("Add cream");
                }
                else
                {
                    specialInstructions.Remove("Add cream");
                }
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets if coffee is decaf or not
        /// Sets whether we want decaf or not
        /// Default is no decaf
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                OnPropertyChanged("Decaf");
                if (decaf)
                {
                    specialInstructions.Add("Decaf");
                }
                else
                {
                    specialInstructions.Remove("Decaf");
                }
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
            if (decaf == false)
            {
                return $"{size} Candlehearth Coffee";
            }
            else
            {
                return $"{size} Decaf Candlehearth Coffee";
            }
        }
    }
}
