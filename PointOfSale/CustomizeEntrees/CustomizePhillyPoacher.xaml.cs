/*
 * Author: Matthew Schwartz
 * Class name: CustomizePhillyPoacher.xaml.cs
 * Purpose: Initializes the customization view for philly poacher and allows navigation back to the select entrees view
 */

using BleakwindBuffet.Data.Entrees;
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

namespace PointOfSale.CustomizeEntrees
{
    /// <summary>
    /// Interaction logic for CustomizePhillyPoacher.xaml
    /// </summary>
    public partial class CustomizePhillyPoacher : UserControl
    {
        PhillyPoacher p = new PhillyPoacher();
        public CustomizePhillyPoacher()
        {
            InitializeComponent();
            DataContext = new PhillyPoacher();
        }
        void ClickDone(object sender, RoutedEventArgs e)
        {
            SelectEntrees custom = new SelectEntrees();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
            
        }

        void OnSirloinSelect(object sender, EventArgs e)
        {
            if (SirloinSelect.IsChecked == false) SirloinSelect.IsChecked = false;
            else SirloinSelect.IsChecked = true;
            p.Sirloin = (bool)SirloinSelect.IsChecked;
            DataContext = p;
        }

        void OnOnionsSelect(object sender, EventArgs e)
        {
            if (OnionsSelect.IsChecked == false) OnionsSelect.IsChecked = false;
            else OnionsSelect.IsChecked = true;
            p.Onion = (bool)OnionsSelect.IsChecked;
            DataContext = p;
        }

        void OnRollSelect(object sender, EventArgs e)
        {
            if (RollSelect.IsChecked == false) RollSelect.IsChecked = false;
            else RollSelect.IsChecked = true;
            p.Roll = (bool)RollSelect.IsChecked;
            DataContext = p;
        }
    }
}
