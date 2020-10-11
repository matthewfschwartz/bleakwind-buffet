/*
 * Author: Matthew Schwartz
 * Class name: SelectDrinks.xaml.cs
 * Purpose: Displays all drink options that the user can choose from.
 * Allows the user to click into each drink option for customizability.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
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
        ComboMeal c;
        public SelectDrinks()
        {
            InitializeComponent();
        }

        public SelectDrinks(ComboMeal CM, bool isCombo)
        {
            InitializeComponent();
            DataContext = CM;
            c = CM;
            IsCombo = isCombo;
        }

        public bool IsCombo { get; set; } = false;

        void AddSailorSoda(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {

                c.Drink = new SailorSoda();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                SailorSoda s = new SailorSoda();
                order.Add(s);
                CustomizeSailorSoda custom = new CustomizeSailorSoda(s, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        void AddMarkarthMilk(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {

                c.Drink = new MarkarthMilk();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                MarkarthMilk m = new MarkarthMilk();
                order.Add(m);
                CustomizeMarkarthMilk custom = new CustomizeMarkarthMilk(m, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        void AddAretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {

                c.Drink = new AretinoAppleJuice();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                AretinoAppleJuice a = new AretinoAppleJuice();
                order.Add(a);
                CustomizeAretinoAppleJuice custom = new CustomizeAretinoAppleJuice(a, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        void AddWarriorWater(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {

                c.Drink = new WarriorWater();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                WarriorWater w = new WarriorWater();
                order.Add(w);
                CustomizeWarriorWater custom = new CustomizeWarriorWater(w, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        void AddCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {

                c.Drink = new CandlehearthCoffee();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                CandlehearthCoffee c = new CandlehearthCoffee();
                order.Add(c);
                CustomizeCandlehearthCoffee custom = new CustomizeCandlehearthCoffee(c, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }
    }
}
