/*
 * Author: Matthew Schwartz
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Runtime.InteropServices;
using Xunit.Sdk;
using NuGet.Frameworks;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class to test the DoubleDraugr.cs class
    /// </summary>
    public class DoubleDraugrTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(d);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(d);
        }

        /// <summary>
        /// Makes sure double draugr has a bun by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Bun);
        }

        /// <summary>
        /// Makes sure double draugr has ketchup by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Ketchup);
        }

        /// <summary>
        /// Makes sure double draugr has mustard by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Mustard);
        }

        /// <summary>
        /// Makes sure double draugr has pickle by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Pickle);
        }

        /// <summary>
        /// Makes sure double draugr has cheese by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Cheese);
        }

        /// <summary>
        /// Makes sure double draugr has tomato by default
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Tomato);
        }

        /// <summary>
        /// Makes sure double draugr has lettuce by default
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Lettuce);
        }

        /// <summary>
        /// Makes sure double draugr has mayo by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Mayo);
        }

        /// <summary>
        /// Makes sure we can remove or add bun
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Bun = false;
            Assert.False(d.Bun);
            d.Bun = true;
            Assert.True(d.Bun);
        }

        /// <summary>
        /// Makes sure we can remove or add ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Ketchup = false;
            Assert.False(d.Ketchup);
            d.Ketchup = true;
            Assert.True(d.Ketchup);
        }

        /// <summary>
        /// Make sure we can remove or add mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Mustard = false;
            Assert.False(d.Mustard);
            d.Mustard = true;
            Assert.True(d.Mustard);
        }

        /// <summary>
        /// Makes sure we can remove or add pickle
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Pickle = false;
            Assert.False(d.Pickle);
            d.Pickle = true;
            Assert.True(d.Pickle);
        }

        /// <summary>
        /// Make sure we can remove or add cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Cheese = false;
            Assert.False(d.Cheese);
            d.Cheese = true;
            Assert.True(d.Cheese);
        }

        /// <summary>
        /// Make sure we can remove or add tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Tomato = false;
            Assert.False(d.Tomato);
            d.Tomato = true;
            Assert.True(d.Tomato);
        }

        /// <summary>
        /// Makes sure we can remove or add lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Lettuce = false;
            Assert.False(d.Lettuce);
            d.Lettuce = true;
            Assert.True(d.Lettuce);
        }

        /// <summary>
        /// Makes sure we can remove or add mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Mayo = false;
            Assert.False(d.Mayo);
            d.Mayo = true;
            Assert.True(d.Mayo);
        }

        /// <summary>
        /// Makes sure double draugr has the right price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal(7.32, d.Price);
        }

        /// <summary>
        /// Makes sure double draugr has the right calorie count
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal((uint)843, d.Calories);
        }

        /// <summary>
        /// Makes sure double draugr special instructions contains the right list instructions
        /// </summary>
        /// <param name="includeBun">Whether the customer wants a bun or not</param>
        /// <param name="includeKetchup">Whether the customer wants ketchup or not</param>
        /// <param name="includeMustard">Whether the customer wants mustard or not</param>
        /// <param name="includePickle">Whether the customer wants a pickle or not</param>
        /// <param name="includeCheese">Whether the customer wants cheese or not</param>
        /// <param name="includeTomato">Whether the customer wants tomato or not</param>
        /// <param name="includeLettuce">Whether the customer wants lettuce or not</param>
        /// <param name="includeMayo">Whether the customer wants mayo or not</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Bun = includeBun;
            d.Ketchup = includeKetchup;
            d.Mustard = includeMustard;
            d.Pickle = includePickle;
            d.Cheese = includeCheese;
            d.Tomato = includeTomato;
            d.Lettuce = includeLettuce;
            d.Mayo = includeMayo;
            if (includeBun) Assert.DoesNotContain("Hold bun", d.SpecialInstructions);
            if (!includeBun) Assert.Contains("Hold bun", d.SpecialInstructions);
            if (includeKetchup) Assert.DoesNotContain("Hold ketchup", d.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", d.SpecialInstructions);
            if (includeMustard) Assert.DoesNotContain("Hold mustard", d.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", d.SpecialInstructions);
            if (includePickle) Assert.DoesNotContain("Hold pickle", d.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", d.SpecialInstructions);
            if (includeCheese) Assert.DoesNotContain("Hold cheese", d.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", d.SpecialInstructions);
            if (includeTomato) Assert.DoesNotContain("Hold tomato", d.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", d.SpecialInstructions);
            if (includeLettuce) Assert.DoesNotContain("Hold lettuce", d.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", d.SpecialInstructions);
            if (includeMayo) Assert.DoesNotContain("Hold mayo", d.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", d.SpecialInstructions);
        }

        /// <summary>
        /// Makes sure double draugr has the right name
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal("Double Draugr", d.ToString());
        }

        [Fact]
        public void ChangingBunShouldNotifyBunProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Bun", () =>
            {
                d.Bun = true;
            });

            Assert.PropertyChanged(d, "Bun", () =>
            {
                d.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunShouldNotifySpecialInstructionsProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Bun = true;
            });

            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupShouldNotifyKetchupProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Ketchup", () =>
            {
                d.Ketchup = true;
            });

            Assert.PropertyChanged(d, "Ketchup", () =>
            {
                d.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupShouldNotifySpecialInstructionsProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Ketchup = true;
            });

            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardShouldNotifyMustardProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Mustard", () =>
            {
                d.Mustard = true;
            });

            Assert.PropertyChanged(d, "Mustard", () =>
            {
                d.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardShouldNotifySpecialInstructionsProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Mustard = true;
            });

            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldNotifyPickleProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Pickle", () =>
            {
                d.Pickle = true;
            });

            Assert.PropertyChanged(d, "Pickle", () =>
            {
                d.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldNotifySpecialInstructionsProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Pickle = true;
            });

            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Pickle = false;
            });
        }

        [Fact]
        public void ChangingTomatoShouldNotifyTomatoProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Tomato", () =>
            {
                d.Tomato = true;
            });

            Assert.PropertyChanged(d, "Tomato", () =>
            {
                d.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoShouldNotifySpecialInstructionsProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Tomato = true;
            });

            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettuceShouldNotifyLettuceProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Lettuce", () =>
            {
                d.Lettuce = true;
            });

            Assert.PropertyChanged(d, "Lettuce", () =>
            {
                d.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingLettuceShouldNotifySpecialInstructionsProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Lettuce = true;
            });

            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoShouldNotifyMayoProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Mayo", () =>
            {
                d.Mayo = true;
            });

            Assert.PropertyChanged(d, "Mayo", () =>
            {
                d.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMayoShouldNotifySpecialInstructionsProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Mayo = true;
            });

            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Mayo = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldNotifyCheeseProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Cheese", () =>
            {
                d.Cheese = true;
            });

            Assert.PropertyChanged(d, "Cheese", () =>
            {
                d.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldNotifySpecialInstructionsProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Cheese = true;
            });

            Assert.PropertyChanged(d, "SpecialInstructions", () =>
            {
                d.Cheese = false;
            });
        }
    }
}