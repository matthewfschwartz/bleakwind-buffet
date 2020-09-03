/*
 * Author: Matthew Schwartz
 * Class name: WarriorWater.cs
 * Purpose: Get and set properties for a Warrior Water object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        private Size size = Size.Small;
        /// <summary>
        /// Get the size and set the size
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// The price of a drink
        /// </summary>
        /// <exception cref="System.NotImplementedException">
        /// Thrown if size is unknown
        /// </exception>
        public double Price
        {
            get 
            { 
                switch(size)
                {
                    case Size.Small: return 0;
                    case Size.Medium: return 0;
                    case Size.Large: return 0;
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
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small: return 0;
                    case Size.Medium: return 0;
                    case Size.Large: return 0;
                    default: throw new NotImplementedException($"Unknown size {Size}");
                }
            }
        }

        /// <summary>
        /// Gets whether there is ice or not
        /// Sets whether we want ice or not
        /// Default is ice
        /// </summary>
        private bool ice = true;
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                if (!ice)
                {
                    specialInstructions.Add("Hold ice");
                }
                else
                {
                    specialInstructions.Remove("Hold ice");
                }
                
            }
        }


        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                if (lemon)
                {
                    specialInstructions.Add("Add lemon");
                }
                else
                {
                    specialInstructions.Remove("Add lemon");
                }
                
            }
        }

        /// <summary>
        /// Gets any special instructions
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get { return new List<string>(specialInstructions); }
        }

        /// <summary>
        /// Overrides the ToString method to print the size
        /// </summary>
        /// <returns>Returns the size and flavor of the drink with the drink name</returns>
        public override string ToString()
        {
            return $"{size} Warrior Water";
        }
    }
}
