/*
 * Author: Matthew Schwartz
 * Class: MenuTests.cs
 * Purpose: Class that tests the Menu.cs class
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// Class to test the Menu.cs class
    /// </summary>
    public class MenuTests
    {
        /// <summary>
        /// Makes sure the entrees list returns a list of all entrees, nothing more, nothing less
        /// </summary>
        [Fact]
        void EntreesListShouldReturnCorrectList()
        {
            List<IOrderItem> entrees = Menu.Entrees();

            Assert.Contains(entrees, item => 
            {
                BriarheartBurger b = new BriarheartBurger();
                return item.ToString().Equals(b.ToString()); 
            }); // Use filter function
            Assert.Contains(entrees, item =>
            {
                DoubleDraugr d = new DoubleDraugr();
                return item.ToString().Equals(d.ToString());
            });
            Assert.Contains(entrees, item =>
            {
                ThalmorTriple t = new ThalmorTriple();
                return item.ToString().Equals(t.ToString());
            });
            Assert.Contains(entrees, item =>
            {
                PhillyPoacher p = new PhillyPoacher();
                return item.ToString().Equals(p.ToString());
            });
            Assert.Contains(entrees, item =>
            {
                GardenOrcOmelette g = new GardenOrcOmelette();
                return item.ToString().Equals(g.ToString());
            });
            Assert.Contains(entrees, item =>
            {
                ThugsTBone t = new ThugsTBone();
                return item.ToString().Equals(t.ToString());
            });
            Assert.Contains(entrees, item =>
            {
                SmokehouseSkeleton s = new SmokehouseSkeleton();
                return item.ToString().Equals(s.ToString());
            });
            Assert.Equal(7, entrees.Count);
        }

        /// <summary>
        /// Makes sure the sides list returns a list of all sides in small, medium, and large options
        /// </summary>
        /// <param name="size">The size of each side</param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        void SidesListShouldReturnCorrectList(Size size)
        {
            List<IOrderItem> sides = Menu.Sides();

            Assert.Contains(sides, item =>
            {
                VokunSalad v = new VokunSalad();
                v.Size = size;
                return item.ToString().Equals(v.ToString());
            });

            Assert.Contains(sides, item =>
            {
                MadOtarGrits m = new MadOtarGrits();
                m.Size = size;
                return item.ToString().Equals(m.ToString());
            });

            Assert.Contains(sides, item =>
            {
                DragonbornWaffleFries d = new DragonbornWaffleFries();
                d.Size = size;
                return item.ToString().Equals(d.ToString());
            });

            Assert.Contains(sides, item =>
            {
                FriedMiraak f = new FriedMiraak();
                f.Size = size;
                return item.ToString().Equals(f.ToString());
            });

            Assert.Equal(12, sides.Count);
        }

        /// <summary>
        /// Makes sure the drinks list returns a list of all drinks in small, medium, and large options
        /// as well as an option for every flavor of Sailor Soda
        /// </summary>
        /// <param name="size">The size of each drink</param>
        /// <param name="flavor">The flavor for SailorSoda drinks</param>
        [Theory]
        [InlineData(Size.Small, SodaFlavor.Cherry)]
        [InlineData(Size.Medium, SodaFlavor.Cherry)]
        [InlineData(Size.Large, SodaFlavor.Cherry)]
        [InlineData(Size.Small, SodaFlavor.Lemon)]
        [InlineData(Size.Medium, SodaFlavor.Lemon)]
        [InlineData(Size.Large, SodaFlavor.Lemon)]
        [InlineData(Size.Small, SodaFlavor.Peach)]
        [InlineData(Size.Medium, SodaFlavor.Peach)]
        [InlineData(Size.Large, SodaFlavor.Peach)]
        [InlineData(Size.Small, SodaFlavor.Grapefruit)]
        [InlineData(Size.Medium, SodaFlavor.Grapefruit)]
        [InlineData(Size.Large, SodaFlavor.Grapefruit)]
        [InlineData(Size.Small, SodaFlavor.Watermelon)]
        [InlineData(Size.Medium, SodaFlavor.Watermelon)]
        [InlineData(Size.Large, SodaFlavor.Watermelon)]
        [InlineData(Size.Small, SodaFlavor.Blackberry)]
        [InlineData(Size.Medium, SodaFlavor.Blackberry)]
        [InlineData(Size.Large, SodaFlavor.Blackberry)]
        void DrinksListShouldReturnCorrectList(Size size, SodaFlavor flavor)
        {
            List<IOrderItem> drinks = Menu.Drinks();

            Assert.Contains(drinks, item =>
            {
                CandlehearthCoffee c = new CandlehearthCoffee();
                c.Size = size;
                return item.ToString().Equals(c.ToString());
            });

            Assert.Contains(drinks, item =>
            {
                AretinoAppleJuice a = new AretinoAppleJuice();
                a.Size = size;
                return item.ToString().Equals(a.ToString());
            });

            Assert.Contains(drinks, item =>
            {
                MarkarthMilk m = new MarkarthMilk();
                m.Size = size;
                return item.ToString().Equals(m.ToString());
            });

            Assert.Contains(drinks, item =>
            {
                WarriorWater w = new WarriorWater();
                w.Size = size;
                return item.ToString().Equals(w.ToString());
            });

            Assert.Contains(drinks, item =>
            {
                SailorSoda s = new SailorSoda();
                s.Size = size;
                s.Flavor = flavor;
                return item.ToString().Equals(s.ToString());
            });

            Assert.Equal(30, drinks.Count);
        }

        /// <summary>
        /// Makes sure all the entrees are included in the full menu
        /// </summary>
        [Fact]
        void FullMenuShouldHaveAllEntrees()
        {
            List<IOrderItem> fullMenu = Menu.FullMenu();

            Assert.Contains(fullMenu, item =>
            {
                BriarheartBurger b = new BriarheartBurger();
                return item.ToString().Equals(b.ToString());
            }); // Use filter function
            Assert.Contains(fullMenu, item =>
            {
                DoubleDraugr d = new DoubleDraugr();
                return item.ToString().Equals(d.ToString());
            });
            Assert.Contains(fullMenu, item =>
            {
                ThalmorTriple t = new ThalmorTriple();
                return item.ToString().Equals(t.ToString());
            });
            Assert.Contains(fullMenu, item =>
            {
                PhillyPoacher p = new PhillyPoacher();
                return item.ToString().Equals(p.ToString());
            });
            Assert.Contains(fullMenu, item =>
            {
                GardenOrcOmelette g = new GardenOrcOmelette();
                return item.ToString().Equals(g.ToString());
            });
            Assert.Contains(fullMenu, item =>
            {
                ThugsTBone t = new ThugsTBone();
                return item.ToString().Equals(t.ToString());
            });
            Assert.Contains(fullMenu, item =>
            {
                SmokehouseSkeleton s = new SmokehouseSkeleton();
                return item.ToString().Equals(s.ToString());
            });
        }

        /// <summary>
        /// Makes sure all the sides and their size options are in the full menu
        /// </summary>
        /// <param name="size">The size of a side</param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        void FullMenuShouldHaveAllSides(Size size)
        {
            List<IOrderItem> fullMenu = Menu.FullMenu();

            Assert.Contains(fullMenu, item =>
            {
                VokunSalad v = new VokunSalad();
                v.Size = size;
                return item.ToString().Equals(v.ToString());
            });

            Assert.Contains(fullMenu, item =>
            {
                MadOtarGrits m = new MadOtarGrits();
                m.Size = size;
                return item.ToString().Equals(m.ToString());
            });

            Assert.Contains(fullMenu, item =>
            {
                DragonbornWaffleFries d = new DragonbornWaffleFries();
                d.Size = size;
                return item.ToString().Equals(d.ToString());
            });

            Assert.Contains(fullMenu, item =>
            {
                FriedMiraak f = new FriedMiraak();
                f.Size = size;
                return item.ToString().Equals(f.ToString());
            });
        }

        /// <summary>
        /// Makes sure all drink options are included in the full menu, with all size and flavor options
        /// </summary>
        /// <param name="size">The size of a drink</param>
        /// <param name="flavor">The flavor of a Sailor Soda</param>
        [Theory]
        [InlineData(Size.Small, SodaFlavor.Cherry)]
        [InlineData(Size.Medium, SodaFlavor.Cherry)]
        [InlineData(Size.Large, SodaFlavor.Cherry)]
        [InlineData(Size.Small, SodaFlavor.Lemon)]
        [InlineData(Size.Medium, SodaFlavor.Lemon)]
        [InlineData(Size.Large, SodaFlavor.Lemon)]
        [InlineData(Size.Small, SodaFlavor.Peach)]
        [InlineData(Size.Medium, SodaFlavor.Peach)]
        [InlineData(Size.Large, SodaFlavor.Peach)]
        [InlineData(Size.Small, SodaFlavor.Grapefruit)]
        [InlineData(Size.Medium, SodaFlavor.Grapefruit)]
        [InlineData(Size.Large, SodaFlavor.Grapefruit)]
        [InlineData(Size.Small, SodaFlavor.Watermelon)]
        [InlineData(Size.Medium, SodaFlavor.Watermelon)]
        [InlineData(Size.Large, SodaFlavor.Watermelon)]
        [InlineData(Size.Small, SodaFlavor.Blackberry)]
        [InlineData(Size.Medium, SodaFlavor.Blackberry)]
        [InlineData(Size.Large, SodaFlavor.Blackberry)]
        void FullMenuShouldHaveAllDrinks(Size size, SodaFlavor flavor)
        {
            List<IOrderItem> fullMenu = Menu.FullMenu();

            Assert.Contains(fullMenu, item =>
            {
                CandlehearthCoffee c = new CandlehearthCoffee();
                c.Size = size;
                return item.ToString().Equals(c.ToString());
            });

            Assert.Contains(fullMenu, item =>
            {
                AretinoAppleJuice a = new AretinoAppleJuice();
                a.Size = size;
                return item.ToString().Equals(a.ToString());
            });

            Assert.Contains(fullMenu, item =>
            {
                MarkarthMilk m = new MarkarthMilk();
                m.Size = size;
                return item.ToString().Equals(m.ToString());
            });

            Assert.Contains(fullMenu, item =>
            {
                WarriorWater w = new WarriorWater();
                w.Size = size;
                return item.ToString().Equals(w.ToString());
            });

            Assert.Contains(fullMenu, item =>
            {
                SailorSoda s = new SailorSoda();
                s.Size = size;
                s.Flavor = flavor;
                return item.ToString().Equals(s.ToString());
            });
        }

        /// <summary>
        /// Makes sure the full menu has the correct number of IOrderItems in it for all entrees, sides, and drinks options
        /// </summary>
        [Fact]
        void FullMenuShouldHaveAllMenuItems()
        {
            List<IOrderItem> fullMenu = Menu.FullMenu();
            Assert.Equal(49, fullMenu.Count);
        }
    }
}
