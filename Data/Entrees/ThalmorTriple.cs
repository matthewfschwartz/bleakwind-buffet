/*
 * Author: Matthew Schwartz
 * Class name: ThalmorTriple.cs
 * Purpose: Get and set properties for a Thalmor Triple object
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class ThalmorTriple
    {
        private double price = 8.32;
        private uint calories = 943; // Uint is unsigned integer (calories can't be negative)

        /// <summary>
        /// Gets the price of the burger
        /// </summary>
        public double Price
        {
            get { return price; }
        }

        /// <summary>
        /// Gets the number of calories
        /// </summary>
        public uint Calories
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
                if (!value)
                {
                    specialInstructions.Add("Hold bun");
                }
                else
                {
                    specialInstructions.Remove("Hold bun");
                }
                bun = value;
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
                if (!value)
                {
                    specialInstructions.Add("Hold ketchup");
                }
                else
                {
                    specialInstructions.Remove("Hold ketchup");
                }
                ketchup = value;
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
                if (!value)
                {
                    specialInstructions.Add("Hold mustard");
                }
                else
                {
                    specialInstructions.Remove("Hold mustard");
                }
                mustard = value;
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
                if (!value)
                {
                    specialInstructions.Add("Hold pickle");
                }
                else
                {
                    specialInstructions.Remove("Hold pickle");
                }
                pickle = value;
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
                if (!value)
                {
                    specialInstructions.Add("Hold cheese");
                }
                else
                {
                    specialInstructions.Remove("Hold cheese");
                }
                cheese = value;
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
                if (!value)
                {
                    specialInstructions.Add("Hold tomato");
                }
                else
                {
                    specialInstructions.Remove("Hold tomato");
                }
                tomato = value;
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
                if (!value)
                {
                    specialInstructions.Add("Hold lettuce");
                }
                else
                {
                    specialInstructions.Remove("Hold lettuce");
                }
                lettuce = value;
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
                if (!value)
                {
                    specialInstructions.Add("Hold mayo");
                }
                else
                {
                    specialInstructions.Remove("Hold mayo");
                }
                mayo = value;
            }
        }

        /// <summary>
        /// Gets whether there is bacon or not
        /// Sets whether we want bacon or not
        /// Default is bacon on
        /// </summary>
        private bool bacon = true;
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold bacon");
                }
                else
                {
                    specialInstructions.Remove("Hold bacon");
                }
                bacon = value;
            }
        }

        /// <summary>
        /// Gets whether there is egg or not
        /// Sets whether we want egg or not
        /// Default is bacon on
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get { return egg; }
            set
            {
                if (!value)
                {
                    specialInstructions.Add("Hold egg");
                }
                else
                {
                    specialInstructions.Remove("Hold egg");
                }
                egg = value;
            }
        }

        /// <summary>
        /// Gets any special instructions in cooking the burger
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<String> SpecialInstructions
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
            return "Thalmor Triple";
        }
    }
}
