/*
 * Author: Matthew Schwartz
 * Class: OrderTests.cs
 * Purpose: Class that tests the Order.cs class
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        /// <summary>
        /// Checks to make sure order implements INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom <ObservableCollection<IOrderItem>>(new Order());
        }

        /// <summary>
        /// Makes sure sales tax rate is 0.12 by default
        /// </summary>
        [Fact]
        public void SalesTaxRateShouldBeTwelvePercentByDefault()
        {
            Order o = new Order();
            Assert.Equal(0.12, o.SalesTaxRate);
        }

        /// <summary>
        /// Makes sure sales tax rate is settable
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSalesTaxRate()
        {
            Order o = new Order();
            o.SalesTaxRate = 0.2;
            Assert.Equal(0.2, o.SalesTaxRate);
        }

        /// <summary>
        /// Makes sure subtotal is 0 by default
        /// </summary>
        [Fact]
        public void SubtotalShouldBeZeroByDefault()
        {
            Order o = new Order();
            Assert.Equal(0, o.Subtotal);
        }

        /// <summary>
        /// Makes sure total is 0 by default
        /// </summary>
        [Fact]
        public void TotalShouldBeZeroByDefault()
        {
            Order o = new Order();
            Assert.Equal(0, o.Total);
        }

        /// <summary>
        /// Makes sure tax is 0 by default
        /// </summary>
        [Fact]
        public void TaxShouldBeZeroByDefault()
        {
            Order o = new Order();
            Assert.Equal(0, o.Tax);
        }

        [Fact]
        public void SubtotalShouldBeSumOfOrderItemPrices()
        {
            Order o = new Order();
            BriarheartBurger b = new BriarheartBurger();
            SailorSoda s = new SailorSoda();
            FriedMiraak f = new FriedMiraak();
            o.Add(b);
            o.Add(s);
            o.Add(f);
            Assert.Equal(b.Price + s.Price + f.Price, o.Subtotal);
        }

        [Fact]
        public void TaxShouldBeSubtotalTimesTaxRate()
        {
            Order o = new Order();
            BriarheartBurger b = new BriarheartBurger();
            SailorSoda s = new SailorSoda();
            FriedMiraak f = new FriedMiraak();
            o.Add(b);
            o.Add(s);
            o.Add(f);
            double expectedTax = (b.Price + s.Price + f.Price) * o.SalesTaxRate;
            Assert.Equal(Math.Round(expectedTax, 2), o.Tax);
        }

        [Fact]
        public void TotalShouldBeSubtotalPlusTax()
        {
            Order o = new Order();
            BriarheartBurger b = new BriarheartBurger();
            SailorSoda s = new SailorSoda();
            FriedMiraak f = new FriedMiraak();
            o.Add(b);
            o.Add(s);
            o.Add(f);
            double expectedSubtotal = b.Price + s.Price + f.Price;
            double expectedTax = expectedSubtotal * o.SalesTaxRate;
            double expectedTotal = Math.Round(expectedSubtotal + expectedTax, 2);
            Assert.Equal(expectedTotal, o.Total);
        }

        /// <summary>
        /// Makes sure calorie totals are correct
        /// </summary>
        [Fact]
        public void CaloriesShouldBeSumOfAllCaloriesInTheOrder()
        {
            Order o = new Order();
            BriarheartBurger b = new BriarheartBurger();
            SailorSoda s = new SailorSoda();
            FriedMiraak f = new FriedMiraak();
            o.Add(b);
            o.Add(s);
            o.Add(f);
            Assert.Equal(b.Calories + s.Calories + f.Calories, o.Calories);
        }

        /// <summary>
        /// Makes sure each consecutive order number increases by one
        /// </summary>
        [Fact]
        public void OrderNumberShouldIncrementWithANewOrder()
        {
            Order o = new Order();
            Order o2 = new Order();
            Assert.Equal(1, o2.Number - o.Number);
        }

        /// <summary>
        /// Makes sure adding an item notifies the order subtotal property
        /// </summary>
        [Fact]
        public void AddingItemShouldNotifySubtotalProperty()
        {
            Order o = new Order();
            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                o.Add(new DoubleDraugr());
            });
        }

        /// <summary>
        /// Makes sure adding an item notifies the order tax property
        /// </summary>
        [Fact]
        public void AddingItemShouldNotifyTaxProperty()
        {
            Order o = new Order();
            Assert.PropertyChanged(o, "Tax", () =>
            {
                o.Add(new DoubleDraugr());
            });
        }

        /// <summary>
        /// Makes sure adding an item notifies the order total property
        /// </summary>
        [Fact]
        public void AddingItemShouldNotifyTotalProperty()
        {
            Order o = new Order();
            Assert.PropertyChanged(o, "Total", () =>
            {
                o.Add(new DoubleDraugr());
            });
        }

        /// <summary>
        /// Makes sure adding an item notifies the order calories property
        /// </summary>
        [Fact]
        public void AddingItemShouldNotifyCaloriesProperty()
        {
            Order o = new Order();
            Assert.PropertyChanged(o, "Calories", () =>
            {
                o.Add(new DoubleDraugr());
            });
        }

        /// <summary>
        /// Makes sure changing an item notifies the order subtotal property
        /// </summary>
        [Fact]
        public void ChangingItemShouldNotifySubtotalProperty()
        {
            Order o = new Order();
            SailorSoda s = new SailorSoda();
            o.Add(s);
            Assert.PropertyChanged(o, "Subtotal", () =>
            {
                s.Size = Data.Enums.Size.Large;
            });
        }

        /// <summary>
        /// Makes sure changing an item notifies the order tax property
        /// </summary>
        [Fact]
        public void ChangingItemShouldNotifyTaxProperty()
        {
            Order o = new Order();
            SailorSoda s = new SailorSoda();
            o.Add(s);
            Assert.PropertyChanged(o, "Tax", () =>
            {
                s.Size = Data.Enums.Size.Large;
            });
        }

        /// <summary>
        /// Makes sure changing an item notifies the order total property
        /// </summary>
        [Fact]
        public void ChangingItemShouldNotifyTotalProperty()
        {
            Order o = new Order();
            SailorSoda s = new SailorSoda();
            o.Add(s);
            Assert.PropertyChanged(o, "Total", () =>
            {
                s.Size = Data.Enums.Size.Large;
            });
        }

        /// <summary>
        /// Makes sure changing an item notifies the order calories property
        /// </summary>
        [Fact]
        public void ChangingItemShouldNotifyCaloriesProperty()
        {
            Order o = new Order();
            SailorSoda s = new SailorSoda();
            o.Add(s);
            Assert.PropertyChanged(o, "Calories", () =>
            {
                s.Size = Data.Enums.Size.Large;
            });
        }
    }
}
