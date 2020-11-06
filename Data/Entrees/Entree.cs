/*
 * Author: Matthew Schwartz
 * Class name: Entree.cs
 * Purpose: Base class for all entrees
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing common properities of entrees
    /// </summary>
    public abstract class Entree
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string ItemCategory = "Entree";

        /// <summary>
        /// Property invokation method for this class and derived classes to use
        /// </summary>
        /// <param name="propertyName">Which property is being changed</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Price of an entree
        /// </summary>
        /// <value>In US Dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of an entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for an entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
