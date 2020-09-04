﻿/*
 * Author: Matthew Schwartz
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Runtime.InteropServices;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Class to test GardenOrcOmelette.cs class
    /// </summary>
    public class GardenOrcOmeletteTests
    {
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
    }
}