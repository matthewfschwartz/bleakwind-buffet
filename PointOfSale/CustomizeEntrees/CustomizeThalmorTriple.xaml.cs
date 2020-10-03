/*
 * Author: Matthew Schwartz
 * Class name: CustomizeThalmorTriple.xaml.cs
 * Purpose: Initializes the customization view for thalmor triple and allows navigation back to the select entrees view
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
    /// Interaction logic for CustomizeThalmorTriple.xaml
    /// </summary>
    public partial class CustomizeThalmorTriple : UserControl
    {
        ThalmorTriple t = new ThalmorTriple();
        public CustomizeThalmorTriple()
        {
            InitializeComponent();
            DataContext = new ThalmorTriple();
        }

        void ClickDone(object sender, RoutedEventArgs e)
        {
            SelectEntrees custom = new SelectEntrees();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
            
        }

        void OnBunSelect(object sender, EventArgs e)
        {
            if (BunSelect.IsChecked == false) BunSelect.IsChecked = false;
            else BunSelect.IsChecked = true;
            t.Bun = (bool)BunSelect.IsChecked;
            DataContext = t;
        }

        void OnKetchupSelect(object sender, EventArgs e)
        {
            if (KetchupSelect.IsChecked == false) KetchupSelect.IsChecked = false;
            else KetchupSelect.IsChecked = true;
            t.Bun = (bool)KetchupSelect.IsChecked;
            DataContext = t;
        }

        void OnMustardSelect(object sender, EventArgs e)
        {
            if (MustardSelect.IsChecked == false) MustardSelect.IsChecked = false;
            else MustardSelect.IsChecked = true;
            t.Bun = (bool)MustardSelect.IsChecked;
            DataContext = t;
        }

        void OnPickleSelect(object sender, EventArgs e)
        {
            if (PickleSelect.IsChecked == false) PickleSelect.IsChecked = false;
            else PickleSelect.IsChecked = true;
            t.Bun = (bool)PickleSelect.IsChecked;
            DataContext = t;
        }

        void OnCheeseSelect(object sender, EventArgs e)
        {
            if (CheeseSelect.IsChecked == false) CheeseSelect.IsChecked = false;
            else CheeseSelect.IsChecked = true;
            t.Bun = (bool)CheeseSelect.IsChecked;
            DataContext = t;
        }

        void OnLettuceSelect(object sender, EventArgs e)
        {
            if (LettuceSelect.IsChecked == false) LettuceSelect.IsChecked = false;
            else LettuceSelect.IsChecked = true;
            t.Bun = (bool)LettuceSelect.IsChecked;
            DataContext = t;
        }

        void OnTomatoSelect(object sender, EventArgs e)
        {
            if (TomatoSelect.IsChecked == false) TomatoSelect.IsChecked = false;
            else TomatoSelect.IsChecked = true;
            t.Bun = (bool)TomatoSelect.IsChecked;
            DataContext = t;
        }

        void OnMayoSelect(object sender, EventArgs e)
        {
            if (MayoSelect.IsChecked == false) MayoSelect.IsChecked = false;
            else MayoSelect.IsChecked = true;
            t.Bun = (bool)MayoSelect.IsChecked;
            DataContext = t;
        }

        void OnBaconSelect(object sender, EventArgs e)
        {
            if (BaconSelect.IsChecked == false) BaconSelect.IsChecked = false;
            else BaconSelect.IsChecked = true;
            t.Bun = (bool)BaconSelect.IsChecked;
            DataContext = t;
        }

        void OnEggSelect(object sender, EventArgs e)
        {
            if (EggSelect.IsChecked == false) EggSelect.IsChecked = false;
            else EggSelect.IsChecked = true;
            t.Bun = (bool)EggSelect.IsChecked;
            DataContext = t;
        }
    }
}
