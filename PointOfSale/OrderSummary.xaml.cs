/*
 * Author: Matthew Schwartz
 * Class name: OrderSummary.xaml.cs
 * Purpose: Displays the list of items on each order and the total price of the order
 * Gives the user an option to return to the main menu at any point during their shopping experience
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.CustomizeDrinks;
using PointOfSale.CustomizeEntrees;
using PointOfSale.CustomizeSides;
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
    /// Interaction logic for OrderSummary.xaml
    /// </summary>
    public partial class OrderSummary : UserControl
    {
        /// <summary>
        /// Constructor for OrderSummary class
        /// </summary>
        public OrderSummary()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the user wants to return to the main menu
        /// Should take them back to the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuSelection main = new MainMenuSelection();
            OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
            orderComponent.Swap(main);
        }

        /// <summary>
        /// Event handler for if the user finishes their order
        /// Should clear order summary and order number should increment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnFinishClick(object sender, RoutedEventArgs e)
        {
            PaymentOptions pay = new PaymentOptions();
            OrderComponent orderComponent = this.FindAncestor<OrderComponent>(); // Find the Order Component that is a parent of the current order summary
            orderComponent.Swap(pay);
        }

        /// <summary>
        /// Event handler for if the user cancels the order
        /// Should clear order summary and retain the same order number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCancelClick(object sender, RoutedEventArgs e)
        {
            Order newOrder = new Order();
            MainMenuSelection main = new MainMenuSelection();
            OrderComponent orderComponent = this.FindAncestor<OrderComponent>(); // Find the Order Component that is a parent of the current order summary
            orderComponent.DataContext = newOrder; // Set the data context of the order component to be the new order
            orderComponent.Swap(main);
        }

        /// <summary>
        /// Event for when a user wants to remvoe an item from their order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRemoveClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var itemToRemove = (IOrderItem)orderList.SelectedItem;
                order.Remove(itemToRemove);
            }
        }

        /// <summary>
        /// Event for when the user wants to customize an item that is already in their order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCustomizeClick(object sender, RoutedEventArgs e)
        {
            var item = orderList.SelectedItem;
            if (item is ComboMeal combo)
            {
                CustomizeComboMeal custom = new CustomizeComboMeal(combo);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            else if (item is Drink drink)
            {
                if (drink is AretinoAppleJuice a)
                {
                    CustomizeAretinoAppleJuice custom = new CustomizeAretinoAppleJuice(a, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (drink is MarkarthMilk m)
                {
                    CustomizeMarkarthMilk custom = new CustomizeMarkarthMilk(m, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (drink is CandlehearthCoffee c)
                {
                    CustomizeCandlehearthCoffee custom = new CustomizeCandlehearthCoffee(c, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (drink is SailorSoda s)
                {
                    CustomizeSailorSoda custom = new CustomizeSailorSoda(s, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (drink is WarriorWater w)
                {
                    CustomizeWarriorWater custom = new CustomizeWarriorWater(w, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
            }

            else if (item is Entree entree)
            {
                if (entree is BriarheartBurger b)
                {
                    CustomizeBriarheartBurger custom = new CustomizeBriarheartBurger(b, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (entree is DoubleDraugr d)
                {
                    CustomizeDoubleDraugr custom = new CustomizeDoubleDraugr(d, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (entree is ThalmorTriple t)
                {
                    CustomizeThalmorTriple custom = new CustomizeThalmorTriple(t, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (entree is GardenOrcOmelette g)
                {
                    CustomizeGardenOrcOmelette custom = new CustomizeGardenOrcOmelette(g, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (entree is ThugsTBone tb)
                {
                    CustomizeThugsTBone custom = new CustomizeThugsTBone(tb, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (entree is SmokehouseSkeleton s)
                {
                    CustomizeSmokehouseSkeleton custom = new CustomizeSmokehouseSkeleton(s, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (entree is PhillyPoacher p)
                {
                    CustomizePhillyPoacher custom = new CustomizePhillyPoacher(p, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
            }
            else if (item is Side side)
            {
                if (side is DragonbornWaffleFries d)
                {
                    CustomizeDragonbornWaffleFries custom = new CustomizeDragonbornWaffleFries(d, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (side is FriedMiraak f)
                {
                    CustomizeFriedMiraak custom = new CustomizeFriedMiraak(f, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (side is MadOtarGrits m)
                {
                    CustomizeMadOtarGrits custom = new CustomizeMadOtarGrits(m, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
                else if (side is VokunSalad v)
                {
                    CustomizeVokunSalad custom = new CustomizeVokunSalad(v, false);
                    OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                    orderComponent.Swap(custom);
                }
            }
        }
    }
}
