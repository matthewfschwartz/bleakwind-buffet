﻿/*
 * Author: Matthew Schwartz
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class to test GardenOrcOmelette.cs class
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        /// <summary>
        /// Makes sure we can successfully cast into an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(g);
        }

        /// <summary>
        /// Makes sure the garden orc omelette has the right name by default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectNameByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal(g.ToString(), g.Name);
        }

        /// <summary>
        /// Verifies that we can successfully cast into an IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(g);
        }

        /// <summary>
        /// Makes sure omelette has broccoli by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Broccoli);
        }

        /// <summary>
        /// Makes sure omelette has mushrooms by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Mushrooms);
        }

        /// <summary>
        /// Makes sure omelette has tomato by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Tomato);
        }

        /// <summary>
        /// Makes sure omelette has cheddar by default
        /// </summary>
        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Cheddar);
        }

        /// <summary>
        /// Makes sure we can remove or add broccoli
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Broccoli = false;
            Assert.False(g.Broccoli);
            g.Broccoli = true;
            Assert.True(g.Broccoli);
        }

        /// <summary>
        /// Makes sure we can remove or add mushrooms
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Mushrooms = false;
            Assert.False(g.Mushrooms);
            g.Mushrooms = true;
            Assert.True(g.Mushrooms);
        }

        /// <summary>
        /// Makes sure we can remove or add tomato
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Tomato = false;
            Assert.False(g.Tomato);
            g.Tomato = true;
            Assert.True(g.Tomato);
        }

        /// <summary>
        /// Makes sure we can remove or add cheddar
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Cheddar = false;
            Assert.False(g.Cheddar);
            g.Cheddar = true;
            Assert.True(g.Cheddar);
        }

        /// <summary>
        /// Makes sure omelette has the right price
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal(4.57, g.Price);
        }

        /// <summary>
        /// Makes sure omelette has the right calorie count
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal((uint)404, g.Calories);
        }

        /// <summary>
        /// Makes sure omelette has the right special instructions list
        /// </summary>
        /// <param name="includeBroccoli">Whether the customer wants broccoli or not</param>
        /// <param name="includeMushrooms">Whether the customer wants mushrooms or not</param>
        /// <param name="includeTomato">Whether the customer wants tomato or not</param>
        /// <param name="includeCheddar">Whether the customer wants cheddar or not</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Broccoli = includeBroccoli;
            g.Mushrooms = includeMushrooms;
            g.Tomato = includeTomato;
            g.Cheddar = includeCheddar;
            if (includeBroccoli) Assert.DoesNotContain("Hold broccoli", g.SpecialInstructions);
            if (!includeBroccoli) Assert.Contains("Hold broccoli", g.SpecialInstructions);
            if (includeMushrooms) Assert.DoesNotContain("Hold mushrooms", g.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", g.SpecialInstructions);
            if (includeTomato) Assert.DoesNotContain("Hold tomato", g.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", g.SpecialInstructions);
            if (includeCheddar) Assert.DoesNotContain("Hold cheddar", g.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", g.SpecialInstructions);
        }

        /// <summary>
        /// Makes sure omelette has the right name
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", g.ToString());
        }

        [Fact]
        public void ChangingBroccoliShouldNotifyBroccoliProperty()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.PropertyChanged(g, "Broccoli", () =>
            {
                g.Broccoli = true;
            });

            Assert.PropertyChanged(g, "Broccoli", () =>
            {
                g.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingBroccoliShouldNotifySpecialInstructionsProperty()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.PropertyChanged(g, "SpecialInstructions", () =>
            {
                g.Broccoli = true;
            });

            Assert.PropertyChanged(g, "SpecialInstructions", () =>
            {
                g.Broccoli = false;
            });
        }

        [Fact]
        public void ChangingMushroomsShouldNotifyMushroomsProperty()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.PropertyChanged(g, "Mushrooms", () =>
            {
                g.Mushrooms = true;
            });

            Assert.PropertyChanged(g, "Mushrooms", () =>
            {
                g.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingMushroomsShouldNotifySpecialInstructionsProperty()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.PropertyChanged(g, "SpecialInstructions", () =>
            {
                g.Mushrooms = true;
            });

            Assert.PropertyChanged(g, "SpecialInstructions", () =>
            {
                g.Mushrooms = false;
            });
        }

        [Fact]
        public void ChangingTomatoShouldNotifyTomatoProperty()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.PropertyChanged(g, "Tomato", () =>
            {
                g.Tomato = true;
            });

            Assert.PropertyChanged(g, "Tomato", () =>
            {
                g.Tomato = false;
            });
        }

        [Fact]
        public void ChangingTomatoShouldNotifySpecialInstructionsProperty()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.PropertyChanged(g, "SpecialInstructions", () =>
            {
                g.Tomato = true;
            });

            Assert.PropertyChanged(g, "SpecialInstructions", () =>
            {
                g.Tomato = false;
            });
        }

        [Fact]
        public void ChangingCheddarShouldNotifyCheddarProperty()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.PropertyChanged(g, "Cheddar", () =>
            {
                g.Cheddar = true;
            });

            Assert.PropertyChanged(g, "Cheddar", () =>
            {
                g.Cheddar = false;
            });
        }

        [Fact]
        public void ChangingCheddarShouldNotifySpecialInstructionsProperty()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.PropertyChanged(g, "SpecialInstructions", () =>
            {
                g.Cheddar = true;
            });

            Assert.PropertyChanged(g, "SpecialInstructions", () =>
            {
                g.Cheddar = false;
            });
        }

        /// <summary>
        /// Checks to make sure garden orc omelette implements INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new GardenOrcOmelette());
        }

        /// <summary>
        /// Makes sure Description getter returns the correct description
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal("Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.", g.Description);
        }
    }
}