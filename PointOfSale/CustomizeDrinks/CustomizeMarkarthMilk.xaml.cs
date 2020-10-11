/*
 * Author: Matthew Schwartz
 * Class name: CustomizeMarkarthMilk.xaml.cs
 * Purpose: Initializes the customization view for markarth milk and allows navigation back to the select drinks view
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
    /// Interaction logic for CustomizeMarkarthMilk.xaml
    /// </summary>
    public partial class CustomizeMarkarthMilk : UserControl
    {
        private MarkarthMilk m;
        ComboMeal c;
        public CustomizeMarkarthMilk(MarkarthMilk MM, bool isCombo)
        {
            InitializeComponent();
            DataContext = MM;
            m = MM;
            IsCombo = isCombo;
        }

        public CustomizeMarkarthMilk(MarkarthMilk MM, ComboMeal CM, bool isCombo)
        {
            InitializeComponent();
            DataContext = MM;
            m = MM;
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
