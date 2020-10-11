/*
 * Author: Matthew Schwartz
 * Class name: Order.cs
 * Purpose: Represents an order that the user is creating or editing
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Transactions;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class representing an order that is a collection or IOrderItems
    /// </summary>
    public class Order : ObservableCollection<IOrderItem>
    {
        private static int nextOrderNumber = 1;

        /// <summary>
        /// Constructor for an Order
        /// </summary>
        /// <param name="newOrder">Boolean representing whether this order is new or not. Will be true if user clicked "Finish Order", false if they canceled</param>
        public Order(bool newOrder)
        {
            Number = nextOrderNumber;
            if (newOrder)
            {
                nextOrderNumber++;
                Number = nextOrderNumber;
                
            }
            
            
            CollectionChanged += CollectionChangedListener;
        }

        /// <summary> 
        /// Represents the sales tax rate
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        /// <summary>
        /// Represents subtotal cost of this order
        /// </summary>
        public double Subtotal { 
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in this)
                {
                    subtotal += item.Price;
                }
                return Math.Round(subtotal, 2);
            }
        }

        private double tax = 0;
        /// <summary>
        /// Represents total tax cost of this order
        /// </summary>
        public double Tax { 
            get
            {
                tax = Math.Round(Subtotal * SalesTaxRate, 2);
                return tax;
            }
        }

        private double total = 0;
        /// <summary>
        /// Represents total order cost of this order
        /// </summary>
        public double Total { 
            get 
            {
                total = Subtotal + Tax;
                return Math.Round(total, 2);
            } 
        }

        private uint calories;
        /// <summary>
        /// Represents the total number of calories in this order
        /// </summary>
        public uint Calories
        {
            get
            {
                foreach (IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

        /// <summary>
        /// Represents the Order Number
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Listens to changes in the collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            switch (e.Action)
            {
                
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                        //OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                        //OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                        //OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                        //OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    }
                    break;
                case NotifyCollectionChangedAction.Remove: // If the item is removed from the list, remove the event listener
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                        //OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                        //OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                        //OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                        //OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    }
                    break;
                case NotifyCollectionChangedAction.Reset: // Big change, start over from scratch
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported.");
            }
            
        }

        /// <summary>
        /// Listens to changes in the items in the collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            }
            if (e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
