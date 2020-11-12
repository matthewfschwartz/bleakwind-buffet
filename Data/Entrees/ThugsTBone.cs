/*
 * Author: Matthew Schwartz
 * Class name: ThugsTBone.cs
 * Purpose: Get properties for a Thugs T-Bone object
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for defining a Thugs T-Bone object
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private double price = 6.44;
        private uint calories = 982; // Uint is unsigned integer (calories can't be negative)

        /// <summary>
        /// Name of this item, used in the order summary display list
        /// </summary>
        public string Name { get { return this.ToString(); } }

        public string Description { get; } = "Juicy T-Bone, not much else to say.";

        public string ItemCategory { get; } = "Entree";

        /// <summary>
        /// Gets the price of the t-bone
        /// </summary>
        public override double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the number of calories
        /// </summary>
        public override uint Calories
        {
            get { return calories; }
        }

        /// <summary>
        /// Always returns an empty list (no special instructions for t-bone)
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
            return "Thugs T-Bone";
        }

    }
}
