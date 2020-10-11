/*
 * Author: Matthew Schwartz
 * Class name: CustomizeAretinoAppleJuice.xaml.cs
 * Purpose: Initializes the customization view for aretino apple juice and allows navigation back to the select drinks view
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
    /// Interaction logic for CustomizeAretinoAppleJuice.xaml
    /// </summary>
    public partial class CustomizeAretinoAppleJuice : UserControl
    {
        private AretinoAppleJuice a;
        ComboMeal c;
        public CustomizeAretinoAppleJuice(AretinoAppleJuice AJ, bool isCombo)
        {
            InitializeComponent();
            DataContext = AJ;
            a = AJ;
            IsCombo = isCombo;
        }

        public CustomizeAretinoAppleJuice(AretinoAppleJuice AJ, ComboMeal CM, bool isCombo)
        {
            InitializeComponent();
            DataContext = AJ;
            a = AJ;
            IsCombo = isCombo;
            c = CM;
        }

        public bool IsCombo { get; set; } = false;

        void ClickDone(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
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
