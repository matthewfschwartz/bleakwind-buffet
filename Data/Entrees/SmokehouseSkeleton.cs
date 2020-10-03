﻿/*
 * Author: Matthew Schwartz
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Get and set properties for a Smokehouse Skeleton object
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for defining a Smokehouse Skeleton object
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        private double price = 5.62;
        private uint calories = 602; // Uint is unsigned integer (calories can't be negative)
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the combo
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
        /// Gets whether there is sausage or not
        /// Sets whether we want sausage or not
        /// Default is sausage on
        /// </summary>
        private bool sausageLink = true;
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }
            set
            {
                sausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                if (!sausageLink)
                {
                    specialInstructions.Add("Hold sausage");
                }
                else
                {
                    specialInstructions.Remove("Hold sausage");
                }
                
            }
        }

        /// <summary>
        /// Gets whether there is egg or not
        /// Sets whether we want egg or not
        /// Default is egg on
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                if (!egg)
                {
                    specialInstructions.Add("Hold eggs");
                }
                else
                {
                    specialInstructions.Remove("Hold eggs");
                }
                
            }
        }

        /// <summary>
        /// Gets whether there is hashbrowns or not
        /// Sets whether we want hashbrowns or not
        /// Default is hashbrowns on
        /// </summary>
        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set
            {
                hashBrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                if (!hashBrowns)
                {
                    specialInstructions.Add("Hold hash browns");
                }
                else
                {
                    specialInstructions.Remove("Hold hash browns");
                }
                
            }
        }

        /// <summary>
        /// Gets whether there is pancake or not
        /// Sets whether we want pancake or not
        /// Default is pancake on
        /// </summary>
        private bool pancake = true;
        public bool Pancake
        { 
            get { return pancake; }
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                if (!pancake)
                {
                    specialInstructions.Add("Hold pancakes");
                }
                else
                {
                    specialInstructions.Remove("Hold pancakes");
                }
                
            }
        }

        /// <summary>
        /// Gets any special instructions in cooking the combo meal
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>(specialInstructions);
            }
        }

        /// <summary>
        /// Overrides the ToString method to print the item name
        /// </summary>
        /// <returns>Returns a string containing the item name</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
