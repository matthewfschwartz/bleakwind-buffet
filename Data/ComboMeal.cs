/*
 * Author: Matthew Schwartz
 * Class name: ComboMeal.cs
 * Purpose: Get and set properties for a combo meal object, which contains a drink, side, and entree item
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class ComboMeal : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Name of this item, used in the order summary display list
        /// </summary>
        public string Name { get { return "Combo Meal"; } }

        public string ItemCategory { get; } = "Combo Meal";

        public string Description { get; } = "A Combo Meal is composed of an Entree, Side, and Drink of choice. These options are listed below. Each Combo Meal comes with a discount of $1.00 off the total cost of their Combo Items.";

        /// <summary>
        /// Constructor for Combo meal. Attaches listeners for the current drink, side, and entree
        /// </summary>
        public ComboMeal()
        {
            drink.PropertyChanged += ComboPropertyChangedListener;
            side.PropertyChanged += ComboPropertyChangedListener;
            entree.PropertyChanged += ComboPropertyChangedListener;
        }

        /// <summary>
        /// Drink property to represent which drink is in the combo meal
        /// </summary>
        private Drink drink = new SailorSoda();
        public Drink Drink
        {
            get { return drink; } 
            set
            {
                drink.PropertyChanged -= ComboPropertyChangedListener;
                drink = value;
                drink.PropertyChanged += ComboPropertyChangedListener;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Side property to represent which drink is in the combo meal
        /// </summary>
        private Side side = new DragonbornWaffleFries();

        public Side Side
        {
            get { return side; }
            set
            {
                side.PropertyChanged -= ComboPropertyChangedListener;
                side = value;
                side.PropertyChanged += ComboPropertyChangedListener;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Entree property to represent which drink is in the combo meal
        /// </summary>
        private Entree entree = new BriarheartBurger();
        public Entree Entree
        {
            get { return entree; } 
            set
            {
                entree.PropertyChanged -= ComboPropertyChangedListener;
                entree = value;
                entree.PropertyChanged += ComboPropertyChangedListener;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Price property to represent how much the combo meal costs
        /// </summary>
        public double Price
        {
            get { return Math.Round(drink.Price + side.Price + entree.Price - 1.00, 2); }
        }

        /// <summary>
        /// Calories property to represent how many calories are in the combo meal
        /// </summary>
        public uint Calories 
        {
            get { return drink.Calories + side.Calories + entree.Calories; }
        }

        /// <summary>
        /// Special instructions property to represent any special instructions for each item in the combo meal
        /// </summary>
        private List<string> specialInstructions;
        public List<string> SpecialInstructions
        {
            get 
            {
                specialInstructions = new List<string>();
                specialInstructions.Add(entree.ToString());
                specialInstructions.AddRange(entree.SpecialInstructions);
                specialInstructions.Add(drink.ToString());
                specialInstructions.AddRange(drink.SpecialInstructions);
                specialInstructions.Add(side.ToString());
                specialInstructions.AddRange(side.SpecialInstructions);
                return specialInstructions; 
            }
        }

        void ComboPropertyChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
            if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            if (e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

    }
}
