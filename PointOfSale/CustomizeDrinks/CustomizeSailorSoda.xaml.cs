/*
 * Author: Matthew Schwartz
 * Class name: CustomizeSailorSoda.xaml.cs
 * Purpose: Initializes the customization view for sailor soda and allows navigation back to the select drinks view
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
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
    /// Interaction logic for CustomizeSailorSoda.xaml
    /// </summary>
    public partial class CustomizeSailorSoda : UserControl
    {
        private SailorSoda s = new SailorSoda();
        public CustomizeSailorSoda()
        {
            InitializeComponent();
            DataContext = new SailorSoda();
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
            s.Ice = (bool)IceSelect.IsChecked;
            DataContext = s;
        }

        void OnFlavorSelection(object sender, RoutedEventArgs e)
        {
            SodaFlavor flavor = SodaFlavor.Cherry;
            if ((bool)WatermelonOption.IsChecked)
            {
                flavor = SodaFlavor.Watermelon;
            }
            else if ((bool)PeachOption.IsChecked)
            {
                flavor = SodaFlavor.Peach;
            }
            else if ((bool)GrapefruitOption.IsChecked)
            {
                flavor = SodaFlavor.Grapefruit;
            }
            else if ((bool)LemonOption.IsChecked)
            {
                flavor = SodaFlavor.Lemon;
            }
            else if ((bool)BlackberryOption.IsChecked)
            {
                flavor = SodaFlavor.Blackberry;
            }
            else
            {
                flavor = SodaFlavor.Cherry;
            }
            s.Flavor = flavor;
            DataContext = s;
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
            // Data binding for milk
            s.Size = size;
            // Assigning the DataContext makes sure we don't lose the new size that we have assigned
            DataContext = s;
        }
    }
}
