/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using NuGet.Frameworks;
using System.Runtime.InteropServices;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Bun = false;
            Assert.False(t.Bun);
            t.Bun = true;
            Assert.True(t.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Ketchup = false;
            Assert.False(t.Ketchup);
            t.Ketchup = true;
            Assert.True(t.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Mustard = false;
            Assert.False(t.Mustard);
            t.Mustard = true;
            Assert.True(t.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Pickle = false;
            Assert.False(t.Pickle);
            t.Pickle = true;
            Assert.True(t.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Cheese = false;
            Assert.False(t.Cheese);
            t.Cheese = true;
            Assert.True(t.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Tomato = false;
            Assert.False(t.Tomato);
            t.Tomato = true;
            Assert.True(t.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Lettuce = false;
            Assert.False(t.Lettuce);
            t.Lettuce = true;
            Assert.True(t.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Mayo = false;
            Assert.False(t.Mayo);
            t.Mayo = true;
            Assert.True(t.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Bacon = false;
            Assert.False(t.Bacon);
            t.Bacon = true;
            Assert.True(t.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Egg = false;
            Assert.False(t.Egg);
            t.Egg = true;
            Assert.True(t.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal(8.32, t.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal((uint)943, t.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Bun = includeBun;
            t.Ketchup = includeKetchup;
            t.Mustard = includeMustard;
            t.Pickle = includePickle;
            t.Cheese = includeCheese;
            t.Tomato = includeTomato;
            t.Lettuce = includeLettuce;
            t.Mayo = includeMayo;
            t.Bacon = includeBacon;
            t.Egg = includeEgg;
            if (includeBun) Assert.DoesNotContain("Hold bun", t.SpecialInstructions);
            if (!includeBun) Assert.Contains("Hold bun", t.SpecialInstructions);
            if (includeKetchup) Assert.DoesNotContain("Hold ketchup", t.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", t.SpecialInstructions);
            if (includeMustard) Assert.DoesNotContain("Hold mustard", t.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", t.SpecialInstructions);
            if (includePickle) Assert.DoesNotContain("Hold pickle", t.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", t.SpecialInstructions);
            if (includeCheese) Assert.DoesNotContain("Hold cheese", t.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", t.SpecialInstructions);
            if (includeTomato) Assert.DoesNotContain("Hold tomato", t.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", t.SpecialInstructions);
            if (includeLettuce) Assert.DoesNotContain("Hold lettuce", t.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", t.SpecialInstructions);
            if (includeMayo) Assert.DoesNotContain("Hold mayo", t.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", t.SpecialInstructions);
            if (includeBacon) Assert.DoesNotContain("Hold bacon", t.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", t.SpecialInstructions);
            if (includeEgg) Assert.DoesNotContain("Hold egg", t.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", t.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", t.ToString());
        }
    }
}