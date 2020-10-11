/*
 * Author: Matthew Schwartz
 * Class name: CustomizeThugsTBone.xaml.cs
 * Purpose: Initializes the customization view for thugs tbone and allows navigation back to the select entrees view
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
    /// Interaction logic for CustomizeThugsTBone.xaml
    /// </summary>
    public partial class CustomizeThugsTBone : UserControl
    {
        private ThugsTBone t;
        ComboMeal c;
        public CustomizeThugsTBone(ThugsTBone TT, bool isCombo)
        {
            InitializeComponent();
            DataContext = TT;
            t = TT;
            IsCombo = isCombo;
        }

        public CustomizeThugsTBone(ThugsTBone TT, ComboMeal CM, bool isCombo)
        {
            InitializeComponent();
            DataContext = TT;
            t = TT;
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
