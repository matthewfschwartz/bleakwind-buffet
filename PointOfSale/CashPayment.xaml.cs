using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for CashPayment.xaml
    /// </summary>
    public partial class CashPayment : UserControl
    {
        double totalCost = 0;
        Order thisOrder = new Order();
        UpdateCashDrawer cashDrawer;
        public CashPayment(Order order)
        {
            InitializeComponent();
            TotalCost = order.Total;
            thisOrder = order;
            cashDrawer = new UpdateCashDrawer(TotalCost);
            DataContext = cashDrawer;
        }

        public double TotalCost
        {
            get { return totalCost; } 
            set { totalCost = value; }
        }

        /// <summary>
        /// Event handler for if user wants to return to their order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ReturnToOrderClicked(object sender, RoutedEventArgs e)
        {
            MainMenuSelection main = new MainMenuSelection();
            OrderComponent orderComponent = this.FindAncestor<OrderComponent>(); // Find the Order Component that is a parent of the current order summary
            orderComponent.Swap(main);
        }

        /// <summary>
        /// Event handler for if the user wants to finalize the sale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FinalizeSaleClicked(object sender, RoutedEventArgs e)
        {
            cashDrawer.PrintReceipt(true, thisOrder);
            Order newOrder = new Order();
            MainMenuSelection main = new MainMenuSelection();
            OrderComponent orderComponent = this.FindAncestor<OrderComponent>(); // Find the Order Component that is a parent of the current order summary
            orderComponent.DataContext = newOrder; // Set the data context of the order component to be the new order
            orderComponent.Swap(main);
        }

        
    }
}
