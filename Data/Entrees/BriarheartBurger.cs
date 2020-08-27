/*
 * Author: Matthew Schwartz
 * Class name: BriarheartBurger.cs
 * Purpose: Get and set properties for a Briarheart Burger object
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class BriarheartBurger
    {
        private double price = 6.32; 
        private uint calories = 743; // Uint is unsigned integer (calories can't be negative)

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
            return "Briarheart Burger";
        }
    }
}
