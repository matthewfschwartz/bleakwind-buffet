/*
 * Author: Matthew Schwartz
 * Class name: CustomizeAretinoAppleJuice.xaml.cs
 * Purpose: Initializes the customization view for aretino apple juice and allows navigation back to the select drinks view
 */

using BleakwindBuffet.Data.Drinks;
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
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.CustomizeDrinks
{
    /// <summary>
    /// Interaction logic for CustomizeAretinoAppleJuice.xaml
    /// </summary>
    public partial class CustomizeAretinoAppleJuice : UserControl
    {
        private AretinoAppleJuice a = new AretinoAppleJuice();
        public CustomizeAretinoAppleJuice()
        {
            InitializeComponent();
            DataContext = new AretinoAppleJuice();
        }
        void ClickDone(object sender, RoutedEventArgs e)
        {
            SelectDrinks custom = new SelectDrinks();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
            
        }

        void OnIceSelect(object sender, EventArgs e)
        {
            if (IceSelect.IsChecked == false) IceSelect.IsChecked = false;
            else IceSelect.IsChecked = true;
            a.Ice = (bool)IceSelect.IsChecked;
            DataContext = a;
        }

        void SizeSelectionChanged(object sender, RoutedEventArgs e)
        {
            Size size = Size.Small;
            if ((bool)SmallRadio.IsChecked)
            {
                size = Size.Small;
            }
            else if ((bool)MedRadio.IsChecked)
            {
                size = Size.Medium;
            }
            else
            {
                size = Size.Large;
            }
            // Data binding for Aretino AJ 
            a.Size = size;
            // Assigning the DataContext makes sure we don't lose the new size that we have assigned
            DataContext = a; 
        }
    }
}
