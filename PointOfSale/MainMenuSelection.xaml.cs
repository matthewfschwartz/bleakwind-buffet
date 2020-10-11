/*
 * Author: Matthew Schwartz
 * Class name: MainMenuSelection.xaml.cs
 * Purpose: Helps create the main menu view that shows options to view entrees, sides, or drink options in more detail.
 * Swaps the view accordingly
 */

using BleakwindBuffet.Data;
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
    /// Interaction logic for MainMenuSelection.xaml
    /// </summary>
    public partial class MainMenuSelection : UserControl
    {
        public MainMenuSelection()
        {
            InitializeComponent();
        }
        void ClickEntreesButton(object sender, RoutedEventArgs e)
        {
            SelectEntrees selectEntrees = new SelectEntrees();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(selectEntrees);
        }

        void ClickDrinksButton(object sender, RoutedEventArgs e)
        {
            SelectDrinks selectDrinks = new SelectDrinks();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(selectDrinks);
        }

        void ClickSidesButton(object sender, RoutedEventArgs e)
        {
            SelectSides selectSides = new SelectSides();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(selectSides);
        }

        void ClickComboButton(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                ComboMeal c = new ComboMeal();
                order.Add(c);
                CustomizeComboMeal customizeCombo = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(customizeCombo);
            }
            
        }
    }
}
