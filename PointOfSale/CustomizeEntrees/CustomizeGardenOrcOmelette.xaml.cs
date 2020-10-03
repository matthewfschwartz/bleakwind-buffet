/*
 * Author: Matthew Schwartz
 * Class name: CustomizeGardenOrcOmelette.xaml.cs
 * Purpose: Initializes the customization view for garden orc omelette and allows navigation back to the select entrees view
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
    /// Interaction logic for CustomizeGardenOrcOmelette.xaml
    /// </summary>
    public partial class CustomizeGardenOrcOmelette : UserControl
    {
        GardenOrcOmelette g = new GardenOrcOmelette();
        public CustomizeGardenOrcOmelette()
        {
            InitializeComponent();
            DataContext = new GardenOrcOmelette();
        }
        void ClickDone(object sender, RoutedEventArgs e)
        {
            SelectEntrees custom = new SelectEntrees();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
            
        }

        void OnBroccoliSelect(object sender, EventArgs e)
        {
            if (BroccoliSelect.IsChecked == false) BroccoliSelect.IsChecked = false;
            else BroccoliSelect.IsChecked = true;
            g.Broccoli = (bool)BroccoliSelect.IsChecked;
            DataContext = g;
        }

        void OnMushroomsSelect(object sender, EventArgs e)
        {
            if (MushroomsSelect.IsChecked == false) MushroomsSelect.IsChecked = false;
            else MushroomsSelect.IsChecked = true;
            g.Broccoli = (bool)MushroomsSelect.IsChecked;
            DataContext = g;
        }

        void OnTomatoSelect(object sender, EventArgs e)
        {
            if (TomatoSelect.IsChecked == false) TomatoSelect.IsChecked = false;
            else TomatoSelect.IsChecked = true;
            g.Broccoli = (bool)TomatoSelect.IsChecked;
            DataContext = g;
        }

        void OnCheddarSelect(object sender, EventArgs e)
        {
            if (CheddarSelect.IsChecked == false) CheddarSelect.IsChecked = false;
            else CheddarSelect.IsChecked = true;
            g.Broccoli = (bool)CheddarSelect.IsChecked;
            DataContext = g;
        }
    }
}
