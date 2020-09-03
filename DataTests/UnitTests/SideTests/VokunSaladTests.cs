/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Runtime.InteropServices;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad v = new VokunSalad();
            Assert.Equal(Size.Small, v.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad v = new VokunSalad();
            v.Size = Size.Medium;
            Assert.Equal(Size.Medium, v.Size);
            v.Size = Size.Large;
            Assert.Equal(Size.Large, v.Size);
            v.Size = Size.Small;
            Assert.Equal(Size.Small, v.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad v = new VokunSalad();
            Assert.Empty(v.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad v = new VokunSalad();
            v.Size = size;
            Assert.Equal(price, v.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad v = new VokunSalad();
            v.Size = size;
            Assert.Equal(calories, v.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad v = new VokunSalad();
            v.Size = size;
            Assert.Equal(name, v.ToString());
        }
    }
}