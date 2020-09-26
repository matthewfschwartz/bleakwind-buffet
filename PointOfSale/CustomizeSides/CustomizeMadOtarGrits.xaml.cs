/*
 * Author: Matthew Schwartz
 * Class name: CustomizeMadOtarGrits.xaml.cs
 * Purpose: Initializes the customization view for mad otar grits and allows navigation back to the select sides view
 */

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

namespace PointOfSale.CustomizeSides
{
    /// <summary>
    /// Interaction logic for CustomizeMadOtarGrits.xaml
    /// </summary>
    public partial class CustomizeMadOtarGrits : UserControl
    {
        public CustomizeMadOtarGrits()
        {
            InitializeComponent();
        }
        void ClickDone(object sender, RoutedEventArgs e)
        {
            SelectSides custom = new SelectSides();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }
    }
}
