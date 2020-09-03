/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Runtime.InteropServices;
using Xunit.Sdk;
using NuGet.Frameworks;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Bun = false;
            Assert.False(d.Bun);
            d.Bun = true;
            Assert.True(d.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Ketchup = false;
            Assert.False(d.Ketchup);
            d.Ketchup = true;
            Assert.True(d.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Mustard = false;
            Assert.False(d.Mustard);
            d.Mustard = true;
            Assert.True(d.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Pickle = false;
            Assert.False(d.Pickle);
            d.Pickle = true;
            Assert.True(d.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Cheese = false;
            Assert.False(d.Cheese);
            d.Cheese = true;
            Assert.True(d.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Tomato = false;
            Assert.False(d.Tomato);
            d.Tomato = true;
            Assert.True(d.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Lettuce = false;
            Assert.False(d.Lettuce);
            d.Lettuce = true;
            Assert.True(d.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Mayo = false;
            Assert.False(d.Mayo);
            d.Mayo = true;
            Assert.True(d.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal(7.32, d.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal((uint)843, d.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Bun = includeBun;
            d.Ketchup = includeKetchup;
            d.Mustard = includeMustard;
            d.Pickle = includePickle;
            d.Cheese = includeCheese;
            d.Tomato = includeTomato;
            d.Lettuce = includeLettuce;
            d.Mayo = includeMayo;
            if (includeBun) Assert.DoesNotContain("Hold bun", d.SpecialInstructions);
            if (!includeBun) Assert.Contains("Hold bun", d.SpecialInstructions);
            if (includeKetchup) Assert.DoesNotContain("Hold ketchup", d.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", d.SpecialInstructions);
            if (includeMustard) Assert.DoesNotContain("Hold mustard", d.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", d.SpecialInstructions);
            if (includePickle) Assert.DoesNotContain("Hold pickle", d.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", d.SpecialInstructions);
            if (includeCheese) Assert.DoesNotContain("Hold cheese", d.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", d.SpecialInstructions);
            if (includeTomato) Assert.DoesNotContain("Hold tomato", d.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", d.SpecialInstructions);
            if (includeLettuce) Assert.DoesNotContain("Hold lettuce", d.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", d.SpecialInstructions);
            if (includeMayo) Assert.DoesNotContain("Hold mayo", d.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", d.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal("Double Draugr", d.ToString());
        }
    }
}