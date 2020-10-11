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
    /// Interaction logic for CustomizeComboMeal.xaml
    /// </summary>
    public partial class CustomizeComboMeal : UserControl
    {
        private ComboMeal combo;
        public CustomizeComboMeal(ComboMeal CM)
        {
            InitializeComponent();
            DataContext = CM;
            combo = CM;
        }

        void ClickDone(object sender, RoutedEventArgs e)
        {
            MainMenuSelection custom = new MainMenuSelection();
            OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
            orderComponent.Swap(custom);
        }

        void ChangeEntreeClick(object sender, RoutedEventArgs e)
        {
            SelectEntrees custom = new SelectEntrees(combo, true);
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void ChangeSideClick(object sender, RoutedEventArgs e)
        {
            SelectSides custom = new SelectSides(combo, true);
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        void ChangeDrinkClick(object sender, RoutedEventArgs e)
        {
            SelectDrinks custom = new SelectDrinks(combo, true);
            OrderComponent order = this.FindAncestor<OrderComponent>();
            order.Swap(custom);
        }

        /// <summary>
        /// Event handler for when the customize entree button is clicked for a combo.
        /// Sends the user to the correct customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeEntreeClick(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is BriarheartBurger b)
            {
                CustomizeBriarheartBurger custom = new CustomizeBriarheartBurger(b, combo, true);
                OrderComponent order = this.FindAncestor<OrderComponent>();
                order.Swap(custom);
            }
            else if (combo.Entree is DoubleDraugr d)
            {
                CustomizeDoubleDraugr custom = new CustomizeDoubleDraugr(d, combo, true);
                OrderComponent order = this.FindAncestor<OrderComponent>();
                order.Swap(custom);
            }
            else if (combo.Entree is ThalmorTriple t)
            {
                CustomizeThalmorTriple custom = new CustomizeThalmorTriple(t, combo, true);
                OrderComponent order = this.FindAncestor<OrderComponent>();
                order.Swap(custom);
            }
            else if (combo.Entree is GardenOrcOmelette g)
            {
                CustomizeGardenOrcOmelette custom = new CustomizeGardenOrcOmelette(g, combo, true);
                OrderComponent order = this.FindAncestor<OrderComponent>();
                order.Swap(custom);
            }
            else if (combo.Entree is ThugsTBone tb)
            {
                CustomizeThugsTBone custom = new CustomizeThugsTBone(tb, combo, true);
                OrderComponent order = this.FindAncestor<OrderComponent>();
                order.Swap(custom);
            }
            else if (combo.Entree is SmokehouseSkeleton s)
            {
                CustomizeSmokehouseSkeleton custom = new CustomizeSmokehouseSkeleton(s, combo, true);
                OrderComponent order = this.FindAncestor<OrderComponent>();
                order.Swap(custom);
            }
            else if (combo.Entree is PhillyPoacher p)
            {
                CustomizePhillyPoacher custom = new CustomizePhillyPoacher(p, combo, true);
                OrderComponent order = this.FindAncestor<OrderComponent>();
                order.Swap(custom);
            }
        }

        /// <summary>
        /// Event handler for when the customize drink button is clicked for a combo
        /// Sends the user to the correct customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeDrinkClick(object sender, RoutedEventArgs e)
        {
            if (combo.Drink is WarriorWater w)
            {
                CustomizeWarriorWater custom = new CustomizeWarriorWater(w, combo, true);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            else if (combo.Drink is SailorSoda s)
            {
                CustomizeSailorSoda custom = new CustomizeSailorSoda(s, combo, true);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            else if (combo.Drink is AretinoAppleJuice a)
            {
                CustomizeAretinoAppleJuice custom = new CustomizeAretinoAppleJuice(a, combo, true);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            else if (combo.Drink is MarkarthMilk m)
            {
                CustomizeMarkarthMilk custom = new CustomizeMarkarthMilk(m, combo, true);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
            else if (combo.Drink is CandlehearthCoffee c)
            {
                CustomizeCandlehearthCoffee custom = new CustomizeCandlehearthCoffee(c, combo, true);
                OrderComponent orderComponent = this.FindAncestor<OrderComponent>();
                orderComponent.Swap(custom);
            }
        }

        /// <summary>
        /// Event handler for when the customize side button is clicked for a combo
        /// Sends the user to the correct customization screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CustomizeSideClick(object sender, RoutedEventArgs e)
        {
            if (combo.Side is DragonbornWaffleFries dwf)
            {
                CustomizeDragonbornWaffleFries custom = new CustomizeDragonbornWaffleFries(dwf, combo, true);
                OrderComponent order = this.FindAncestor<OrderComponent>();
                order.Swap(custom);
            }
            else if (combo.Side is VokunSalad v)
            {
                CustomizeVokunSalad custom = new CustomizeVokunSalad(v, combo, true);
                OrderComponent order = this.FindAncestor<OrderComponent>();
                order.Swap(custom);
            }
            else if (combo.Side is MadOtarGrits mog)
            {
                CustomizeMadOtarGrits custom = new CustomizeMadOtarGrits(mog, combo, true);
                OrderComponent order = this.FindAncestor<OrderComponent>();
                order.Swap(custom);
            }
            else if (combo.Side is FriedMiraak f)
            {
                CustomizeFriedMiraak custom = new CustomizeFriedMiraak(f, combo, true);
                OrderComponent order = this.FindAncestor<OrderComponent>();
                order.Swap(custom);
            }
        }
    }
}
