/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = false;
            Assert.False(b.Bun);
            b.Bun = true;
            Assert.True(b.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Ketchup = false;
            Assert.False(b.Ketchup);
            b.Ketchup = true;
            Assert.True(b.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Mustard = false;
            Assert.False(b.Mustard);
            b.Mustard = true;
            Assert.True(b.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Pickle = false;
            Assert.False(b.Pickle);
            b.Pickle = true;
            Assert.True(b.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Cheese = false;
            Assert.False(b.Cheese);
            b.Cheese = true;
            Assert.True(b.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal(6.32, b.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal((uint)743, b.Calories);
        }

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

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", b.ToString());
        }
    }
}