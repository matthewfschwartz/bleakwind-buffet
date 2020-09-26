/*
 * Author: Matthew Schwartz
 * Class name: SelectDrinks.xaml.cs
 * Purpose: Displays all drink options that the user can choose from.
 * Allows the user to click into each drink option for customizability.
 */

using PointOfSale.CustomizeDrinks;
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
    /// Interaction logic for SelectDrinks.xaml
    /// </summary>
    public partial class SelectDrinks : UserControl
    {
        private int sailorSodaCount = 0;
        private int aretinoAppleJuiceCount = 0;
        private int candlehearthCoffeeCount = 0;
        private int warriorWaterCount = 0;
        private int markarthMilkCount = 0;

        public SelectDrinks()
        {
            InitializeComponent();
        }

        void CustomizeSailorSoda(object sender, RoutedEventArgs e)
        {
            CustomizeSailorSoda custom = new CustomizeSailorSoda();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void CustomizeAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            CustomizeAretinoAppleJuice custom = new CustomizeAretinoAppleJuice();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void CustomizeMarkarthMilk(object sender, RoutedEventArgs e)
        {
            CustomizeMarkarthMilk custom = new CustomizeMarkarthMilk();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void CustomizeCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            CustomizeCandlehearthCoffee custom = new CustomizeCandlehearthCoffee();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void CustomizeWarriorWater(object sender, RoutedEventArgs e)
        {
            CustomizeWarriorWater custom = new CustomizeWarriorWater();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void AddSailorSoda(object sender, RoutedEventArgs e)
        {
            sailorSodaCount++;
            sailorSodaQuantityTextBox.Text = sailorSodaCount.ToString();
        }

        void RemoveSailorSoda(object sender, RoutedEventArgs e)
        {
            if (sailorSodaCount > 0) sailorSodaCount--;
            sailorSodaQuantityTextBox.Text = sailorSodaCount.ToString();
        }

        void AddMarkarthMilk(object sender, RoutedEventArgs e)
        {
            markarthMilkCount++;
            markarthMilkQuantityTextBox.Text = markarthMilkCount.ToString();
        }

        void RemoveMarkarthMilk(object sender, RoutedEventArgs e)
        {
            if (markarthMilkCount > 0) markarthMilkCount--;
            markarthMilkQuantityTextBox.Text = markarthMilkCount.ToString();
        }

        void AddAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            aretinoAppleJuiceCount++;
            aretinoAppleJuiceQuantityTextBox.Text = aretinoAppleJuiceCount.ToString();
        }

        void RemoveAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            if (aretinoAppleJuiceCount > 0) aretinoAppleJuiceCount--;
            aretinoAppleJuiceQuantityTextBox.Text = aretinoAppleJuiceCount.ToString();
        }

        void AddWarriorWater(object sender, RoutedEventArgs e)
        {
            warriorWaterCount++;
            warriorWaterQuantityTextBox.Text = warriorWaterCount.ToString();
        }

        void RemoveWarriorWater(object sender, RoutedEventArgs e)
        {
            if (warriorWaterCount > 0) warriorWaterCount--;
            warriorWaterQuantityTextBox.Text = warriorWaterCount.ToString();
        }

        void AddCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            candlehearthCoffeeCount++;
            candlehearthCoffeeQuantityTextBox.Text = candlehearthCoffeeCount.ToString();
        }

        void RemoveCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            if (candlehearthCoffeeCount > 0) candlehearthCoffeeCount--;
            candlehearthCoffeeQuantityTextBox.Text = candlehearthCoffeeCount.ToString();
        }
    }
}
