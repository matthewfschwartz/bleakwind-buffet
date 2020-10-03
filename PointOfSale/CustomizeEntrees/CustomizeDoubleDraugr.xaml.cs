/*
 * Author: Matthew Schwartz
 * Class name: CustomizeDoubleDraugr.xaml.cs
 * Purpose: Initializes the customization view for double draugr and allows navigation back to the select entrees view
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
    /// Interaction logic for CustomizeDoubleDraugr.xaml
    /// </summary>
    public partial class CustomizeDoubleDraugr : UserControl
    {
        DoubleDraugr d = new DoubleDraugr();
        public CustomizeDoubleDraugr()
        {
            InitializeComponent();
            DataContext = new DoubleDraugr();
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
            d.Bun = (bool)BunSelect.IsChecked;
            DataContext = d;
        }

        void OnKetchupSelect(object sender, EventArgs e)
        {
            if (KetchupSelect.IsChecked == false) KetchupSelect.IsChecked = false;
            else KetchupSelect.IsChecked = true;
            d.Bun = (bool)KetchupSelect.IsChecked;
            DataContext = d;
        }

        void OnMustardSelect(object sender, EventArgs e)
        {
            if (MustardSelect.IsChecked == false) MustardSelect.IsChecked = false;
            else MustardSelect.IsChecked = true;
            d.Bun = (bool)MustardSelect.IsChecked;
            DataContext = d;
        }

        void OnPickleSelect(object sender, EventArgs e)
        {
            if (PickleSelect.IsChecked == false) PickleSelect.IsChecked = false;
            else PickleSelect.IsChecked = true;
            d.Bun = (bool)PickleSelect.IsChecked;
            DataContext = d;
        }

        void OnCheeseSelect(object sender, EventArgs e)
        {
            if (CheeseSelect.IsChecked == false) CheeseSelect.IsChecked = false;
            else CheeseSelect.IsChecked = true;
            d.Bun = (bool)CheeseSelect.IsChecked;
            DataContext = d;
        }

        void OnLettuceSelect(object sender, EventArgs e)
        {
            if (LettuceSelect.IsChecked == false) LettuceSelect.IsChecked = false;
            else LettuceSelect.IsChecked = true;
            d.Bun = (bool)LettuceSelect.IsChecked;
            DataContext = d;
        }

        void OnTomatoSelect(object sender, EventArgs e)
        {
            if (TomatoSelect.IsChecked == false) TomatoSelect.IsChecked = false;
            else TomatoSelect.IsChecked = true;
            d.Bun = (bool)TomatoSelect.IsChecked;
            DataContext = d;
        }

        void OnMayoSelect(object sender, EventArgs e)
        {
            if (MayoSelect.IsChecked == false) MayoSelect.IsChecked = false;
            else MayoSelect.IsChecked = true;
            d.Bun = (bool)MayoSelect.IsChecked;
            DataContext = d;
        }
    }
}
