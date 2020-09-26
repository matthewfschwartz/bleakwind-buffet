/*
 * Author: Matthew Schwartz
 * Class name: SelectEntrees.xaml.cs
 * Purpose: Displays all entree options that the user can choose from.
 * Allows the user to click into each entree option for customizability.
 */

using PointOfSale.CustomizeEntrees;
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
    /// Interaction logic for SelectEntrees.xaml
    /// </summary>
    public partial class SelectEntrees : UserControl
    {
        private int burgerCount = 0;
        private int doubleCount = 0;
        private int tripleCount = 0;
        private int skelCount = 0;
        private int gardenCount = 0;
        private int phillyCount = 0;
        private int tboneCount = 0;
        public SelectEntrees()
        {
            InitializeComponent();
        }

        void CustomizeBriarheartBurger(object sender, RoutedEventArgs e)
        {
            CustomizeBriarheartBurger custom = new CustomizeBriarheartBurger();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void CustomizeDoubleDraugr(object sender, RoutedEventArgs e)
        {
            CustomizeDoubleDraugr custom = new CustomizeDoubleDraugr();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void CustomizeThalmorTriple(object sender, RoutedEventArgs e)
        {
            CustomizeThalmorTriple custom = new CustomizeThalmorTriple();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void CustomizeSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            CustomizeSmokehouseSkeleton custom = new CustomizeSmokehouseSkeleton();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void CustomizeGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            CustomizeGardenOrcOmelette custom = new CustomizeGardenOrcOmelette();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void CustomizePhillyPoacher(object sender, RoutedEventArgs e)
        {
            CustomizePhillyPoacher custom = new CustomizePhillyPoacher();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void CustomizeThugsTBone(object sender, RoutedEventArgs e)
        {
            CustomizeThugsTBone custom = new CustomizeThugsTBone();
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void AddBriarheartBurger(object sender, RoutedEventArgs e)
        {
            burgerCount++;
            briarheartQuantityTextBox.Text = burgerCount.ToString();
        }

        void RemoveBriarheartBurger(object sender, RoutedEventArgs e)
        {
            if (burgerCount > 0) burgerCount--;
            briarheartQuantityTextBox.Text = burgerCount.ToString();
        }

        void AddDoubleDraugr(object sender, RoutedEventArgs e)
        {
            doubleCount++;
            draugrQuantityTextBox.Text = doubleCount.ToString();
        }

        void RemoveDoubleDraugr(object sender, RoutedEventArgs e)
        {
            if (doubleCount > 0) doubleCount--;
            draugrQuantityTextBox.Text = doubleCount.ToString();
        }

        void AddThalmorTriple(object sender, RoutedEventArgs e)
        {
            tripleCount++;
            thalmorQuantityTextBox.Text = tripleCount.ToString();
        }

        void RemoveThalmorTriple(object sender, RoutedEventArgs e)
        {
            if (tripleCount > 0) tripleCount--;
            thalmorQuantityTextBox.Text = tripleCount.ToString();
        }

        void AddSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            skelCount++;
            skelQuantityTextBox.Text = skelCount.ToString();
        }

        void RemoveSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            if (skelCount > 0) skelCount--;
            skelQuantityTextBox.Text = skelCount.ToString();
        }

        void AddGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            gardenCount++;
            gardenQuantityTextBox.Text = gardenCount.ToString();
        }

        void RemoveGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            if (gardenCount > 0) gardenCount--;
            gardenQuantityTextBox.Text = gardenCount.ToString();
        }

        void AddPhillyPoacher(object sender, RoutedEventArgs e)
        {
            phillyCount++;
            phillyQuantityTextBox.Text = phillyCount.ToString();
        }

        void RemovePhillyPoacher(object sender, RoutedEventArgs e)
        {
            if (phillyCount > 0) phillyCount--;
            phillyQuantityTextBox.Text = phillyCount.ToString();
        }

        void AddThugsTBone(object sender, RoutedEventArgs e)
        {
            tboneCount++;
            tboneQuantityTextBox.Text = tboneCount.ToString();
        }

        void RemoveThugsTBone(object sender, RoutedEventArgs e)
        {
            if (tboneCount > 0) tboneCount--;
            tboneQuantityTextBox.Text = tboneCount.ToString();
        }
    }
}
