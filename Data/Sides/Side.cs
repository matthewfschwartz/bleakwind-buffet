/*
 * Author: Matthew Schwartz
 * Class name: Side.cs
 * Purpose: Base class for all sides
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing common properities of sides
    /// </summary>
    public abstract class Side
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
        /// Size of a side item
        /// </summary>
        protected Size size = Size.Small;
        public virtual Size Size { get { return size; } 
            set 
            { 
                size = value;
            } 
        }

        /// <summary>
        /// Price for a side item
        /// </summary>
        /// <value>In US Dollars</value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories for a side item
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for a side item
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
