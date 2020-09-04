﻿/*
 * Author: Matthew Schwartz
 * Class name: GardenOrcOmelette.cs
 * Purpose: Get and set properties for a Garden Orc Omelette object
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for defining a Garden Orc Omelette object
    /// </summary>
    public class GardenOrcOmelette
    {
        private double price = 4.57;
        private uint calories = 404; // Uint is unsigned integer (calories can't be negative)

        /// <summary>
        /// Gets the price of the omelette
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
        /// Gets whether there is broccoli or not
        /// Sets whether we want broccoli or not
        /// Default is broccoli on
        /// </summary>
        private bool broccoli = true;
        public bool Broccoli
        {
            get { return broccoli; }
            set
            {
                broccoli = value;
                if (!broccoli)
                {
                    specialInstructions.Add("Hold broccoli");
                }
                else
                {
                    specialInstructions.Remove("Hold broccoli");
                }
                
            }
        }


        /// <summary>
        /// Gets whether there is mushrooms or not
        /// Sets whether we want mushrooms or not
        /// Default is mushrooms on
        /// </summary>
        private bool mushrooms = true;
        public bool Mushrooms
        {
            get { return mushrooms; }
            set
            {
                mushrooms = value;
                if (!mushrooms)
                {
                    specialInstructions.Add("Hold mushrooms");
                }
                else
                {
                    specialInstructions.Remove("Hold mushrooms");
                }
                
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
                if (!tomato)
                {
                    specialInstructions.Add("Hold tomato");
                }
                else
                {
                    specialInstructions.Remove("Hold tomato");
                }
                
            }
        }


        /// <summary>
        /// Gets whether there is cheddar or not
        /// Sets whether we want cheddar or not
        /// Default is cheddar on
        /// </summary>
        private bool cheddar = true;
        public bool Cheddar
        {
            get { return cheddar; }
            set
            {
                cheddar = value;
                if (!cheddar)
                {
                    specialInstructions.Add("Hold cheddar");
                }
                else
                {
                    specialInstructions.Remove("Hold cheddar");
                }
                
            }
        }

        /// <summary>
        /// Gets any special instructions in cooking the omelette
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get { return new List<string>(specialInstructions); }
        }

        /// <summary>
        /// Overrides the ToString method to print the item name
        /// </summary>
        /// <returns>Returns a string containing the item name</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
