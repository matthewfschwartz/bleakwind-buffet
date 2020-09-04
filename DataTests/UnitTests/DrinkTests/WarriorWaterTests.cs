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
    /// <summary>
    /// Class for testing WarriorWater.cs class
    /// </summary>
    public class WarriorWaterTests
    {
        /// <summary>
        /// Makes sure a warrior water drink includes ice by default
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater w = new WarriorWater();
            Assert.True(w.Ice);
        }

        /// <summary>
        /// Makes sure a warrior water drink does not include lemon by default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater w = new WarriorWater();
            Assert.False(w.Lemon);
        }

        /// <summary>
        /// Makes sure a warrior water drink is size small by default
        /// </summary>
        [Fact]
        public void ShouldBySmallByDefault()
        {
            WarriorWater w = new WarriorWater();
            Assert.Equal(Size.Small, w.Size);
        }

        /// <summary>
        /// Makes sure we can remove or add ice from a warrior water drink
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater w = new WarriorWater();
            w.Ice = false;
            Assert.False(w.Ice);
            w.Ice = true;
            Assert.True(w.Ice);
        }

        /// <summary>
        /// Makes sure we can add or remove lemon from a warrior water drink
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater w = new WarriorWater();
            w.Lemon = true;
            Assert.True(w.Lemon);
            w.Lemon = false;
            Assert.False(w.Lemon);
        }

        /// <summary>
        /// Makes sure we can change the size of a warrior water drink
        /// </summary>
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

        /// <summary>
        /// Makes sure a warrior water drink is the correct price based on size
        /// </summary>
        /// <param name="size">Size of the warrior water drink</param>
        /// <param name="price">The price we expect a warrior water to be based on its size</param>
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

        /// <summary>
        /// Makes sure the warrior water drink is the correct calories based on size
        /// </summary>
        /// <param name="size">Size of the warrior water drink</param>
        /// <param name="cal">Expected number of calories that a warrior water drink should be based on its size</param>
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

        /// <summary>
        /// Makes sure our warrior water has the correct special instructions
        /// </summary>
        /// <param name="includeIce">Whether a customer wants ice or not</param>
        /// <param name="includeLemon">Whether a customer wants lemon or not</param>
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

        /// <summary>
        /// Makes sure our warrior water drink has the correct name
        /// </summary>
        /// <param name="size">The size of the warrior water drink</param>
        /// <param name="name">The name we expect the warrior water drink to have based on its size</param>
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
