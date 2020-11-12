/*
 * Author: Matthew Schwartz
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Class to test the AretinoAppleJuice.cs class
    /// </summary>
    public class AretinoAppleJuiceTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into a drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(a);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(a);
        }

        /// <summary>
        /// Makes sure the aretino apple juice has the right name by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectNameByDefault()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.Equal(a.ToString(), a.Name);
        }

        /// <summary>
        /// Checks to make sure ice is not included by default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.False(a.Ice);
        }

        /// <summary>
        /// Checks to make sure the size is small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.Equal(Size.Small, a.Size);
        }

        /// <summary>
        /// Checks to make sure the setter for ice works
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            a.Ice = true;
            Assert.True(a.Ice);
            a.Ice = false;
            Assert.False(a.Ice);
        }

        /// <summary>
        /// Checks to make sure the setter for size works
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            a.Size = Size.Medium;
            Assert.Equal(Size.Medium, a.Size);
            a.Size = Size.Large;
            Assert.Equal(Size.Large, a.Size);
            a.Size = Size.Small;
            Assert.Equal(Size.Small, a.Size);
        }

        /// <summary>
        /// Checks to make sure the right price is assigned
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="price">The price the drink should have</param>
        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            a.Size = size;
            Assert.Equal(price, a.Price);
        }

        /// <summary>
        /// Checks to make sure the right calorie count is correct
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="cal">How many calories the drink should have</param>
        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            a.Size = size;
            Assert.Equal(cal, a.Calories);
        }

        /// <summary>
        /// Checks to make sure the special instructions are updated
        /// </summary>
        /// <param name="includeIce">Represents whether or not a customer wants ice</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            a.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", a.SpecialInstructions);
            if (!includeIce) Assert.DoesNotContain("Add ice", a.SpecialInstructions);
        }

        /// <summary>
        /// Checks the ToString method outputs the correct string
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="name">The value that ToString should return</param>
        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            a.Size = size;
            Assert.Equal(name, a.ToString());
        }

        [Fact]
        public void ChangingIceShouldNotifyIceProperty()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.PropertyChanged(a, "Ice", () =>
            {
                a.Ice = true;
            });

            Assert.PropertyChanged(a, "Ice", () =>
            {
                a.Ice = false;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]

        public void ChangingSizeShouldNotifySizeProperty(Size size)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.PropertyChanged(a, "Size", () =>
            {
                a.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]

        public void ChangingSizeShouldNotifyPriceProperty(Size size)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.PropertyChanged(a, "Price", () =>
            {
                a.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyCaloriesProperty(Size size)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.PropertyChanged(a, "Calories", () =>
            {
                a.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifySpecialInstructionsProperty(Size size)
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.PropertyChanged(a, "SpecialInstructions", () =>
            {
                a.Size = size;
            });
        }

        /// <summary>
        /// Checks to make sure aretino apple juice implements INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new AretinoAppleJuice());
        }

        /// <summary>
        /// Makes sure Description getter returns the correct description
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            AretinoAppleJuice a = new AretinoAppleJuice();
            Assert.Equal("Fresh squeezed apple juice.", a.Description);
        }
    }
}