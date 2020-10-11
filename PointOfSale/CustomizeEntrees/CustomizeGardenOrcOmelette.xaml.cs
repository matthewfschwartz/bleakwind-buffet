/*
 * Author: Matthew Schwartz
 * Class name: CustomizeGardenOrcOmelette.xaml.cs
 * Purpose: Initializes the customization view for garden orc omelette and allows navigation back to the select entrees view
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
    /// Interaction logic for CustomizeGardenOrcOmelette.xaml
    /// </summary>
    public partial class CustomizeGardenOrcOmelette : UserControl
    {
        GardenOrcOmelette g;
        ComboMeal c;
        public CustomizeGardenOrcOmelette(GardenOrcOmelette GOO, bool isCombo)
        {
            InitializeComponent();
            DataContext = GOO;
            g = GOO;
            IsCombo = isCombo;
        }

        public CustomizeGardenOrcOmelette(GardenOrcOmelette GOO, ComboMeal CM, bool isCombo)
        {
            InitializeComponent();
            DataContext = GOO;
            g = GOO;
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
