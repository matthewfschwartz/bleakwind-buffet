/*
 * Author: Matthew Schwartz
 * Class name: OrderSummary.xaml.cs
 * Purpose: Displays the list of items on each order and the total price of the order
 * Gives the user an option to return to the main menu at any point during their shopping experience
 */

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
        public OrderSummary()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuSelection main = new MainMenuSelection();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(main);
        }
    }
}
