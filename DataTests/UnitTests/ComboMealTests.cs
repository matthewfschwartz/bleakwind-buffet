/*
 * Author: Matthew Schwartz
 * Class: ComboTests.cs
 * Purpose: Class that tests the ComboMeal.cs class
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboMealTests
    {
        /// <summary>
        /// Verifies that Combo Meal is a Combo Meal
        /// </summary>
        [Fact]
        public void ShouldBeAComboMeal()
        {
            ComboMeal cm = new ComboMeal();
            Assert.IsAssignableFrom<ComboMeal>(cm);
        }

        /// <summary>
        /// Verifies that Combo Meal is a IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ComboMeal cm = new ComboMeal();
            Assert.IsAssignableFrom<IOrderItem>(cm);
        }

        /// <summary>
        /// Makes sure combo meal has briarheart burger by default
        /// </summary>
        [Fact]
        public void ShouldHaveBriarheartBurgerByDefault()
        {
            ComboMeal cm = new ComboMeal();
            Assert.Equal(new BriarheartBurger().ToString(), cm.Entree.ToString());
        }

        /// <summary>
        /// Makes sure combo meal has briarheart burger by default
        /// </summary>
        [Fact]
        public void ShouldHaveWaffleFriesByDefault()
        {
            ComboMeal cm = new ComboMeal();
            Assert.Equal(new DragonbornWaffleFries().ToString(), cm.Side.ToString());
        }

        [Fact]
        public void WaffleFriesShouldBeSizeSmallByDefault()
        {
            ComboMeal cm = new ComboMeal();
            Assert.Equal(Size.Small, cm.Side.Size);
        }

        /// <summary>
        /// Makes sure combo meal has briarheart burger by default
        /// </summary>
        [Fact]
        public void ShouldHaveSailorSodaByDefault()
        {
            ComboMeal cm = new ComboMeal();
            Assert.Equal(new SailorSoda().ToString(), cm.Drink.ToString());
        }

        [Fact]
        public void SailorSodaShouldBeSizeSmallByDefault()
        {
            ComboMeal cm = new ComboMeal();
            Assert.Equal(Size.Small, cm.Drink.Size);
        }

        [Fact]
        public void ShouldBeAbleToChangeEntree()
        {
            ComboMeal cm = new ComboMeal();
            cm.Entree = new DoubleDraugr();
            Assert.Equal(new DoubleDraugr().ToString(), cm.Entree.ToString());
            cm.Entree = new ThalmorTriple();
            Assert.Equal(new ThalmorTriple().ToString(), cm.Entree.ToString());
            cm.Entree = new PhillyPoacher();
            Assert.Equal(new PhillyPoacher().ToString(), cm.Entree.ToString());
            cm.Entree = new SmokehouseSkeleton();
            Assert.Equal(new SmokehouseSkeleton().ToString(), cm.Entree.ToString());
            cm.Entree = new ThugsTBone();
            Assert.Equal(new ThugsTBone().ToString(), cm.Entree.ToString());
            cm.Entree = new GardenOrcOmelette();
            Assert.Equal(new GardenOrcOmelette().ToString(), cm.Entree.ToString());
        }

        [Fact]
        public void ShouldBeAbleToChangeDrink()
        {
            ComboMeal cm = new ComboMeal();
            cm.Drink = new CandlehearthCoffee();
            Assert.Equal(new CandlehearthCoffee().ToString(), cm.Drink.ToString());
            cm.Drink = new WarriorWater();
            Assert.Equal(new WarriorWater().ToString(), cm.Drink.ToString());
            cm.Drink = new MarkarthMilk();
            Assert.Equal(new MarkarthMilk().ToString(), cm.Drink.ToString());
            cm.Drink = new AretinoAppleJuice();
            Assert.Equal(new AretinoAppleJuice().ToString(), cm.Drink.ToString());
        }

        [Fact]
        public void ShouldBeAbleToChangeSide()
        {
            ComboMeal cm = new ComboMeal();
            cm.Side = new MadOtarGrits();
            Assert.Equal(new MadOtarGrits().ToString(), cm.Side.ToString());
            cm.Side = new VokunSalad();
            Assert.Equal(new VokunSalad().ToString(), cm.Side.ToString());
            cm.Side = new FriedMiraak();
            Assert.Equal(new FriedMiraak().ToString(), cm.Side.ToString());
        }

        /// <summary>
        /// Makes sure the combo meal has the right calories by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesByDefault()
        {
            ComboMeal cm = new ComboMeal();
            BriarheartBurger b = new BriarheartBurger();
            SailorSoda s = new SailorSoda();
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            Assert.Equal(b.Calories + s.Calories + d.Calories, cm.Calories);
        }

        /// <summary>
        /// Makes sure the combo meal has the right price by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceByDefault()
        {
            ComboMeal cm = new ComboMeal();
            BriarheartBurger b = new BriarheartBurger();
            SailorSoda s = new SailorSoda();
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            Assert.Equal(b.Price + s.Price + d.Price - 1, cm.Price);
        }

        /// <summary>
        /// Makes sure the combo meal has the right name by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectNameByDefault()
        {
            ComboMeal cm = new ComboMeal();
            Assert.Equal("Combo Meal", cm.Name);
        }

        /// <summary>
        /// Makes sure combo meal has the right special instructions by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectSpecialInstructionsByDefault()
        {
            ComboMeal cm = new ComboMeal();
            List<string> specialInstructions = new List<string>();
            specialInstructions.Add(cm.Entree.ToString());
            specialInstructions.Add(cm.Drink.ToString());
            specialInstructions.Add(cm.Side.ToString());
            Assert.Equal(specialInstructions, cm.SpecialInstructions);
        }

        /// <summary>
        /// Makes sure that when an entree is changed, entree property is notified
        /// </summary>
        [Fact]
        public void ChangingEntreeShouldNotifyEntreeProperty()
        {
            ComboMeal cm = new ComboMeal();
            Assert.PropertyChanged(cm, "Entree", () =>
            {
                cm.Entree = new DoubleDraugr();
            });
            Assert.PropertyChanged(cm, "Entree", () =>
            {
                cm.Entree = new ThalmorTriple();
            });
            Assert.PropertyChanged(cm, "Entree", () =>
            {
                cm.Entree = new SmokehouseSkeleton();
            });
            Assert.PropertyChanged(cm, "Entree", () =>
            {
                cm.Entree = new PhillyPoacher();
            });
            Assert.PropertyChanged(cm, "Entree", () =>
            {
                cm.Entree = new ThugsTBone();
            });
            Assert.PropertyChanged(cm, "Entree", () =>
            {
                cm.Entree = new GardenOrcOmelette();
            });
        }

        /// <summary>
        /// Makes sure that when an entree is changed, price property is notified
        /// </summary>
        [Fact]
        public void ChangingEntreeShouldNotifyPriceProperty()
        {
            ComboMeal cm = new ComboMeal();
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Entree = new DoubleDraugr();
            });
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Entree = new ThalmorTriple();
            });
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Entree = new SmokehouseSkeleton();
            });
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Entree = new PhillyPoacher();
            });
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Entree = new ThugsTBone();
            });
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Entree = new GardenOrcOmelette();
            });
        }

        /// <summary>
        /// Makes sure that when an entree is changed, calories property is notified
        /// </summary>
        [Fact]
        public void ChangingEntreeShouldNotifyCaloriesProperty()
        {
            ComboMeal cm = new ComboMeal();
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Entree = new DoubleDraugr();
            });
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Entree = new ThalmorTriple();
            });
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Entree = new SmokehouseSkeleton();
            });
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Entree = new PhillyPoacher();
            });
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Entree = new ThugsTBone();
            });
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Entree = new GardenOrcOmelette();
            });
        }

        /// <summary>
        /// Makes sure that when an entree is changed, special instructions property is notified
        /// </summary>
        [Fact]
        public void ChangingEntreeShouldNotifySpecialInstructionsProperty()
        {
            ComboMeal cm = new ComboMeal();
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Entree = new DoubleDraugr();
            });
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Entree = new ThalmorTriple();
            });
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Entree = new SmokehouseSkeleton();
            });
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Entree = new PhillyPoacher();
            });
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Entree = new ThugsTBone();
            });
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Entree = new GardenOrcOmelette();
            });
        }

        /// <summary>
        /// Makes sure that when a drink is changed, drink property is notified
        /// </summary>
        [Fact]
        public void ChangingDrinkShouldNotifyDrinkProperty()
        {
            ComboMeal cm = new ComboMeal();
            Assert.PropertyChanged(cm, "Drink", () =>
            {
                cm.Drink = new AretinoAppleJuice();
            });
            Assert.PropertyChanged(cm, "Drink", () =>
            {
                cm.Drink = new CandlehearthCoffee();
            });
            Assert.PropertyChanged(cm, "Drink", () =>
            {
                cm.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(cm, "Drink", () =>
            {
                cm.Drink = new MarkarthMilk();
            });
        }

        /// <summary>
        /// Makes sure that when a drink is changed, calories property is notified
        /// </summary>
        [Fact]
        public void ChangingDrinkShouldNotifyCaloriesProperty()
        {
            ComboMeal cm = new ComboMeal();
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Drink = new AretinoAppleJuice();
            });
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Drink = new CandlehearthCoffee();
            });
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Drink = new MarkarthMilk();
            });
        }

        /// <summary>
        /// Makes sure that when a drink is changed, price property is notified
        /// </summary>
        [Fact]
        public void ChangingDrinkShouldNotifyPriceProperty()
        {
            ComboMeal cm = new ComboMeal();
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Drink = new AretinoAppleJuice();
            });
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Drink = new CandlehearthCoffee();
            });
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Drink = new MarkarthMilk();
            });
        }

        /// <summary>
        /// Makes sure that when a drink is changed, special instructions property is notified
        /// </summary>
        [Fact]
        public void ChangingDrinkShouldNotifySpecialInstructionsProperty()
        {
            ComboMeal cm = new ComboMeal();
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Drink = new AretinoAppleJuice();
            });
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Drink = new CandlehearthCoffee();
            });
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Drink = new WarriorWater();
            });
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Drink = new MarkarthMilk();
            });
        }

        /// <summary>
        /// Makes sure that when a side is changed, side property is notified
        /// </summary>
        [Fact]
        public void ChangingSideShouldNotifySideProperty()
        {
            ComboMeal cm = new ComboMeal();
            Assert.PropertyChanged(cm, "Side", () =>
            {
                cm.Side = new VokunSalad();
            });
            Assert.PropertyChanged(cm, "Side", () =>
            {
                cm.Side = new MadOtarGrits();
            });
            Assert.PropertyChanged(cm, "Side", () =>
            {
                cm.Side = new FriedMiraak();
            });
        }

        /// <summary>
        /// Makes sure that when a side is changed, price property is notified
        /// </summary>
        [Fact]
        public void ChangingSideShouldNotifyPriceProperty()
        {
            ComboMeal cm = new ComboMeal();
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Side = new VokunSalad();
            });
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Side = new MadOtarGrits();
            });
            Assert.PropertyChanged(cm, "Price", () =>
            {
                cm.Side = new FriedMiraak();
            });
        }

        /// <summary>
        /// Makes sure that when a side is changed, calories property is notified
        /// </summary>
        [Fact]
        public void ChangingSideShouldNotifyCaloriesProperty()
        {
            ComboMeal cm = new ComboMeal();
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Side = new VokunSalad();
            });
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Side = new MadOtarGrits();
            });
            Assert.PropertyChanged(cm, "Calories", () =>
            {
                cm.Side = new FriedMiraak();
            });
        }

        /// <summary>
        /// Makes sure that when a side is changed, special instructions property is notified
        /// </summary>
        [Fact]
        public void ChangingSideShouldNotifySpecialInstructionsProperty()
        {
            ComboMeal cm = new ComboMeal();
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Side = new VokunSalad();
            });
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Side = new MadOtarGrits();
            });
            Assert.PropertyChanged(cm, "SpecialInstructions", () =>
            {
                cm.Side = new FriedMiraak();
            });
        }

        /// <summary>
        /// Checks to make sure combo meal implements INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new ComboMeal());
        }
    }
}
