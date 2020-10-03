/*
 * Author: Matthew Schwartz
 * Class name: CustomizeFriedMiraak.xaml.cs
 * Purpose: Initializes the customization view for fried miraak and allows navigation back to the select sides view
 */

using BleakwindBuffet.Data.Sides;
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

namespace PointOfSale.CustomizeSides
{
    /// <summary>
    /// Interaction logic for CustomizeFriedMiraak.xaml
    /// </summary>
    public partial class CustomizeFriedMiraak : UserControl
    {
        FriedMiraak f = new FriedMiraak();
        public CustomizeFriedMiraak()
        {
            InitializeComponent();
            DataContext = new FriedMiraak();
        }
        void ClickDone(object sender, RoutedEventArgs e)
        {
            SelectSides custom = new SelectSides();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
            
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
            // Data binding for fried miraak
            f.Size = size;
            // Assigning the DataContext makes sure we don't lose the new size that we have assigned
            DataContext = f;
        }
    }
}
