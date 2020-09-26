/*
 * Author: Matthew Schwartz
 * Class name: Entree.cs
 * Purpose: Base class for all entrees
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing common properities of entrees
    /// </summary>
    public abstract class Entree
    {
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
