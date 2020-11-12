/*
 * Author: Matthew Schwartz
 * Class name: DoubleDraugr.cs
 * Purpose: Get and set properties for a Double Draugr object
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for defining a Double Draugr object
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem, INotifyPropertyChanged
    {
        private double price = 7.32;
        private uint calories = 843; // Uint is unsigned integer (calories can't be negative)

        /// <summary>
        /// Name of this item, used in the order summary display list
        /// </summary>
        public string Name { get { return this.ToString(); } }

        public string Description { get; } = "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";

        public string ItemCategory { get; } = "Entree";

        /// <summary>
        /// Gets the price of the burger
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
        /// Gets whether there is a bun or not
        /// Sets whether we want a bun or not
        /// Default is bun on
        /// </summary>
        private bool bun = true;
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                
                if (!value)
                {
                    specialInstructions.Add("Hold bun");
                }
                else
                {
                    specialInstructions.Remove("Hold bun");
                }
                OnPropertyChanged("Bun");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets whether there is ketchup or not
        /// Sets whether we want ketchup or not
        /// Default is ketchup on
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                
                if (!value)
                {
                    specialInstructions.Add("Hold ketchup");
                }
                else
                {
                    specialInstructions.Remove("Hold ketchup");
                }
                OnPropertyChanged("Ketchup");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets whether there is mustard or not
        /// Sets whether we want mustard or not
        /// Default is mustard on
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                
                if (!value)
                {
                    specialInstructions.Add("Hold mustard");
                }
                else
                {
                    specialInstructions.Remove("Hold mustard");
                }
                OnPropertyChanged("Mustard");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets whether there is a pickle or not
        /// Sets whether we want a pickle or not
        /// Default is pickle on
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                
                if (!value)
                {
                    specialInstructions.Add("Hold pickle");
                }
                else
                {
                    specialInstructions.Remove("Hold pickle");
                }
                OnPropertyChanged("Pickle");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets whether there is cheese or not
        /// Sets whether we want cheese or not
        /// Default is cheese on
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                
                if (!value)
                {
                    specialInstructions.Add("Hold cheese");
                }
                else
                {
                    specialInstructions.Remove("Hold cheese");
                }
                OnPropertyChanged("Cheese");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets whether there is tomato or not
        /// Sets whether we want tomato or not
        /// Default is tomato on
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                
                if (!value)
                {
                    specialInstructions.Add("Hold tomato");
                }
                else
                {
                    specialInstructions.Remove("Hold tomato");
                }
                OnPropertyChanged("Tomato");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets whether there is lettuce or not
        /// Sets whether we want lettuce or not
        /// Default is lettuce on
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                
                if (!value)
                {
                    specialInstructions.Add("Hold lettuce");
                }
                else
                {
                    specialInstructions.Remove("Hold lettuce");
                }
                OnPropertyChanged("Lettuce");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets whether there is mayo or not
        /// Sets whether we want mayo or not
        /// Default is mayo on
        /// </summary>
        private bool mayo = true;
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                
                if (!value)
                {
                    specialInstructions.Add("Hold mayo");
                }
                else
                {
                    specialInstructions.Remove("Hold mayo");
                }
                OnPropertyChanged("Mayo");
                OnPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets any special instructions in cooking the burger
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<String> SpecialInstructions
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
            return "Double Draugr";
        }
    }
}
