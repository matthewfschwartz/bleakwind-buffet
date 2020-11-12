/*
 * Author: Matthew Schwartz
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Class to test MadOtarGrits.cs class
    /// </summary>
    public class MadOtarGritsTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into a side
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits m = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(m);
        }

        /// <summary>
        /// Makes sure the mad otar grits has the right name by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectNameByDefault()
        {
            MadOtarGrits m = new MadOtarGrits();
            Assert.Equal(m.ToString(), m.Name);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MadOtarGrits m = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(m);
        }

        /// <summary>
        /// Makes sure mad otar grits are small by default
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits m = new MadOtarGrits();
            Assert.Equal(Size.Small, m.Size);
        }
        
        /// <summary>
        /// Makes sure we can change the size of mad otar grits
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits m = new MadOtarGrits();
            m.Size = Size.Medium;
            Assert.Equal(Size.Medium, m.Size);
            m.Size = Size.Large;
            Assert.Equal(Size.Large, m.Size);
            m.Size = Size.Small;
            Assert.Equal(Size.Small, m.Size);
        }

        /// <summary>
        /// Makes sure list of special instructions for mad otar grits is empty
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits m = new MadOtarGrits();
            Assert.Empty(m.SpecialInstructions);
        }

        /// <summary>
        /// Makes sure mad otar grits have the right price based on their size
        /// </summary>
        /// <param name="size">Size of mad otar grits</param>
        /// <param name="price">Price we expect mad otar grits to have</param>
        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits m = new MadOtarGrits();
            m.Size = size;
            Assert.Equal(price, m.Price);
        }

        /// <summary>
        /// Makes sure mad otar grits have the right calorie count based on their size
        /// </summary>
        /// <param name="size">Size of mad otar grits</param>
        /// <param name="calories">Calorie count we expect mad otar grits to have</param>
        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits m = new MadOtarGrits();
            m.Size = size;
            Assert.Equal(calories, m.Calories);
        }

        /// <summary>
        /// Make sure mad otar grits have the right name based on their size
        /// </summary>
        /// <param name="size">Size of mad otar grits</param>
        /// <param name="name">Name we expect mad otar grits to have</param>
        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits m = new MadOtarGrits();
            m.Size = size;
            Assert.Equal(name, m.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]

        public void ChangingSizeShouldNotifySizeProperty(Size size)
        {
            MadOtarGrits m = new MadOtarGrits();
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
            MadOtarGrits m = new MadOtarGrits();
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
            MadOtarGrits m = new MadOtarGrits();
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
            MadOtarGrits m = new MadOtarGrits();
            Assert.PropertyChanged(m, "SpecialInstructions", () =>
            {
                m.Size = size;
            });
        }

        /// <summary>
        /// Checks to make sure mad otar grits implements INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new MadOtarGrits());
        }

        /// <summary>
        /// Makes sure Description getter returns the correct description
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            MadOtarGrits m = new MadOtarGrits();
            Assert.Equal("Cheesey Grits.", m.Description);
        }
    }
}