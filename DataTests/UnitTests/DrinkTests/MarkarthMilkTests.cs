/*
 * Author: Matthew Schwartz
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Class to test the MarkarthMilk.cs class
    /// </summary>
    public class MarkarthMilkTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into a drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(m);
        }

        /// <summary>
        /// Makes sure the markarth milk has the right name by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectNameByDefault()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.Equal(m.ToString(), m.Name);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(m);
        }

        /// <summary>
        /// Makes sure that an unmodified markarth milk object doesn't have ice by default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.False(m.Ice);
        }

        /// <summary>
        /// Makes sure that an unmodified markarth milk object is size small by default
        /// </summary>
        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.Equal(Size.Small, m.Size);
        }

        /// <summary>
        /// Makes sure that a markarth milk object is able to have ice added to it
        /// </summary>
        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Ice = true;
            Assert.True(m.Ice);
            m.Ice = false;
            Assert.False(m.Ice);
        }

        /// <summary>
        /// Makes sure that a markarth milk object is able to change sizes
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = Size.Medium;
            Assert.Equal(Size.Medium, m.Size);
            m.Size = Size.Large;
            Assert.Equal(Size.Large, m.Size);
            m.Size = Size.Small;
            Assert.Equal(Size.Small, m.Size);
        }

        /// <summary>
        /// Makes sure that as a markarth milk object chanegs size, the price changes accordingly
        /// </summary>
        /// <param name="size">The size of a markarth milk drink</param>
        /// <param name="price">The expected price of a markarth milk drink</param>
        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(price, m.Price);
        }

        /// <summary>
        /// Makes sure that as a markarth milk object chanegs size, the calories change accordingly
        /// </summary>
        /// <param name="size">The size of a markarth milk drink</param>
        /// <param name="cal">The expected number of calories of a markarth milk drink</param>
        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(cal, m.Calories);
        }

        /// <summary>
        /// Makes sure that markarth milk object has the correct special instructions based on whether there is ice or no ice
        /// </summary>
        /// <param name="includeIce">Whether or not the markarth milk has ice or not</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", m.SpecialInstructions);
            if (!includeIce) Assert.DoesNotContain("Add ice", m.SpecialInstructions);
        }

        /// <summary>
        /// Makes sure the markarth milk object returns the right name based on its size
        /// </summary>
        /// <param name="size">The size of a markarth milk drink</param>
        /// <param name="name">The expected name of the markarth milk drink (what we expect from Tostring())</param>
        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk m = new MarkarthMilk();
            m.Size = size;
            Assert.Equal(name, m.ToString());
        }

        [Fact]
        public void ChangingIceShouldNotifyIceProperty()
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.PropertyChanged(m, "Ice", () =>
            {
                m.Ice = true;
            });

            Assert.PropertyChanged(m, "Ice", () =>
            {
                m.Ice = false;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]

        public void ChangingSizeShouldNotifySizeProperty(Size size)
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.PropertyChanged(m, "Size", () =>
            {
                m.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]

        public void ChangingSizeShouldNotifyPriceProperty(Size size)
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.PropertyChanged(m, "Price", () =>
            {
                m.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyCaloriesProperty(Size size)
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.PropertyChanged(m, "Calories", () =>
            {
                m.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifySpecialInstructionsProperty(Size size)
        {
            MarkarthMilk m = new MarkarthMilk();
            Assert.PropertyChanged(m, "SpecialInstructions", () =>
            {
                m.Size = size;
            });
        }

        /// <summary>
        /// Checks to make sure markarth milk implements INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new MarkarthMilk());
        }
    }
}