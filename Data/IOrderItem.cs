/*
 * Author: Matthew Schwartz
 * Class: IOrderItem.cs
 * Purpose: Provide an interface (or type) for all menu items
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface for items as a part of an order
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Price of an order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Calories of an order item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions for an order item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
