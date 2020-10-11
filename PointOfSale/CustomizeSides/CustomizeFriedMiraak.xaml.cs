/*
 * Author: Matthew Schwartz
 * Class name: CustomizeFriedMiraak.xaml.cs
 * Purpose: Initializes the customization view for fried miraak and allows navigation back to the select sides view
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
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

namespace PointOfSale.CustomizeSides
{
    /// <summary>
    /// Interaction logic for CustomizeFriedMiraak.xaml
    /// </summary>
    public partial class CustomizeFriedMiraak : UserControl
    {
        FriedMiraak f;
        ComboMeal c;
        public CustomizeFriedMiraak(FriedMiraak FM, bool isCombo)
        {
            InitializeComponent();
            DataContext = FM;
            f = FM;
            IsCombo = isCombo;
        }

        public CustomizeFriedMiraak(FriedMiraak FM, ComboMeal CM, bool isCombo)
        {
            InitializeComponent();
            DataContext = FM;
            f = FM;
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
                SelectSides custom = new SelectSides();
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }
    }
}
