/*
 * Author: Matthew Schwartz
 * Class name: Drink.cs
 * Purpose: Base class for all drinks
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properities of drinks
    /// </summary>
    public abstract class Drink
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property invokation method for this class and derived classes to use
        /// </summary>
        /// <param name="propertyName">Which property is being changed</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        /// <summary>
        /// Size of a drink, all drinks have same size options (so virtual)
        /// </summary>
        protected Size size = Size.Small; 
        public virtual Size Size { get { return size; } 
            set 
            { 
                size = value;
            } 
        }

        /// <summary>
        /// Price of a drink, always overriding these (so abstract)
        /// </summary>
        /// <value>In US Dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of a drink, always overriding these (so abstract)
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for a drink, always overriding these (so abstract)
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
