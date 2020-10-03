/*
 * Author: Matthew Schwartz
 * Class name: CustomizeCandlehearthCoffee.xaml.cs
 * Purpose: Initializes the customization view for candlehearth coffee and allows navigation back to the select drinks view
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
    /// Interaction logic for CustomizeCandlehearthCoffee.xaml
    /// </summary>
    public partial class CustomizeCandlehearthCoffee : UserControl
    {
        private CandlehearthCoffee c = new CandlehearthCoffee();
        public CustomizeCandlehearthCoffee()
        {
            InitializeComponent();
            DataContext = new CandlehearthCoffee();
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
            c.Ice = (bool)IceSelect.IsChecked;
            DataContext = c;
        }

        void OnCreamSelect(object sender, EventArgs e)
        {
            if (CreamSelect.IsChecked == false) CreamSelect.IsChecked = false;
            else CreamSelect.IsChecked = true;
            c.RoomForCream = (bool)CreamSelect.IsChecked;
            DataContext = c;
        }

        void OnDecafSelect(object sender, EventArgs e)
        {
            if (DecafSelect.IsChecked == false) DecafSelect.IsChecked = false;
            else DecafSelect.IsChecked = true;
            c.Decaf = (bool)DecafSelect.IsChecked;
            DataContext = c;
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
            // Data binding for Coffee
            c.Size = size;
            // Assigning the DataContext makes sure we don't lose the new size that we have assigned
            DataContext = c;
        }
    }
}
