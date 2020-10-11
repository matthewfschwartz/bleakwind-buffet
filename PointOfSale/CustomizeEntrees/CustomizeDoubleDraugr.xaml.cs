/*
 * Author: Matthew Schwartz
 * Class name: CustomizeDoubleDraugr.xaml.cs
 * Purpose: Initializes the customization view for double draugr and allows navigation back to the select entrees view
 */

using BleakwindBuffet.Data;
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
    /// Interaction logic for CustomizeDoubleDraugr.xaml
    /// </summary>
    public partial class CustomizeDoubleDraugr : UserControl
    {
        DoubleDraugr d;
        ComboMeal c;
        public CustomizeDoubleDraugr(DoubleDraugr DD, bool isCombo)
        {
            InitializeComponent();
            DataContext = DD;
            d = DD;
            IsCombo = isCombo;
        }

        public CustomizeDoubleDraugr(DoubleDraugr DD, ComboMeal CM, bool isCombo)
        {
            InitializeComponent();
            DataContext = DD;
            d = DD;
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
                SelectEntrees custom = new SelectEntrees();
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }

        }
    }
}
