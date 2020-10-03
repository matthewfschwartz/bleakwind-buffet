/*
 * Author: Matthew Schwartz
 * Class name: CustomizeBriarheartBurger.xaml.cs
 * Purpose: Initializes the customization view for briarheart burger and allows navigation back to the select entrees view
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeBriarheartBurger.xaml
    /// </summary>
    public partial class CustomizeBriarheartBurger : UserControl
    {
        BriarheartBurger b = new BriarheartBurger();
        public CustomizeBriarheartBurger()
        {
            InitializeComponent();
            DataContext = new BriarheartBurger();
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
            b.Bun = (bool)BunSelect.IsChecked;
            DataContext = b;
        }

        void OnKetchupSelect(object sender, EventArgs e)
        {
            if (KetchupSelect.IsChecked == false) KetchupSelect.IsChecked = false;
            else KetchupSelect.IsChecked = true;
            b.Bun = (bool)KetchupSelect.IsChecked;
            DataContext = b;
        }

        void OnMustardSelect(object sender, EventArgs e)
        {
            if (MustardSelect.IsChecked == false) MustardSelect.IsChecked = false;
            else MustardSelect.IsChecked = true;
            b.Bun = (bool)MustardSelect.IsChecked;
            DataContext = b;
        }

        void OnPickleSelect(object sender, EventArgs e)
        {
            if (PickleSelect.IsChecked == false) PickleSelect.IsChecked = false;
            else PickleSelect.IsChecked = true;
            b.Bun = (bool)PickleSelect.IsChecked;
            DataContext = b;
        }

        void OnCheeseSelect(object sender, EventArgs e)
        {
            if (CheeseSelect.IsChecked == false) CheeseSelect.IsChecked = false;
            else CheeseSelect.IsChecked = true;
            b.Bun = (bool)CheeseSelect.IsChecked;
            DataContext = b;
        }


    }
}
