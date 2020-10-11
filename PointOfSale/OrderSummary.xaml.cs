/*
 * Author: Matthew Schwartz
 * Class name: OrderSummary.xaml.cs
 * Purpose: Displays the list of items on each order and the total price of the order
 * Gives the user an option to return to the main menu at any point during their shopping experience
 */

using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummary.xaml
    /// </summary>
    public partial class OrderSummary : UserControl
    {
        /// <summary>
        /// Constructor for OrderSummary class
        /// </summary>
        public OrderSummary()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the user wants to return to the main menu
        /// Should take them back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuSelection main = new MainMenuSelection();
            OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
            orderComponent.Swap(main);
        }

        /// <summary>
        /// Event handler for if the user finishes their order
        /// Should clear order summary and order number should increment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnFinishClick(object sender, RoutedEventArgs e)
        {
            Order newOrder = new Order(true);

            MainMenuSelection main = new MainMenuSelection();
            OrderComponent orderComponent = this.FindAncestor<OrderComponent>(); // Find the Order Component that is a parent of the current order summary
            orderComponent.DataContext = newOrder; // Set the data context of the order component to be the new order
            orderComponent.Swap(main);
        }

        /// <summary>
        /// Event handler for if the user cancels the order
        /// Should clear order summary and retain the same order number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCancelClick(object sender, RoutedEventArgs e)
        {
            Order newOrder = new Order(false);
            newOrder.Number = Convert.ToInt32(orderNumber.Text);

            MainMenuSelection main = new MainMenuSelection();
            OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
            orderComponent.DataContext = newOrder;
            orderComponent.Swap(main);
        }

        /// <summary>
        /// Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRemoveClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var itemToRemove = (IOrderItem)orderList.SelectedItem;
                order.Remove(itemToRemove);
            }
        }
    }
}
