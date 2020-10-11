/*
 * Author: Matthew Schwartz
 * Class name: CustomizeCandlehearthCoffee.xaml.cs
 * Purpose: Initializes the customization view for candlehearth coffee and allows navigation back to the select drinks view
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
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
using Size = BleakwindBuffet.Data.Enums.Size;

namespace PointOfSale.CustomizeDrinks
{
    /// <summary>
    /// Interaction logic for CustomizeCandlehearthCoffee.xaml
    /// </summary>
    public partial class CustomizeCandlehearthCoffee : UserControl
    {
        private CandlehearthCoffee c;
        ComboMeal cm;
        public CustomizeCandlehearthCoffee(CandlehearthCoffee CC, bool isCombo)
        {
            InitializeComponent();
            DataContext = CC;
            c = CC;
            IsCombo = isCombo;
        }

        public CustomizeCandlehearthCoffee(CandlehearthCoffee CC, ComboMeal CM, bool isCombo)
        {
            InitializeComponent();
            DataContext = CC;
            c = CC;
            IsCombo = isCombo;
            cm = CM;
        }

        public bool IsCombo { get; set; } = false;

        void ClickDone(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {
                CustomizeComboMeal custom = new CustomizeComboMeal(cm);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            else
            {
                SelectDrinks custom = new SelectDrinks();
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }
    }
}
