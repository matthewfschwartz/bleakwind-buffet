/*
 * Author: Matthew Schwartz
 * Class name: CustomizeSmokehouseSkeleton.xaml.cs
 * Purpose: Initializes the customization view for smokehouse skeleton and allows navigation back to the select entrees view
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
    /// Interaction logic for CustomizeSmokehouseSkeleton.xaml
    /// </summary>
    public partial class CustomizeSmokehouseSkeleton : UserControl
    {
        SmokehouseSkeleton s = new SmokehouseSkeleton();
        public CustomizeSmokehouseSkeleton()
        {
            InitializeComponent();
            DataContext = new SmokehouseSkeleton();
        }
        void ClickDone(object sender, RoutedEventArgs e)
        {
            SelectEntrees custom = new SelectEntrees();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
           
        }

        void OnSausageSelect(object sender, EventArgs e)
        {
            if (SausageSelect.IsChecked == false) SausageSelect.IsChecked = false;
            else SausageSelect.IsChecked = true;
            s.SausageLink = (bool)SausageSelect.IsChecked;
            DataContext = s;
        }

        void OnEggsSelect(object sender, EventArgs e)
        {
            if (EggSelect.IsChecked == false) EggSelect.IsChecked = false;
            else EggSelect.IsChecked = true;
            s.Egg = (bool)EggSelect.IsChecked;
            DataContext = s;
        }

        void OnHashbrownsSelect(object sender, EventArgs e)
        {
            if (HashbrownsSelect.IsChecked == false) HashbrownsSelect.IsChecked = false;
            else HashbrownsSelect.IsChecked = true;
            s.HashBrowns = (bool)HashbrownsSelect.IsChecked;
            DataContext = s;
        }

        void OnPancakesSelect(object sender, EventArgs e)
        {
            if (PancakesSelect.IsChecked == false) PancakesSelect.IsChecked = false;
            else PancakesSelect.IsChecked = true;
            s.Pancake = (bool)PancakesSelect.IsChecked;
            DataContext = s;
        }
    }
}
