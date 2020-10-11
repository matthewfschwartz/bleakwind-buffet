/*
 * Author: Matthew Schwartz
 * Class name: SelectSides.xaml.cs
 * Purpose: Displays all side options that the user can choose from.
 * Allows the user to click into each side option for customizability.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
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
        ComboMeal c;
        public SelectSides()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for when we are selecting a side for the combo box
        /// </summary>
        /// <param name="CM">The combo meal being passed in</param>
        /// <param name="isCombo">boolean representing whether this is a combo meal or not</param>
        public SelectSides(ComboMeal CM, bool isCombo)
        {
            InitializeComponent();
            DataContext = CM;
            c = CM;
            IsCombo = isCombo;
        }

        public bool IsCombo { get; set; } = false;

        void AddVokunSalad(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {

                c.Side = new VokunSalad();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                VokunSalad v = new VokunSalad();
                order.Add(v);
                CustomizeVokunSalad custom = new CustomizeVokunSalad(v, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        void AddFriedMiraak(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {

                c.Side = new FriedMiraak();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                FriedMiraak f = new FriedMiraak();
                order.Add(f);
                CustomizeFriedMiraak custom = new CustomizeFriedMiraak(f, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        void AddMadOtarGrits(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {

                c.Side = new MadOtarGrits();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                MadOtarGrits m = new MadOtarGrits();
                order.Add(m);
                CustomizeMadOtarGrits custom = new CustomizeMadOtarGrits(m, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        void AddDragonbornFries(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {

                c.Side = new DragonbornWaffleFries();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                DragonbornWaffleFries d = new DragonbornWaffleFries();
                order.Add(d);
                CustomizeDragonbornWaffleFries custom = new CustomizeDragonbornWaffleFries(d, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }
    }
}
