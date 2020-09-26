/*
 * Author: Matthew Schwartz
 * Class name: SelectSides.xaml.cs
 * Purpose: Displays all side options that the user can choose from.
 * Allows the user to click into each side option for customizability.
 */

using PointOfSale.CustomizeSides;
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
    /// Interaction logic for SelectSides.xaml
    /// </summary>
    public partial class SelectSides : UserControl
    {
        private int vokunSaladCount = 0;
        private int friedMiraakCount = 0;
        private int madOtarGritsCount = 0;
        private int dragonbornFriesCount = 0;

        public SelectSides()
        {
            InitializeComponent();
        }

        void CustomizeVokunSalad(object sender, RoutedEventArgs e)
        {
            CustomizeVokunSalad custom = new CustomizeVokunSalad();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }
        void CustomizeFriedMiraak(object sender, RoutedEventArgs e)
        {
            CustomizeFriedMiraak custom = new CustomizeFriedMiraak();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }
        void CustomizeMadOtarGrits(object sender, RoutedEventArgs e)
        {
            CustomizeMadOtarGrits custom = new CustomizeMadOtarGrits();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }
        void CustomizeDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            CustomizeDragonbornWaffleFries custom = new CustomizeDragonbornWaffleFries();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void AddVokunSalad(object sender, RoutedEventArgs e)
        {
            vokunSaladCount++;
            vokunSaladQuantityTextBox.Text = vokunSaladCount.ToString();
        }

        void RemoveVokunSalad(object sender, RoutedEventArgs e)
        {
            if (vokunSaladCount > 0) vokunSaladCount--;
            vokunSaladQuantityTextBox.Text = vokunSaladCount.ToString();
        }

        void AddFriedMiraak(object sender, RoutedEventArgs e)
        {
            friedMiraakCount++;
            friedMiraakQuantityTextBox.Text = friedMiraakCount.ToString();
        }

        void RemoveFriedMiraak(object sender, RoutedEventArgs e)
        {
            if (friedMiraakCount > 0) friedMiraakCount--;
            friedMiraakQuantityTextBox.Text = friedMiraakCount.ToString();
        }

        void AddMadOtarGrits(object sender, RoutedEventArgs e)
        {
            madOtarGritsCount++;
            madOtarGritsQuantityTextBox.Text = madOtarGritsCount.ToString();
        }

        void RemoveMadOtarGrits(object sender, RoutedEventArgs e)
        {
            if (madOtarGritsCount > 0) madOtarGritsCount--;
            madOtarGritsQuantityTextBox.Text = madOtarGritsCount.ToString();
        }

        void AddDragonbornFries(object sender, RoutedEventArgs e)
        {
            dragonbornFriesCount++;
            dragonbornFriesQuantityTextBox.Text = dragonbornFriesCount.ToString();
        }

        void RemoveDragonbornFries(object sender, RoutedEventArgs e)
        {
            if (dragonbornFriesCount > 0) dragonbornFriesCount--;
            dragonbornFriesQuantityTextBox.Text = dragonbornFriesCount.ToString();
        }
    }
}
