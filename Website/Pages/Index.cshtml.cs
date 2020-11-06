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

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IEnumerable<IOrderItem> Items { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        [BindProperty(SupportsGet = true)]
        public string[] ItemCategory { get; set; }

        [BindProperty(SupportsGet = true)]
        public uint CaloriesMin { get; set; } = 0;

        [BindProperty(SupportsGet = true)]
        public uint CaloriesMax { get; set; } = 1500;

        [BindProperty(SupportsGet = true)]
        public double PriceMin { get; set; } = 0;

        [BindProperty(SupportsGet = true)]
        public double PriceMax { get; set; } = 100;

        public void OnGet()
        {
            Items = Search(SearchTerms);
            Items = FilterByCategory(Items, ItemCategory);
            Items = FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
