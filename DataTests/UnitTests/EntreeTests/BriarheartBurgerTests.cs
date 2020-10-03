/*
 * Author: Matthew Schwartz
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class to test the BriarheartBurger.cs class
    /// </summary>
    public class BriarheartBurgerTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(b);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            BriarheartBurger b= new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(b);
        }

        /// <summary>
        /// Makes sure a briarheart burger includes a bun by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Bun);
        }

        /// <summary>
        /// Makes sure a briarheart burger includes ketchup by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Ketchup);
        }

        /// <summary>
        /// Makes sure a briarheart burger includes mustard by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Mustard);
        }

        /// <summary>
        /// Makes sure a briarheart burger includes a pickle by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Pickle);
        }

        /// <summary>
        /// Makes sure a briarheart burger includes cheese by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Cheese);
        }

        /// <summary>
        /// Makes sure we can remove or add a bun to briarheart burger
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = false;
            Assert.False(b.Bun);
            b.Bun = true;
            Assert.True(b.Bun);
        }

        /// <summary>
        /// Makes sure we can remove or add ketchup to briarheart burger
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Ketchup = false;
            Assert.False(b.Ketchup);
            b.Ketchup = true;
            Assert.True(b.Ketchup);
        }

        /// <summary>
        /// Makes sure we can remove or add mustard to briarheart burger
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Mustard = false;
            Assert.False(b.Mustard);
            b.Mustard = true;
            Assert.True(b.Mustard);
        }

        /// <summary>
        /// Makes sure we can remove or add a pickle to briarheart burger
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Pickle = false;
            Assert.False(b.Pickle);
            b.Pickle = true;
            Assert.True(b.Pickle);
        }

        /// <summary>
        /// Makes sure we can remove or add cheese to briarheart burger
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Cheese = false;
            Assert.False(b.Cheese);
            b.Cheese = true;
            Assert.True(b.Cheese);
        }

        /// <summary>
        /// Makes sure that briarheart burger object has the right price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal(6.32, b.Price);
        }

        /// <summary>
        /// Makes sure that briarheart burger object has the right calorie count
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal((uint)743, b.Calories);
        }

        /// <summary>
        /// Makes sure the briarheart burger object has the right special instructions based on what the customer wants
        /// </summary>
        /// <param name="includeBun">Whether the customer wants a bun or not</param>
        /// <param name="includeKetchup">Whether the customer wants ketchup or not</param>
        /// <param name="includeMustard">Whether the customer wants mustard or not</param>
        /// <param name="includePickle">Whether the customer wants a pickle or not</param>
        /// <param name="includeCheese">Whether the customer wants cheese or not</param>
        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = includeBun;
            b.Ketchup = includeKetchup;
            b.Mustard = includeMustard;
            b.Pickle = includePickle;
            b.Cheese = includeCheese;
            if (includeBun) Assert.DoesNotContain("Hold bun", b.SpecialInstructions);
            if (!includeBun) Assert.Contains("Hold bun", b.SpecialInstructions);
            if (includeKetchup) Assert.DoesNotContain("Hold ketchup", b.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", b.SpecialInstructions);
            if (includeMustard) Assert.DoesNotContain("Hold mustard", b.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", b.SpecialInstructions);
            if (includePickle) Assert.DoesNotContain("Hold pickle", b.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", b.SpecialInstructions);
            if (includeCheese) Assert.DoesNotContain("Hold cheese", b.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", b.SpecialInstructions);
        }

        /// <summary>
        /// Makes sure the briarheart burger object has the right name
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", b.ToString());
        }

        [Fact]
        public void ChangingBunShouldNotifyBunProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Bun", () =>
            {
                b.Bun = true;
            });

            Assert.PropertyChanged(b, "Bun", () =>
            {
                b.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunShouldNotifySpecialInstructionsProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "SpecialInstructions", () =>
            {
                b.Bun = true;
            });

            Assert.PropertyChanged(b, "SpecialInstructions", () =>
            {
                b.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupShouldNotifyKetchupProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Ketchup", () =>
            {
                b.Ketchup = true;
            });

            Assert.PropertyChanged(b, "Ketchup", () =>
            {
                b.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupShouldNotifySpecialInstructionsProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "SpecialInstructions", () =>
            {
                b.Ketchup = true;
            });

            Assert.PropertyChanged(b, "SpecialInstructions", () =>
            {
                b.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardShouldNotifyMustardProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Mustard", () =>
            {
                b.Mustard = true;
            });

            Assert.PropertyChanged(b, "Mustard", () =>
            {
                b.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardShouldNotifySpecialInstructionsProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "SpecialInstructions", () =>
            {
                b.Mustard = true;
            });

            Assert.PropertyChanged(b, "SpecialInstructions", () =>
            {
                b.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldNotifyPickleProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Pickle", () =>
            {
                b.Pickle = true;
            });

            Assert.PropertyChanged(b, "Pickle", () =>
            {
                b.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldNotifySpecialInstructionsProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "SpecialInstructions", () =>
            {
                b.Pickle = true;
            });

            Assert.PropertyChanged(b, "SpecialInstructions", () =>
            {
                b.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldNotifyCheeseProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Cheese", () =>
            {
                b.Cheese = true;
            });

            Assert.PropertyChanged(b, "Cheese", () =>
            {
                b.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldNotifySpecialInstructionsProperty()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.PropertyChanged(b, "SpecialInstructions", () =>
            {
                b.Cheese = true;
            });

            Assert.PropertyChanged(b, "SpecialInstructions", () =>
            {
                b.Cheese = false;
            });
        }

        
    }
}