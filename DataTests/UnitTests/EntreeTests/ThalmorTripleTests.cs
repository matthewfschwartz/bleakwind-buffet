﻿/*
 * Author: Matthew Schwartz
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using NuGet.Frameworks;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class to test ThalmorTriple.cs class
    /// </summary>
    public class ThalmorTripleTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(t);
        }

        /// <summary>
        /// Makes sure the thalmor triple has the right name by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectNameByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal(t.ToString(), t.Name);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(t);
        }

        /// <summary>
        /// Makes sure thalmor triple has bun by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Bun);
        }

        /// <summary>
        /// Makes sure thalmor triple has ketchup by default
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Ketchup);
        }

        /// <summary>
        /// Makes sure thalmor triple has mustard by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Mustard);
        }

        /// <summary>
        /// Makes sure thalmor triple has pickle by default
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Pickle);
        }

        /// <summary>
        /// Makes sure thalmor triple has cheese by default
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Cheese);
        }

        /// <summary>
        /// Makes sure thalmor triple has tomato by default
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Tomato);
        }

        /// <summary>
        /// Makes sure thalmor triple has lettuce by default
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Lettuce);
        }

        /// <summary>
        /// Makes sure thalmor triple has mayo by default
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Mayo);
        }

        /// <summary>
        /// Makes sure thalmor triple has bacon by default
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Bacon);
        }

        /// <summary>
        /// Makes sure thalmor triple has egg by default
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Egg);
        }

        /// <summary>
        /// Makes sure we can remove or add bun
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Bun = false;
            Assert.False(t.Bun);
            t.Bun = true;
            Assert.True(t.Bun);
        }

        /// <summary>
        /// Makes sure we can remove or add ketchup
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Ketchup = false;
            Assert.False(t.Ketchup);
            t.Ketchup = true;
            Assert.True(t.Ketchup);
        }

        /// <summary>
        /// Makes sure we can remove or add mustard
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Mustard = false;
            Assert.False(t.Mustard);
            t.Mustard = true;
            Assert.True(t.Mustard);
        }

        /// <summary>
        /// Makes sure we can remove or add pickle
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Pickle = false;
            Assert.False(t.Pickle);
            t.Pickle = true;
            Assert.True(t.Pickle);
        }

        /// <summary>
        /// Makes sure we can remove or add cheese
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Cheese = false;
            Assert.False(t.Cheese);
            t.Cheese = true;
            Assert.True(t.Cheese);
        }

        /// <summary>
        /// Makes sure we can remove or add tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Tomato = false;
            Assert.False(t.Tomato);
            t.Tomato = true;
            Assert.True(t.Tomato);
        }

        /// <summary>
        /// Makes sure we can remove or add lettuce
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Lettuce = false;
            Assert.False(t.Lettuce);
            t.Lettuce = true;
            Assert.True(t.Lettuce);
        }

        /// <summary>
        /// Makes sure we can remove or add mayo
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Mayo = false;
            Assert.False(t.Mayo);
            t.Mayo = true;
            Assert.True(t.Mayo);
        }

        /// <summary>
        /// Makes sure we can remove or add bacon
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Bacon = false;
            Assert.False(t.Bacon);
            t.Bacon = true;
            Assert.True(t.Bacon);
        }

        /// <summary>
        /// Makes sure we can remove or add egg
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Egg = false;
            Assert.False(t.Egg);
            t.Egg = true;
            Assert.True(t.Egg);
        }

        /// <summary>
        /// Makes sure thalmor triple has the right price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal(8.32, t.Price);
        }

        /// <summary>
        /// Makes sure thalmor triple has the right calorie count
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal((uint)943, t.Calories);
        }

        /// <summary>
        /// Makes sure thalmor triple has the right special instructions list
        /// </summary>
        /// <param name="includeBun">Whether the customer wants bun or not</param>
        /// <param name="includeKetchup">Whether the customer wants ketchup or not</param>
        /// <param name="includeMustard">Whether the customer wants mustard or not</param>
        /// <param name="includePickle">Whether the customer wants pickle or not</param>
        /// <param name="includeCheese">Whether the customer wants cheese or not</param>
        /// <param name="includeTomato">Whether the customer wants tomato or not</param>
        /// <param name="includeLettuce">Whether the customer wants lettuce or not</param>
        /// <param name="includeMayo">Whether the customer wants mayo or not</param>
        /// <param name="includeBacon">Whether the customer wants bacon or not</param>
        /// <param name="includeEgg">Whether the customer wants egg or not</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Bun = includeBun;
            t.Ketchup = includeKetchup;
            t.Mustard = includeMustard;
            t.Pickle = includePickle;
            t.Cheese = includeCheese;
            t.Tomato = includeTomato;
            t.Lettuce = includeLettuce;
            t.Mayo = includeMayo;
            t.Bacon = includeBacon;
            t.Egg = includeEgg;
            if (includeBun) Assert.DoesNotContain("Hold bun", t.SpecialInstructions);
            if (!includeBun) Assert.Contains("Hold bun", t.SpecialInstructions);
            if (includeKetchup) Assert.DoesNotContain("Hold ketchup", t.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", t.SpecialInstructions);
            if (includeMustard) Assert.DoesNotContain("Hold mustard", t.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", t.SpecialInstructions);
            if (includePickle) Assert.DoesNotContain("Hold pickle", t.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", t.SpecialInstructions);
            if (includeCheese) Assert.DoesNotContain("Hold cheese", t.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", t.SpecialInstructions);
            if (includeTomato) Assert.DoesNotContain("Hold tomato", t.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", t.SpecialInstructions);
            if (includeLettuce) Assert.DoesNotContain("Hold lettuce", t.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", t.SpecialInstructions);
            if (includeMayo) Assert.DoesNotContain("Hold mayo", t.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", t.SpecialInstructions);
            if (includeBacon) Assert.DoesNotContain("Hold bacon", t.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", t.SpecialInstructions);
            if (includeEgg) Assert.DoesNotContain("Hold egg", t.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", t.SpecialInstructions);
        }

        /// <summary>
        /// Makes sure thalmor triple has the right name
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", t.ToString());
        }

        [Fact]
        public void ChangingBunShouldNotifyBunProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Bun", () =>
            {
                t.Bun = true;
            });

            Assert.PropertyChanged(t, "Bun", () =>
            {
                t.Bun = false;
            });
        }

        [Fact]
        public void ChangingBunShouldNotifySpecialInstructionsProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Bun = true;
            });

            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupShouldNotifyKetchupProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Ketchup", () =>
            {
                t.Ketchup = true;
            });

            Assert.PropertyChanged(t, "Ketchup", () =>
            {
                t.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingKetchupShouldNotifySpecialInstructionsProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Ketchup = true;
            });

            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardShouldNotifyMustardProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Mustard", () =>
            {
                t.Mustard = true;
            });

            Assert.PropertyChanged(t, "Mustard", () =>
            {
                t.Mustard = false;
            });
        }

        [Fact]
        public void ChangingMustardShouldNotifySpecialInstructionsProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Mustard = true;
            });

            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldNotifyPickleProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Pickle", () =>
            {
                t.Pickle = true;
            });

            Assert.PropertyChanged(t, "Pickle", () =>
            {
                t.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleShouldNotifySpecialInstructionsProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Pickle = true;
            });

            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Pickle = false;
            });
        }

        [Fact]
        public void ChangingTomatoShouldNotifyTomatoProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Tomato", () =>
            {
                t.Tomato = true;
            });

            Assert.PropertyChanged(t, "Tomato", () =>
            {
                t.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoShouldNotifySpecialInstructionsProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Tomato = true;
            });

            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettuceShouldNotifyLettuceProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Lettuce", () =>
            {
                t.Lettuce = true;
            });

            Assert.PropertyChanged(t, "Lettuce", () =>
            {
                t.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingLettuceShouldNotifySpecialInstructionsProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Lettuce = true;
            });

            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoShouldNotifyMayoProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Mayo", () =>
            {
                t.Mayo = true;
            });

            Assert.PropertyChanged(t, "Mayo", () =>
            {
                t.Mayo = false;
            });
        }

        [Fact]
        public void ChangingMayoShouldNotifySpecialInstructionsProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Mayo = true;
            });

            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Mayo = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldNotifyCheeseProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Cheese", () =>
            {
                t.Cheese = true;
            });

            Assert.PropertyChanged(t, "Cheese", () =>
            {
                t.Cheese = false;
            });
        }

        [Fact]
        public void ChangingCheeseShouldNotifySpecialInstructionsProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Cheese = true;
            });

            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Cheese = false;
            });
        }

        [Fact]
        public void ChangingBaconShouldNotifyBaconProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Bacon", () =>
            {
                t.Bacon = true;
            });

            Assert.PropertyChanged(t, "Bacon", () =>
            {
                t.Bacon = false;
            });
        }

        [Fact]
        public void ChangingBaconShouldNotifySpecialInstructionsProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Bacon = true;
            });

            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Bacon = false;
            });
        }

        [Fact]
        public void ChangingEggShouldNotifyEggProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Egg", () =>
            {
                t.Egg = true;
            });

            Assert.PropertyChanged(t, "Egg", () =>
            {
                t.Egg = false;
            });
        }

        [Fact]
        public void ChangingEggShouldNotifySpecialInstructionsProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Egg = true;
            });

            Assert.PropertyChanged(t, "SpecialInstructions", () =>
            {
                t.Egg = false;
            });
        }

        /// <summary>
        /// Checks to make sure thalmor triple implements INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new ThalmorTriple());
        }

        /// <summary>
        /// Makes sure Description getter returns the correct description
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.", t.Description);
        }
    }
}