/*
 * Author: Matthew Schwartz
 * Class: Index.cs
 * Purpose: Razor page that binds to the form elements in Index.cshtml
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using static BleakwindBuffet.Data.Menu;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System.Text;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Property that contains all the IOrderItems that will be displayed on the site (after a search is made)
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; set; }

        /// <summary>
        /// Property representing a string of search terms that a user types in
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// Property representing the specific item categories that a user may choose to include in their search
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] ItemCategory { get; set; }

        /// <summary>
        /// Property that represenets the minimum calories to be displayed by user
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint CaloriesMin { get; set; } = 0;

        /// <summary>
        /// Property that represenets the maximum calories to be displayed by user
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint CaloriesMax { get; set; } = 1500;

        /// <summary>
        /// Property that represenets the minimum price to be displayed by user
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double PriceMin { get; set; } = 0;

        /// <summary>
        /// Property that represenets the maximum price to be displayed by user
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double PriceMax { get; set; } = 100;

        public void OnGet()
        {
            Items = Menu.FullMenu();
            if (SearchTerms != null)
            {
                string[] multipleTerms = SearchTerms.Split(" ");
                Items = Items.Where(item =>
                {
                    foreach(string term in multipleTerms)
                    {
                        if (item.ToString().Contains(term, StringComparison.InvariantCultureIgnoreCase)) return true;
                        if (item.Description.Contains(term, StringComparison.InvariantCultureIgnoreCase)) return true;
                    }
                    return false;
                });
            }
            if (ItemCategory != null && ItemCategory.Length != 0) {
                Items = from item in Items
                        where item.ItemCategory != null && ItemCategory.Contains(item.ItemCategory)
                        select item;
            }
            if (CaloriesMin != null && CaloriesMax != null)
            {
                Items = from item in Items
                        where item.Calories >= CaloriesMin && item.Calories <= CaloriesMax
                        select item;
            }
            if (PriceMin != null && PriceMax != null)
            {
                Items = from item in Items
                        where item.Price >= PriceMin && item.Price <= PriceMax
                        select item;
            }
            //Items = Search(SearchTerms);
            //Items = FilterByCategory(Items, ItemCategory);
            //Items = FilterByCalories(Items, CaloriesMin, CaloriesMax);
            //Items = FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
