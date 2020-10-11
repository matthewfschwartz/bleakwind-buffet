/*
 * Author: Matthew Schwartz
 * Class name: MainMenuSelection.xaml.cs
 * Purpose: The largest component in main window, handles the changing display of what view we want the user to see through the Swap() method
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
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        public OrderComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Swaps the child of border name "swapView" with the new view we want to display
        /// </summary>
        /// <param name="element">The view we want to swap to</param>
        public void Swap(FrameworkElement element)
        {
            swapView.Child = element;
        }
    }
}
