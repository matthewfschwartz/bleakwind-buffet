/*
 * Author: Matthew Schwartz
 * Class name: CustomizeThugsTBone.xaml.cs
 * Purpose: Initializes the customization view for thugs tbone and allows navigation back to the select entrees view
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

namespace PointOfSale.CustomizeEntrees
{
    /// <summary>
    /// Interaction logic for CustomizeThugsTBone.xaml
    /// </summary>
    public partial class CustomizeThugsTBone : UserControl
    {
        public CustomizeThugsTBone()
        {
            InitializeComponent();
        }
        void ClickDone(object sender, RoutedEventArgs e)
        {
            SelectEntrees custom = new SelectEntrees();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }
    }
}
