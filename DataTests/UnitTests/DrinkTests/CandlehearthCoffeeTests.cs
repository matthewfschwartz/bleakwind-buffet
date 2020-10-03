/*
 * Author: Matthew Schwartz
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Class to test the CandlehearthCoffee.cs class
    /// </summary>
    public class CandlehearthCoffeeTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into a drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(c);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(c);
        }

        /// <summary>
        /// Checks to make sure ice is not included by default
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.False(c.Ice);
        }

        /// <summary>
        /// Checks to make sure coffee is not decaf by default
        /// </summary>
        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.False(c.Decaf);
        }

        /// <summary>
        /// Checks to make coffee doesn't have cream by default
        /// </summary>
        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.False(c.RoomForCream);
        }

        /// <summary>
        /// Checks to make sure the size is small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.Equal(Size.Small, c.Size);
        }

        /// <summary>
        /// Checks to make sure the setter for ice works
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Ice = true;
            Assert.True(c.Ice);
            c.Ice = false;
            Assert.False(c.Ice);
        }

        /// <summary>
        /// Checks to make sure the setter for decaf works
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Decaf = true;
            Assert.True(c.Decaf);
            c.Decaf = false;
            Assert.False(c.Decaf);
        }

        /// <summary>
        /// Checks to make sure the setter for cream works
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.RoomForCream = true;
            Assert.True(c.RoomForCream);
            c.RoomForCream = false;
            Assert.False(c.RoomForCream);
        }

        /// <summary>
        /// Checks to make sure the setter for size works
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Size = Size.Medium;
            Assert.Equal(Size.Medium, c.Size);
            c.Size = Size.Large;
            Assert.Equal(Size.Large, c.Size);
            c.Size = Size.Small;
            Assert.Equal(Size.Small, c.Size);
        }

        /// <summary>
        /// Checks to make sure the right price is assigned
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="price">The price the drink should have</param>
        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Size = size;
            Assert.Equal(price, c.Price);
        }

        /// <summary>
        /// Checks to make sure the right calorie count is correct
        /// </summary>
        /// <param name="size">The size of the drink</param>
        /// <param name="cal">How many calories the drink should have</param>
        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Size = size;
            Assert.Equal(cal, c.Calories);
        }

        /// <summary>
        /// Checks to make sure special instructions holds the correct order
        /// </summary>
        /// <param name="includeIce">Whether or not the customer wants ice</param>
        /// <param name="includeCream">Whether or not the customer wants cream</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Ice = includeIce;
            c.RoomForCream = includeCream;
            if (includeIce) Assert.Contains("Add ice", c.SpecialInstructions);
            if (!includeIce) Assert.DoesNotContain("Add ice", c.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", c.SpecialInstructions);
            if (!includeCream) Assert.DoesNotContain("Add cream", c.SpecialInstructions);

        }

        /// <summary>
        /// Checks the ToString method outputs the correct string
        /// </summary>
        /// <param name="decaf">Whether the coffee is decaf or not</param>
        /// <param name="size">The size of the drink</param>
        /// <param name="name">The expected output of ToString</param>
        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            c.Size = size;
            c.Decaf = decaf;
            Assert.Equal(name, c.ToString());
        }

        [Fact]
        public void ChangingIceShouldNotifyIceProperty()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, "Ice", () =>
            {
                c.Ice = true;
            });

            Assert.PropertyChanged(c, "Ice", () =>
            {
                c.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceShouldNotifyDecafProperty()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, "Decaf", () =>
            {
                c.Decaf = true;
            });

            Assert.PropertyChanged(c, "Decaf", () =>
            {
                c.Decaf = false;
            });
        }

        [Fact]
        public void ChangingIceShouldNotifyCreamProperty()
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, "RoomForCream", () =>
            {
                c.RoomForCream = true;
            });

            Assert.PropertyChanged(c, "RoomForCream", () =>
            {
                c.RoomForCream = false;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]

        public void ChangingSizeShouldNotifySizeProperty(Size size)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, "Size", () =>
            {
                c.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]

        public void ChangingSizeShouldNotifyPriceProperty(Size size)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, "Price", () =>
            {
                c.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyCaloriesProperty(Size size)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, "Calories", () =>
            {
                c.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifySpecialInstructionsProperty(Size size)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, "SpecialInstructions", () =>
            {
                c.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyToStringProperty(Size size)
        {
            CandlehearthCoffee c = new CandlehearthCoffee();
            Assert.PropertyChanged(c, "ToString", () =>
            {
                c.Size = size;
            });
        }
    }
}
