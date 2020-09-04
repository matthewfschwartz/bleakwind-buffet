/*
 * Author: Matthew Schwartz
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
    /// <summary>
    /// Class to test VokunSalad.cs class
    /// </summary>
    public class VokunSaladTests
    {
        /// <summary>
        /// Makes sure vokun salad is small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad v = new VokunSalad();
            Assert.Equal(Size.Small, v.Size);
        }

        /// <summary>
        /// Makes sure we can change size of vokun salad
        /// </summary>
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

        /// <summary>
        /// Makes sure list of special instructions for vokun salad is empty
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad v = new VokunSalad();
            Assert.Empty(v.SpecialInstructions);
        }

        /// <summary>
        /// Makes sure vokun salad price is right based on its size
        /// </summary>
        /// <param name="size">Size of vokun salad</param>
        /// <param name="price">Price we expect vokun salad to have</param>
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

        /// <summary>
        /// Makes sure vokun salad has right calorie count based on its size
        /// </summary>
        /// <param name="size">Size of vokun salad</param>
        /// <param name="calories">Calorie count we expect vokun salad to have</param>
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

        /// <summary>
        /// Makes sure vokun salad has the right name based on its size
        /// </summary>
        /// <param name="size">Size of vokun salad</param>
        /// <param name="name">Name we expect vokun salad to have</param>
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