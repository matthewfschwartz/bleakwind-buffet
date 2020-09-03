/*
 * Author: Matthew Schwartz
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater w = new WarriorWater();
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater w = new WarriorWater();
            Assert.False(w.Lemon);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            WarriorWater w = new WarriorWater();
            Assert.Equal(Size.Small, w.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater w = new WarriorWater();
            w.Ice = false;
            Assert.False(w.Ice);
            w.Ice = true;
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater w = new WarriorWater();
            w.Lemon = true;
            Assert.True(w.Lemon);
            w.Lemon = false;
            Assert.False(w.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater w = new WarriorWater();
            w.Size = Size.Medium;
            Assert.Equal(Size.Medium, w.Size);
            w.Size = Size.Large;
            Assert.Equal(Size.Large, w.Size);
            w.Size = Size.Small;
            Assert.Equal(Size.Small, w.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater w = new WarriorWater();
            w.Size = size;
            Assert.Equal(price, w.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater w = new WarriorWater();
            w.Size = size;
            Assert.Equal(cal, w.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        [InlineData(true, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater w = new WarriorWater();
            w.Ice = includeIce;
            w.Lemon = includeLemon;
            if (!includeIce) Assert.Contains("Hold ice", w.SpecialInstructions);
            if (includeIce) Assert.DoesNotContain("Hold ice", w.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", w.SpecialInstructions);
            if (!includeLemon) Assert.DoesNotContain("Add lemon", w.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater w = new WarriorWater();
            w.Size = size;
            Assert.Equal(name, w.ToString());
        }
    }
}
