/*
 * Author: Matthew Schwartz
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class to test SmokehouseSkeleton.cs class
    /// </summary>
    public class SmokehouseSkeletonTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(s);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(s);
        }

        /// <summary>
        /// Makes sure smokehouse skeleton has sausage by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.True(s.SausageLink);
        }

        /// <summary>
        /// Makes sure smokehouse skeleton has eggs by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.True(s.Egg);
        }

        /// <summary>
        /// Makes sure smokehouse skeleton has hashbrowns by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.True(s.HashBrowns);
        }

        /// <summary>
        /// Makes sure smokehouse skeleton has pancakes by default
        /// </summary>
        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.True(s.Pancake);
        }

        /// <summary>
        /// Makes sure we can remove or add sausage
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.SausageLink = false;
            Assert.False(s.SausageLink);
            s.SausageLink = true;
            Assert.True(s.SausageLink);
        }

        /// <summary>
        /// Makes sure we can remove or add eggs
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.Egg = false;
            Assert.False(s.Egg);
            s.Egg = true;
            Assert.True(s.Egg);
        }

        /// <summary>
        /// Makes sure we can remove or add hashbrowns
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.HashBrowns = false;
            Assert.False(s.HashBrowns);
            s.HashBrowns = true;
            Assert.True(s.HashBrowns);
        }

        /// <summary>
        /// Makes sure we can remove or add pancakes
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.Pancake = false;
            Assert.False(s.Pancake);
            s.Pancake = true;
            Assert.True(s.Pancake);
        }

        /// <summary>
        /// Makes sure smokehouse skeleton has the right price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.Equal(5.62, s.Price);
        }

        /// <summary>
        /// Makes sure smokehouse skeleton has the right calorie count
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.Equal((uint)602, s.Calories);
        }

        /// <summary>
        /// Makes sure smokehouse skeleton special instructions has the right list members
        /// </summary>
        /// <param name="includeSausage">Whether the customer wants sausage or not</param>
        /// <param name="includeEgg">Whether the customer wants eggs or not</param>
        /// <param name="includeHashbrowns">Whether the customer wants hashbrowns or not</param>
        /// <param name="includePancake">Whether the customer wants pancakes or not</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.SausageLink = includeSausage;
            s.Egg = includeEgg;
            s.HashBrowns = includeHashbrowns;
            s.Pancake = includePancake;
            if (includeSausage) Assert.DoesNotContain("Hold sausage", s.SpecialInstructions);
            if (!includeSausage) Assert.Contains("Hold sausage", s.SpecialInstructions);
            if (includeEgg) Assert.DoesNotContain("Hold eggs", s.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", s.SpecialInstructions);
            if (includeHashbrowns) Assert.DoesNotContain("Hold hash browns", s.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", s.SpecialInstructions);
            if (includePancake) Assert.DoesNotContain("Hold pancakes", s.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", s.SpecialInstructions);
        }

        /// <summary>
        /// Makes sure smokehouse skeleton has the right name
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", s.ToString());
        }

        [Fact]
        public void ChangingSausageLinkShouldNotifySausageLinkProperty()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "SausageLink", () =>
            {
                s.SausageLink = true;
            });

            Assert.PropertyChanged(s, "SausageLink", () =>
            {
                s.SausageLink = false;
            });
        }

        [Fact]
        public void ChangingSausageLinkShouldNotifySpecialInstructionsProperty()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "SpecialInstructions", () =>
            {
                s.SausageLink = true;
            });

            Assert.PropertyChanged(s, "SpecialInstructions", () =>
            {
                s.SausageLink = false;
            });
        }

        [Fact]
        public void ChangingEggShouldNotifyEggProperty()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "Egg", () =>
            {
                s.Egg = true;
            });

            Assert.PropertyChanged(s, "Egg", () =>
            {
                s.Egg = false;
            });
        }

        [Fact]
        public void ChangingEggShouldNotifySpecialInstructionsProperty()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "SpecialInstructions", () =>
            {
                s.Egg = true;
            });

            Assert.PropertyChanged(s, "SpecialInstructions", () =>
            {
                s.Egg = false;
            });
        }

        [Fact]
        public void ChangingHashBrownsShouldNotifyHashBrownsProperty()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "HashBrowns", () =>
            {
                s.HashBrowns = true;
            });

            Assert.PropertyChanged(s, "HashBrowns", () =>
            {
                s.HashBrowns = false;
            });
        }

        [Fact]
        public void ChangingHashBrownsShouldNotifySpecialInstructionsProperty()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "SpecialInstructions", () =>
            {
                s.HashBrowns = true;
            });

            Assert.PropertyChanged(s, "SpecialInstructions", () =>
            {
                s.HashBrowns = false;
            });
        }

        [Fact]
        public void ChangingPancakeShouldNotifyPancakeProperty()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "Pancake", () =>
            {
                s.Pancake = true;
            });

            Assert.PropertyChanged(s, "Pancake", () =>
            {
                s.Pancake = false;
            });
        }

        [Fact]
        public void ChangingPancakeShouldNotifySpecialInstructionsProperty()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "SpecialInstructions", () =>
            {
                s.Pancake = true;
            });

            Assert.PropertyChanged(s, "SpecialInstructions", () =>
            {
                s.Pancake = false;
            });
        }
    }
}