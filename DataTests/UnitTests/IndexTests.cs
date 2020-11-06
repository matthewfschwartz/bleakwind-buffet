/*
 * Author: Matthew Schwartz
 * Class: IndexTests.cs
 * Purpose: Class that tests the Index.cshtml.cs class and how it interacts with Menu
 */

using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls.Primitives;
using Website.Pages;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class IndexTests
    {
        /// <summary>
        /// Makes sure that index is inheriting PageModel correctly
        /// </summary>
        [Fact]
        public void IndexShouldBeAssignableFromPageModel()
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            Assert.IsAssignableFrom<PageModel>(index);
        }

        /// <summary>
        /// Makes sure a null search returns a full menu
        /// </summary>
        [Fact]
        public void NullSearchShouldReturnFullMenu()
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.SearchTerms = null;
            index.OnGet();
            List<IOrderItem> menu = Menu.FullMenu();
            foreach (IOrderItem menuItem in index.Items)
            {
                Assert.Contains(menu, item =>
                {
                    return item.ToString().Equals(menuItem.ToString());
                });
            }
        }

        /// <summary>
        /// Makes sure a search done returns only items whose names contain the given search terms
        /// </summary>
        /// <param name="terms">A string searched for</param>
        [Theory]
        [InlineData("burger")]
        [InlineData("th")]
        [InlineData("dra")]
        public void SearchShouldReturnOnlyItemsContainingSearchTerms(string terms)
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.SearchTerms = terms;
            index.OnGet();
            List<IOrderItem> menu = Menu.FullMenu();
            menu = index.Items as List<IOrderItem>;
            foreach (IOrderItem menuItem in menu)
            {
                Assert.Contains(menu, item =>
                {
                    return item.ToString().Equals(menuItem.ToString());
                });
            }
        }

        /// <summary>
        /// Makes sure a null item category returns a full menu
        /// </summary>
        [Fact]
        public void NullItemCategoryShouldReturnFullMenu()
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.ItemCategory = null;
            index.OnGet();
            List<IOrderItem> menu = Menu.FullMenu();
            foreach (IOrderItem menuItem in index.Items)
            {
                Assert.Contains(menu, item =>
                {
                    return item.ToString().Equals(menuItem.ToString());
                });
            }
        }

        /// <summary>
        /// Makes sure that an entree selection shows only entrees
        /// </summary>
        [Fact]
        public void EntreeItemCategoryShouldShowOnlyEntrees()
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.ItemCategory = new string[]{"Entree"};
            index.OnGet();
            List<IOrderItem> menu = Menu.Entrees();
            foreach (IOrderItem menuItem in index.Items)
            {
                Assert.Contains(menu, item =>
                {
                    return item.ToString().Equals(menuItem.ToString());
                });
            }
        }

        /// <summary>
        /// Makes sure that an drink selection shows only drinks
        /// </summary>
        [Fact]
        public void DrinkItemCategoryShouldShowOnlyDrinks()
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.ItemCategory = new string[] { "Drink" };
            index.OnGet();
            List<IOrderItem> menu = Menu.Drinks();
            foreach (IOrderItem menuItem in index.Items)
            {
                Assert.Contains(menu, item =>
                {
                    return item.ToString().Equals(menuItem.ToString());
                });
            }
        }

        /// <summary>
        /// Makes sure that an side selection shows only sides
        /// </summary>
        [Fact]
        public void SideItemCategoryShouldShowOnlySides()
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.ItemCategory = new string[] { "Side" };
            index.OnGet();
            List<IOrderItem> menu = Menu.Sides();
            foreach (IOrderItem menuItem in index.Items)
            {
                Assert.Contains(menu, item =>
                {
                    return item.ToString().Equals(menuItem.ToString());
                });
            }
        }

        /// <summary>
        /// Multiple item category selections should include both
        /// </summary>
        [Fact]
        public void MultipleItemCategoriesSelectedShouldShowCorrectCategories()
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.ItemCategory = new string[] { "Entree", "Drink" };
            index.OnGet();
            var menu = Menu.Entrees().Concat(Menu.Drinks());
            foreach (IOrderItem menuItem in index.Items)
            {
                Assert.Contains(menu, item =>
                {
                    return item.ToString().Equals(menuItem.ToString());
                });
            }
        }

        /// <summary>
        /// Makes sure a null min calories and max calories returns a full menu
        /// </summary>
        [Fact]
        public void NullCaloriesMinCaloriesMaxShouldReturnFullMenu()
        {
            List<IOrderItem> menu = Menu.FullMenu();
            menu = Menu.FilterByCalories(menu, null, null) as List<IOrderItem>;
            foreach (IOrderItem menuItem in Menu.FullMenu())
            {
                Assert.Contains(menu, item =>
                {
                    return item.ToString().Equals(menuItem.ToString());
                });
            }
        }

        /// <summary>
        /// Makes sure that putting calorie restrictions on a search only shows valid search results
        /// </summary>
        /// <param name="min">Minimum calories</param>
        /// <param name="max">Maximum calories</param>
        [Theory]
        [InlineData(100, 1200)]
        [InlineData(0, 500)]
        [InlineData(300, 400)]
        public void SettingCalorieRestrictionsShouldReturnOnlyValidItems(uint min, uint max)
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.CaloriesMin = min;
            index.CaloriesMax = max;
            index.OnGet();
            List<IOrderItem> menu = Menu.FullMenu();
            menu = index.Items as List<IOrderItem>;
            foreach (IOrderItem menuItem in menu)
            {
                Assert.Contains(menu, item =>
                {
                    return item.ToString().Equals(menuItem.ToString());
                });
            }
        }

        /// <summary>
        /// Makes sure a null min price and max price returns a full menu
        /// </summary>
        [Fact]
        public void NullPriceMinPriceMaxShouldReturnFullMenu()
        {
            List<IOrderItem> menu = Menu.FullMenu();
            menu = Menu.FilterByPrice(menu, null, null) as List<IOrderItem>;
            foreach (IOrderItem menuItem in Menu.FullMenu())
            {
                Assert.Contains(menu, item =>
                {
                    return item.ToString().Equals(menuItem.ToString());
                });
            }
        }

        /// <summary>
        /// Makes sure that putting price restrictions on a search only shows valid search results
        /// </summary>
        /// <param name="min">Minimum price</param>
        /// <param name="max">Maximum price</param>
        [Theory]
        [InlineData(0, 5)]
        [InlineData(2.5, 12.2)]
        [InlineData(1.1, 3.25)]
        public void SettingPriceRestrictionsShouldReturnOnlyValidItems(double min, double max)
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.PriceMin = min;
            index.PriceMax = max;
            index.OnGet();
            List<IOrderItem> menu = Menu.FullMenu();
            menu = index.Items as List<IOrderItem>;
            foreach (IOrderItem menuItem in menu)
            {
                Assert.Contains(menu, item =>
                {
                    return item.ToString().Equals(menuItem.ToString());
                });
            }
        }

        /// <summary>
        /// Makes sure CaloriesMin is settable
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMinCalories()
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.CaloriesMin = (uint)100;
            Assert.Equal((uint)100, index.CaloriesMin);
        }

        /// <summary>
        /// Makes sure CaloriesMax is settable
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMaxCalories()
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.CaloriesMax = (uint)100;
            Assert.Equal((uint)100, index.CaloriesMax);
        }

        /// <summary>
        /// Makes sure PriceMin is settable
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMinPrice()
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.PriceMin = 6.50;
            Assert.Equal(6.50, index.PriceMin);
        }

        /// <summary>
        /// Makes sure PriceMax is settable
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMaxPrice()
        {
            IndexModel index = new IndexModel(new ILoggerMock<IndexModel>());
            index.PriceMax = 6.50;
            Assert.Equal(6.50, index.PriceMax);
        }
    }
}
