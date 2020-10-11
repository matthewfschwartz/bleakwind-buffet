/*
 * Author: Matthew Schwartz
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Class to test FriedMiraak.cs class
    /// </summary>
    public class FriedMiraakTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into a side
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            FriedMiraak f = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(f);
        }

        /// <summary>
        /// Makes sure the fried miraak has the right name by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectNameByDefault()
        {
            FriedMiraak f = new FriedMiraak();
            Assert.Equal(f.ToString(), f.Name);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            FriedMiraak f = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(f);
        }

        /// <summary>
        /// Makes sure fried miraak is small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak f = new FriedMiraak();
            Assert.Equal(Size.Small, f.Size);
        }

        /// <summary>
        /// Makes sure we can set the size for fried miraak
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak f = new FriedMiraak();
            f.Size = Size.Medium;
            Assert.Equal(Size.Medium, f.Size);
            f.Size = Size.Large;
            Assert.Equal(Size.Large, f.Size);
            f.Size = Size.Small;
            Assert.Equal(Size.Small, f.Size);
        }

        /// <summary>
        /// Makes sure special instructions list for fried miraak is empty
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak f = new FriedMiraak();
            Assert.Empty(f.SpecialInstructions);
        }

        /// <summary>
        /// Makes sure price for fried miraak is right based on size
        /// </summary>
        /// <param name="size">Size of fried miraak</param>
        /// <param name="price">Price we expect fried miraak to have</param>
        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak f = new FriedMiraak();
            f.Size = size;
            Assert.Equal(price, f.Price);
        }

        /// <summary>
        /// Makes sure fried miraak has the right calorie count
        /// </summary>
        /// <param name="size">Size of fried miraak</param>
        /// <param name="calories">Calorie count we expect fried miraak to have</param>
        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak f = new FriedMiraak();
            f.Size = size;
            Assert.Equal(calories, f.Calories);
        }

        /// <summary>
        /// Makes sure fried miraak has the right name based on their size
        /// </summary>
        /// <param name="size">Size of fried miraak</param>
        /// <param name="name">Name we expect fried miraak to have</param>
        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak f = new FriedMiraak();
            f.Size = size;
            Assert.Equal(name, f.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]

        public void ChangingSizeShouldNotifySizeProperty(Size size)
        {
            FriedMiraak f = new FriedMiraak();
            Assert.PropertyChanged(f, "Size", () =>
            {
                f.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]

        public void ChangingSizeShouldNotifyPriceProperty(Size size)
        {
            FriedMiraak f = new FriedMiraak();
            Assert.PropertyChanged(f, "Price", () =>
            {
                f.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyCaloriesProperty(Size size)
        {
            FriedMiraak f = new FriedMiraak();
            Assert.PropertyChanged(f, "Calories", () =>
            {
                f.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifySpecialInstructionsProperty(Size size)
        {
            FriedMiraak f = new FriedMiraak();
            Assert.PropertyChanged(f, "SpecialInstructions", () =>
            {
                f.Size = size;
            });
        }

        /// <summary>
        /// Checks to make sure fried miraak implements INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new FriedMiraak());
        }
    }
}