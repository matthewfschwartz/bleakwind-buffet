/*
 * Author: Matthew Schwartz
 * Class name: SelectEntrees.xaml.cs
 * Purpose: Displays all entree options that the user can choose from.
 * Allows the user to click into each entree option for customizability.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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
        ComboMeal c;
        public SelectEntrees()
        {
            InitializeComponent();
        }

        public SelectEntrees(ComboMeal CM, bool isCombo)
        {
            InitializeComponent();
            DataContext = CM;
            c = CM;
            IsCombo = isCombo;
        }

        public bool IsCombo { get; set; }

        void AddBriarheartBurger(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {
                
                c.Entree = new DoubleDraugr();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                BriarheartBurger b = new BriarheartBurger();
                order.Add(b);
                CustomizeBriarheartBurger custom = new CustomizeBriarheartBurger(b, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            
        }

        void AddDoubleDraugr(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {
                c.Entree = new DoubleDraugr();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            else if (DataContext is Order order)
            {
                DoubleDraugr d = new DoubleDraugr();
                order.Add(d);
                CustomizeDoubleDraugr custom = new CustomizeDoubleDraugr(d, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        void AddThalmorTriple(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {
                c.Entree = new ThalmorTriple();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                ThalmorTriple t = new ThalmorTriple();
                order.Add(t);
                CustomizeThalmorTriple custom = new CustomizeThalmorTriple(t, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        void AddSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {
                c.Entree = new SmokehouseSkeleton();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                SmokehouseSkeleton s = new SmokehouseSkeleton();
                order.Add(s);
                CustomizeSmokehouseSkeleton custom = new CustomizeSmokehouseSkeleton(s, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        void AddGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {
                c.Entree = new GardenOrcOmelette();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                GardenOrcOmelette g = new GardenOrcOmelette();
                order.Add(g);
                CustomizeGardenOrcOmelette custom = new CustomizeGardenOrcOmelette(g, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        void AddPhillyPoacher(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {
                c.Entree = new PhillyPoacher();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                PhillyPoacher p = new PhillyPoacher();
                order.Add(p);
                CustomizePhillyPoacher custom = new CustomizePhillyPoacher(p, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        void AddThugsTBone(object sender, RoutedEventArgs e)
        {
            if (IsCombo)
            {
                c.Entree = new ThugsTBone();
                CustomizeComboMeal custom = new CustomizeComboMeal(c);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            if (DataContext is Order order)
            {
                ThugsTBone t = new ThugsTBone();
                order.Add(t);
                CustomizeThugsTBone custom = new CustomizeThugsTBone(t, false);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }
    }
}
