using BleakwindBuffet.Data;
using PointOfSale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using Xunit;
//using RoundRegister;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class UpdateCashDrawerTests
    {
        /// <summary>
        /// Checks to make sure UpdateCashDrawer implements INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            //RoundRegister.CashDrawer.Reset();
            Order o = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new UpdateCashDrawer(o.Total));
        }

        [Fact]
        public void TotalCostGetterShouldGetCorrectNumber()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.Equal(o.Total, u.TotalCost);
        }

        [Fact]
        public void TotalPaidGetterShouldGetCorrectNumber()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            u.PaidTens = 1;
            Assert.Equal(10, u.TotalPaid);
        }

        [Theory]
        [InlineData(3, 5)]
        [InlineData(0, 1.5)]
        [InlineData(2, 1.7)]
        [InlineData(15, 17.89)]
        public void AmountDueGetterShouldGetCorrectNumber(int paidOnes, double totalCost)
        {
            UpdateCashDrawer u = new UpdateCashDrawer(totalCost);
            u.PaidOnes = paidOnes;
            double amountDue = Math.Round(totalCost - paidOnes, 2);
            if (amountDue < 0)
            {
                Assert.Equal(0, u.AmountDue);
            }
            else
            {
                Assert.Equal(amountDue, u.AmountDue);
            }
        }

        [Theory]
        [InlineData(15, 14.20)]
        [InlineData(2, 0.79)]
        [InlineData(1, 24)]
        public void ChangeOwedGetterShouldGetCorrectNumber(int paidOnes, double totalCost)
        {
            
            UpdateCashDrawer u = new UpdateCashDrawer(totalCost);
            u.PaidOnes = paidOnes;
            double changeOwed = Math.Round(paidOnes - totalCost, 2);
            if (changeOwed < 0)
            {
                Assert.Equal(0, u.ChangeOwed);
            }
            else
            {
                u.ChangeOwed = changeOwed;
                Assert.Equal(changeOwed, u.ChangeOwed);
            }
        }

        /// <summary>
        /// Makes sure changing the paid pennies property notifies paid pennies property
        /// </summary>
        [Fact]
        public void ChangingPaidPenniesShouldNotifyPaidPenniesProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidPennies", () =>
            {
                u.PaidPennies++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid pennies property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidPenniesShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidPennies++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid pennies property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidPenniesShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidPennies++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid nickels property notifies paid nickels property
        /// </summary>
        [Fact]
        public void ChangingPaidNickelsShouldNotifyPaidNickelsProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidNickels", () =>
            {
                u.PaidNickels++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid nickels property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidNickelsShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidNickels++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid nickels property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidNickelsShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidNickels++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid dimes property notifies paid dimes property
        /// </summary>
        [Fact]
        public void ChangingPaidDimesShouldNotifyPaidDimesProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidDimes", () =>
            {
                u.PaidDimes++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid dimes property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidDimesShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidDimes++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid dimes property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidDimesShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidDimes++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid quarters property notifies paid quarters property
        /// </summary>
        [Fact]
        public void ChangingPaidQuartersShouldNotifyPaidQuartersProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidQuarters", () =>
            {
                u.PaidQuarters++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid quarters property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidQuartersShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidQuarters++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid quarters property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidQuartersShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidQuarters++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid half dollars property notifies paid half dollars property
        /// </summary>
        [Fact]
        public void ChangingPaidHalfDollarsShouldNotifyPaidHalfDollarsProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidHalfDollars", () =>
            {
                u.PaidHalfDollars++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid half dollars property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidHalfDollarsShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidHalfDollars++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid half dollars property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidHalfDollarsShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidHalfDollars++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid dollars property notifies paid quarters property
        /// </summary>
        [Fact]
        public void ChangingPaidDollarsShouldNotifyPaidDollarsProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidDollars", () =>
            {
                u.PaidDollars++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid dollars property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidDollarsShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidDollars++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid dollars property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidDollarsShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidDollars++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid ones property notifies paid ones property
        /// </summary>
        [Fact]
        public void ChangingPaidOnesShouldNotifyPaidOnesProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidOnes", () =>
            {
                u.PaidOnes++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid ones property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidOnesShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidOnes++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid ones property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidOnesShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidOnes++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid quarters property notifies paid quarters property
        /// </summary>
        [Fact]
        public void ChangingPaidTwosShouldNotifyPaidTwosProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidTwos", () =>
            {
                u.PaidTwos++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid twos property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidTwosShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidTwos++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid twos property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidTwosShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidTwos++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid fives property notifies paid fives property
        /// </summary>
        [Fact]
        public void ChangingPaidFivesShouldNotifyPaidQuartersProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidFives", () =>
            {
                u.PaidFives++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid fives property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidFivesShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidFives++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid fives property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidFivesShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidFives++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid tens property notifies paid tens property
        /// </summary>
        [Fact]
        public void ChangingPaidTensShouldNotifyPaidTensProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidTens", () =>
            {
                u.PaidTens++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid tens property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidTensShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidTens++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid tens property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidTensShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidTens++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid twenties property notifies paid twenties property
        /// </summary>
        [Fact]
        public void ChangingPaidTwentiesShouldNotifyPaidTwentiesProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidTwenties", () =>
            {
                u.PaidTwenties++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid twenties property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidTwentiesShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidTwenties++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid twenties property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidTwentiesShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidTwenties++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid fifties property notifies paid fifties property
        /// </summary>
        [Fact]
        public void ChangingPaidFiftiesShouldNotifyPaidFiftiesProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidFifties", () =>
            {
                u.PaidFifties++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid fifties property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidFiftiesShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidFifties++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid fifties property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidFitfiesShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidFifties++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid hundreds property notifies paid hundreds property
        /// </summary>
        [Fact]
        public void ChangingPaidHundredsShouldNotifyPaidHundredsProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "PaidHundreds", () =>
            {
                u.PaidHundreds++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid hundreds property notifies total paid property
        /// </summary>
        [Fact]
        public void ChangingPaidHundredsShouldNotifyTotalPaidProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "TotalPaid", () =>
            {
                u.PaidHundreds++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid hundreds property notifies amount due property
        /// </summary>
        [Fact]
        public void ChangingPaidHundredsShouldNotifyAmountDueProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "AmountDue", () =>
            {
                u.PaidHundreds++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid fifties property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidFiftiesShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidFifties++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid twenties property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidTwentiesShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidTwenties++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid tens property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidTensShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidTens++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid fives property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidFivesShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidFives++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid twos property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidTwosShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidTwos++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid ones property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidOnesShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidOnes++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid dollars property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidDollarsShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidDollars++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid half dollars property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidHalfDollarsShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidHalfDollars++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid quarters property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidQuartersShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidQuarters++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid dimes property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidDimesShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidDimes++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid nickels property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidNickelsShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidNickels++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid pennies property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidPenniesShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidPennies++;
            });
        }

        /// <summary>
        /// Makes sure changing the paid hundreds property notifies FinalizeSaleButtonEnabled property
        /// </summary>
        [Fact]
        public void ChangingPaidHundredsShouldNotifyFinalizeSaleButtonEnabledProperty()
        {
            Order o = new Order();
            UpdateCashDrawer u = new UpdateCashDrawer(o.Total);
            Assert.PropertyChanged(u, "FinalizeSaleButtonEnabled", () =>
            {
                u.PaidHundreds++;
            });
        }

        /// <summary>
        /// Makes sure ChangePennies is settable
        /// </summary>
        [Fact]
        public void ChangePenniesShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangePennies = 1;
            Assert.Equal(1, u.ChangePennies);
        }

        /// <summary>
        /// Makes sure ChangeNickels is settable
        /// </summary>
        [Fact]
        public void ChangeNickelsShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangeNickels = 1;
            Assert.Equal(1, u.ChangeNickels);
        }

        /// <summary>
        /// Makes sure ChangeDimes is settable
        /// </summary>
        [Fact]
        public void ChangeDimesShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangeDimes = 1;
            Assert.Equal(1, u.ChangeDimes);
        }

        /// <summary>
        /// Makes sure ChangeQuarters is settable
        /// </summary>
        [Fact]
        public void ChangeQuartersShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangeQuarters = 1;
            Assert.Equal(1, u.ChangeQuarters);
        }

        /// <summary>
        /// Makes sure ChangeHalfDollars is settable
        /// </summary>
        [Fact]
        public void ChangeHalfDollarsShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangeHalfDollars = 1;
            Assert.Equal(1, u.ChangeHalfDollars);
        }

        /// <summary>
        /// Makes sure ChangeDollars is settable
        /// </summary>
        [Fact]
        public void ChangeDollarsShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangeDollars = 1;
            Assert.Equal(1, u.ChangeDollars);
        }

        /// <summary>
        /// Makes sure ChangeOnes is settable
        /// </summary>
        [Fact]
        public void ChangeOnesShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangeOnes = 1;
            Assert.Equal(1, u.ChangeOnes);
        }

        /// <summary>
        /// Makes sure ChangeTwos is settable
        /// </summary>
        [Fact]
        public void ChangeTwosShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangeTwos = 1;
            Assert.Equal(1, u.ChangeTwos);
        }

        /// <summary>
        /// Makes sure ChangeFives is settable
        /// </summary>
        [Fact]
        public void ChangeFivesShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangeFives = 1;
            Assert.Equal(1, u.ChangeFives);
        }

        /// <summary>
        /// Makes sure ChangeTens is settable
        /// </summary>
        [Fact]
        public void ChangeTensShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangeTens = 1;
            Assert.Equal(1, u.ChangeTens);
        }

        /// <summary>
        /// Makes sure ChangeTwenties is settable
        /// </summary>
        [Fact]
        public void ChangeTwentiesShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangeTwenties = 1;
            Assert.Equal(1, u.ChangeTwenties);
        }

        /// <summary>
        /// Makes sure ChangeFifties is settable
        /// </summary>
        [Fact]
        public void ChangeFiftiesShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangeFifties = 1;
            Assert.Equal(1, u.ChangeFifties);
        }

        /// <summary>
        /// Makes sure ChangeHundreds is settable
        /// </summary>
        [Fact]
        public void ChangeHundredsShouldBeSettable()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            u.ChangeHundreds = 1;
            Assert.Equal(1, u.ChangeHundreds);
        }

        /// <summary>
        /// Makes sure changing ChangeHundreds notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangeHundredsShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangeHundreds", () =>
            {
                u.ChangeHundreds++;
            });
        }

        /// <summary>
        /// Makes sure changing ChangeFifties notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangeFiftiesShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangeFifties", () =>
            {
                u.ChangeFifties++;
            });
        }

        /// <summary>
        /// Makes sure changing ChangeTwenties notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangeTwentiesShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangeTwenties", () =>
            {
                u.ChangeTwenties++;
            });
        }

        /// <summary>
        /// Makes sure changing ChangeTens notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangeTensShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangeTens", () =>
            {
                u.ChangeTens++;
            });
        }

        /// <summary>
        /// Makes sure changing ChangeFives notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangeFivesShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangeFives", () =>
            {
                u.ChangeFives++;
            });
        }

        /// <summary>
        /// Makes sure changing ChangeTwos notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangeTwosShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangeTwos", () =>
            {
                u.ChangeTwos++;
            });
        }

        /// <summary>
        /// Makes sure changing ChangeOnes notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangeOnesShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangeOnes", () =>
            {
                u.ChangeOnes++;
            });
        }

        /// <summary>
        /// Makes sure changing ChangeDollars notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangeDollarsShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangeDollars", () =>
            {
                u.ChangeDollars++;
            });
        }

        /// <summary>
        /// Makes sure changing ChangeHalfDollars notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangeHalfDollarsShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangeHalfDollars", () =>
            {
                u.ChangeHalfDollars++;
            });
        }

        /// <summary>
        /// Makes sure changing ChangeQuarters notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangeQuartersShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangeQuarters", () =>
            {
                u.ChangeQuarters++;
            });
        }

        /// <summary>
        /// Makes sure changing ChangeDimes notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangeDimesShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangeDimes", () =>
            {
                u.ChangeDimes++;
            });
        }

        /// <summary>
        /// Makes sure changing ChangeNickels notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangeNickelsShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangeNickels", () =>
            {
                u.ChangeNickels++;
            });
        }

        /// <summary>
        /// Makes sure changing ChangePennies notifies property changed
        /// </summary>
        [Fact]
        public void ChangingChangePenniesShouldNotifyPropertyChanged()
        {
            UpdateCashDrawer u = new UpdateCashDrawer(0);
            Assert.PropertyChanged(u, "ChangePennies", () =>
            {
                u.ChangePennies++;
            });
        }
    }
}
