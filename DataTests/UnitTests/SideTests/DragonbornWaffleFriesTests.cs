/*
 * Author: Matthew Schwartz
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Class to test DragonbornWaffleFries.cs class
    /// </summary>
    public class DragonbornWaffleFriesTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into a side
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(d);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(d);
        }

        /// <summary>
        /// Makes sure dragonborn waffle fries are small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, d.Size);
        }

        /// <summary>
        /// Makes sure we can change the size for dragonborn waffle fries
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            d.Size = Size.Medium;
            Assert.Equal(Size.Medium, d.Size);
            d.Size = Size.Large;
            Assert.Equal(Size.Large, d.Size);
            d.Size = Size.Small;
            Assert.Equal(Size.Small, d.Size);
        }

        /// <summary>
        /// Makes sure special instructions list for dragonborn waffle fries is empty
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            Assert.Empty(d.SpecialInstructions);

        }

        /// <summary>
        /// Makes sure dragonborn waffle fries has the right price according to its size
        /// </summary>
        /// <param name="size">Size of dragonborn waffle fries</param>
        /// <param name="price">Price we expect dragonborn waffle fries to have</param>
        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            d.Size = size;
            Assert.Equal(price, d.Price);
        }

        /// <summary>
        /// Makes sure dragonborn waffle fries have the right calorie count according to its size
        /// </summary>
        /// <param name="size">Size of dragonborn waffle fries</param>
        /// <param name="calories">Calories we expect dragonborn waffle fries to have</param>
        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            d.Size = size;
            Assert.Equal(calories, d.Calories);
        }

        /// <summary>
        /// Makes sure dragonborn waffle fries have the right name according to their size
        /// </summary>
        /// <param name="size">Size of dragonborn waffle fries</param>
        /// <param name="name">Name we expect dragonborn waffle fries to have</param>
        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries();
            d.Size = size;
            Assert.Equal(name, d.ToString());
        }
    }
}