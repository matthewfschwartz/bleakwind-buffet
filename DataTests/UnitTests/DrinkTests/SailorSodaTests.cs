/*
 * Author: Matthew Schwartz
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;
using BleakwindBuffet.Data;

using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Class to test the SailorSoda.cs class
    /// </summary>
    public class SailorSodaTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into a drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda s = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(s);
        }

        /// <summary>
        /// Makes sure the sailor soda has the right name by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectNameByDefault()
        {
            SailorSoda s = new SailorSoda();
            Assert.Equal(s.ToString(), s.Name);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SailorSoda s = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(s);
        }

        /// <summary>
        /// Makes sure a sailor soda object has ice by default
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda s = new SailorSoda();
            Assert.True(s.Ice);
        }

        /// <summary>
        /// Makes sure a sailor soda object is size small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda s = new SailorSoda();
            Assert.Equal(Size.Small, s.Size);
        }

        /// <summary>
        /// Makes sure a sailor soda object is cherry flavor by default
        /// </summary>
        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda s = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, s.Flavor);
        }

        /// <summary>
        /// Makes sure we can remove or add ice to a sailor soda object
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda s = new SailorSoda();
            s.Ice = true;
            Assert.True(s.Ice);
            s.Ice = false;
            Assert.False(s.Ice);
        }

        /// <summary>
        /// Makes sure we are able to change the size of a sailor soda object
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda s = new SailorSoda();
            s.Size = Size.Medium;
            Assert.Equal(Size.Medium, s.Size);
            s.Size = Size.Large;
            Assert.Equal(Size.Large, s.Size);
            s.Size = Size.Small;
            Assert.Equal(Size.Small, s.Size);
        }

        /// <summary>
        /// Makes sure we are able to change the flavor of a sailor soda object
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda s = new SailorSoda();
            s.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, s.Flavor);
            s.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, s.Flavor);
            s.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, s.Flavor);
            s.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, s.Flavor);
            s.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, s.Flavor);
            s.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, s.Flavor);
        }

        /// <summary>
        /// Makes sure that a sailor soda object has the right price according to its size
        /// </summary>
        /// <param name="size">The size of a sailor soda object</param>
        /// <param name="price">The price we expect a sailor soda object to have</param>
        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda s = new SailorSoda();
            s.Size = size;
            Assert.Equal(price, s.Price);
        }

        /// <summary>
        /// Makes sure that a sailor soda object has the right calories according to its size
        /// </summary>
        /// <param name="size">The size of a sailor soda object</param>
        /// <param name="cal">The number of calories we expect a sailor soda object to have</param>
        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda s = new SailorSoda();
            s.Size = size;
            Assert.Equal(cal, s.Calories);
        }

        /// <summary>
        /// Makes sure as we modify a sailor soda object, it contains the correct special instructions list
        /// </summary>
        /// <param name="includeIce">Whether a customer wants ice or not</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda s = new SailorSoda();
            s.Ice = includeIce;
            if (includeIce) Assert.DoesNotContain("Hold ice", s.SpecialInstructions);
            if(!includeIce) Assert.Contains("Hold ice", s.SpecialInstructions);
        }
        
        /// <summary>
        /// Makes sure that as a size and flavor of sailor soda is modified, it retains the correct name
        /// </summary>
        /// <param name="flavor">The flavor of a sailor soda object</param>
        /// <param name="size">The size of a sailor soda object</param>
        /// <param name="name">The name we expect a sailor soda object to have based on flavor and size</param>
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda s = new SailorSoda();
            s.Flavor = flavor;
            s.Size = size;
            Assert.Equal(name, s.ToString());
        }

        [Fact]
        public void ChangingIceShouldNotifyIceProperty()
        {
            SailorSoda s = new SailorSoda();
            Assert.PropertyChanged(s, "Ice", () =>
            {
                s.Ice = true;
            });

            Assert.PropertyChanged(s, "Ice", () =>
            {
                s.Ice = false;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]

        public void ChangingSizeShouldNotifySizeProperty(Size size)
        {
            SailorSoda s = new SailorSoda();
            Assert.PropertyChanged(s, "Size", () =>
            {
                s.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]

        public void ChangingSizeShouldNotifyPriceProperty(Size size)
        {
            SailorSoda s = new SailorSoda();
            Assert.PropertyChanged(s, "Price", () =>
            {
                s.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyCaloriesProperty(Size size)
        {
            SailorSoda s = new SailorSoda();
            Assert.PropertyChanged(s, "Calories", () =>
            {
                s.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifySpecialInstructionsProperty(Size size)
        {
            SailorSoda s = new SailorSoda();
            Assert.PropertyChanged(s, "SpecialInstructions", () =>
            {
                s.Size = size;
            });
        }

        [Theory]
        [InlineData(SodaFlavor.Blackberry)]
        [InlineData(SodaFlavor.Cherry)]
        [InlineData(SodaFlavor.Grapefruit)]
        [InlineData(SodaFlavor.Lemon)]
        [InlineData(SodaFlavor.Peach)]
        [InlineData(SodaFlavor.Watermelon)]
        public void ChangingFlavorShouldNotifyFlavorProperty(SodaFlavor flavor)
        {
            SailorSoda s = new SailorSoda();
            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.Flavor = flavor;
            });
        }

        /// <summary>
        /// Checks to make sure sailor soda implements INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new SailorSoda());
        }
    }
}
