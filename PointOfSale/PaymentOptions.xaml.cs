using BleakwindBuffet.Data;
using RoundRegister;
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
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        public PaymentOptions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for if user selects credit card payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCreditSelect(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var result = CardReader.RunCard(order.Total);
                if (result is CardTransactionResult.Approved)
                {
                    Order newOrder = new Order();
                    UpdateCashDrawer cashDrawer = new UpdateCashDrawer(order.Total);
                    MainMenuSelection main = new MainMenuSelection();
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>(); // Find the Order Component that is a parent of the current order summary
                    orderComponent.DataContext = newOrder; // Set the data context of the order component to be the new order
                    orderComponent.Swap(main);
                    cashDrawer.PrintReceipt(false, order); // Print receipt for false (paying with card, not cash), and this order
                }
            }
            
        }

        /// <summary>
        /// Event handler for if user selects cash payment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCashSelect(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CashPayment cashPay = new CashPayment(order);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>(); // Find the Order Component that is a parent of the current order summary
                orderComponent.Swap(cashPay);
            }
        }

        /// <summary>
        /// Event handler for if the users wants to return to their order and is not ready to pay yet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnReturnSelect(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                MainMenuSelection main = new MainMenuSelection();
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(main);
            }
        }
    }
}
