/*
 * Author: Matthew Schwartz
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class to test ThugsTBone.cs class
    /// </summary>
    public class ThugsTBoneTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTBone t = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(t);
        }

        /// <summary>
        /// Makes sure the thugs tbone has the right name by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectNameByDefault()
        {
            ThugsTBone t = new ThugsTBone();
            Assert.Equal(t.ToString(), t.Name);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThugsTBone t = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(t);
        }

        /// <summary>
        /// Make sure thugs tbone has the right price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone t = new ThugsTBone();
            Assert.Equal(6.44, t.Price);
        }

        /// <summary>
        /// Makes sure thugs tbone has the right calorie count
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone t = new ThugsTBone();
            Assert.Equal((uint)982, t.Calories);
        }

        /// <summary>
        /// Makes sure thugs tbone special instructions list is empty
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone t = new ThugsTBone();
            Assert.Empty(t.SpecialInstructions);
        }

        /// <summary>
        /// Makes sure thugs tbone has the right name
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone t = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", t.ToString());
        }

        /// <summary>
        /// Checks to make sure thugs tbone implements INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new ThugsTBone());
        }
    }
}