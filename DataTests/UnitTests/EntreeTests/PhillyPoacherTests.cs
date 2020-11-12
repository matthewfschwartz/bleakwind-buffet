/*
 * Author: Matthew Schwartz
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class to test PhillyPoacher.cs class
    /// </summary>
    public class PhillyPoacherTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(p);
        }

        /// <summary>
        /// Makes sure the philly poacher has the right name by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectNameByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal(p.ToString(), p.Name);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(p);
        }

        /// <summary>
        /// Makes sure philly poacher has sirloin by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Sirloin);
        }

        /// <summary>
        /// Makes sure philly poacher has onion by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Onion);
        }

        /// <summary>
        /// Makes sure philly poacher has roll by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Roll);
        }

        /// <summary>
        /// Makes sure we can remove or add sirloin
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Sirloin = false;
            Assert.False(p.Sirloin);
            p.Sirloin = true;
            Assert.True(p.Sirloin);
        }

        /// <summary>
        /// Makes sure we can remove or add onions
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Onion = false;
            Assert.False(p.Onion);
            p.Onion = true;
            Assert.True(p.Onion);
        }

        /// <summary>
        /// Makes sure we can remove or add roll
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Roll = false;
            Assert.False(p.Roll);
            p.Roll = true;
            Assert.True(p.Roll);
        }

        /// <summary>
        /// Makes sure philly poacher has the right price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal(7.23, p.Price);
        }

        /// <summary>
        /// Makes sure philly poacher has the right calorie count
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal((uint)784, p.Calories);
        }

        /// <summary>
        /// Makes sure philly poacher has the right special instructions list
        /// </summary>
        /// <param name="includeSirloin">Whether the customer wants sirloin or not</param>
        /// <param name="includeOnion">Whether the customer wants onions or not</param>
        /// <param name="includeRoll">Whether the customer wants the roll or not</param>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Sirloin = includeSirloin;
            p.Onion = includeOnion;
            p.Roll = includeRoll;
            if (includeSirloin) Assert.DoesNotContain("Hold sirloin", p.SpecialInstructions);
            if (!includeSirloin) Assert.Contains("Hold sirloin", p.SpecialInstructions);
            if (includeOnion) Assert.DoesNotContain("Hold onions", p.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onions", p.SpecialInstructions);
            if (includeRoll) Assert.DoesNotContain("Hold roll", p.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", p.SpecialInstructions);
        }

        /// <summary>
        /// Makes sure philly poacher has the right name
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal("Philly Poacher", p.ToString());
        }

        [Fact]
        public void ChangingSirloinShouldNotifySirloinProperty()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.PropertyChanged(p, "Sirloin", () =>
            {
                p.Sirloin = true;
            });

            Assert.PropertyChanged(p, "Sirloin", () =>
            {
                p.Sirloin = false;
            });
        }

        [Fact]
        public void ChangingSirloinShouldNotifySpecialInstructionsProperty()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.PropertyChanged(p, "SpecialInstructions", () =>
            {
                p.Sirloin = true;
            });

            Assert.PropertyChanged(p, "SpecialInstructions", () =>
            {
                p.Sirloin = false;
            });
        }

        [Fact]
        public void ChangingOnionShouldNotifyOnionProperty()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.PropertyChanged(p, "Onion", () =>
            {
                p.Onion = true;
            });

            Assert.PropertyChanged(p, "Onion", () =>
            {
                p.Onion = false;
            });
        }

        [Fact]
        public void ChangingOnionShouldNotifySpecialInstructionsProperty()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.PropertyChanged(p, "SpecialInstructions", () =>
            {
                p.Onion = true;
            });

            Assert.PropertyChanged(p, "SpecialInstructions", () =>
            {
                p.Onion = false;
            });
        }

        [Fact]
        public void ChangingRollShouldNotifyRollProperty()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.PropertyChanged(p, "Roll", () =>
            {
                p.Roll = true;
            });

            Assert.PropertyChanged(p, "Roll", () =>
            {
                p.Roll = false;
            });
        }

        [Fact]
        public void ChangingRollShouldNotifySpecialInstructionsProperty()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.PropertyChanged(p, "SpecialInstructions", () =>
            {
                p.Roll = true;
            });

            Assert.PropertyChanged(p, "SpecialInstructions", () =>
            {
                p.Roll = false;
            });
        }

        /// <summary>
        /// Checks to make sure philly poacher implements INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new PhillyPoacher());
        }

        /// <summary>
        /// Makes sure Description getter returns the correct description
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.", p.Description);
        }
    }
}