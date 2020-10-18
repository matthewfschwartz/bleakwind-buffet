using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.IO;
using System.Data;

namespace PointOfSale
{
    /// <summary>
    /// Intermediary class that updates the cash drawer in RoundRegister.CashDrawer
    /// </summary>
    public class UpdateCashDrawer : INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor for UpdateCashDrawer
        /// </summary>
        /// <param name="order">The current order</param>
        public UpdateCashDrawer(double orderTotal)
        {
            TotalCost = orderTotal;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property that enables/disables the finalize sale button
        /// </summary>
        public bool FinalizeSaleButtonEnabled
        {
            get
            {
                if (AmountDue <= 0)
                {
                    return true;
                }
                    return false;
            }
        }

        /// <summary>
        /// Method to print the receipt to receipts.txt
        /// </summary>
        /// <param name="isCash">Boolean representing whether the method of payment was cash or not</param>
        /// <param name="thisOrder">The order whose receipt we want to print</param>
        public void PrintReceipt(bool isCash, Order thisOrder)
        {
            CashDrawer.OpenDrawer();
            List<string> receipt = new List<string>();
            string addLine = "";
            StringBuilder sb = new StringBuilder();
            int index = 0;
            receipt.Add("Order #" + thisOrder.Number.ToString());
            receipt.Add(DateTime.Now.ToString());

            while (index != addLine.Length)
            {
                if (sb.Length == 40)
                {
                    receipt.Add(sb.ToString());
                    sb.Clear();
                }
                else { sb.Append(addLine[index]); }
                index++;
            }
            receipt.Add(sb.ToString());


            foreach (IOrderItem item in thisOrder)
            {
                sb.Clear();
                index = 0;
                if (item is ComboMeal comboItem)
                {
                    receipt.Add("Combo Meal - $" + comboItem.Price.ToString());
                    receipt.Add(comboItem.Entree.ToString());
                    foreach (string instruction in comboItem.Entree.SpecialInstructions)
                    {
                        receipt.Add(" -" + instruction);
                    }
                    receipt.Add(comboItem.Drink.ToString());
                    foreach (string instruction in comboItem.Drink.SpecialInstructions)
                    {
                        receipt.Add(" -" + instruction);
                    }
                    receipt.Add(comboItem.Side.ToString());
                    foreach (string instruction in comboItem.Side.SpecialInstructions)
                    {
                        receipt.Add(" -" + instruction);
                    }
                }
                
                else
                {
                    index = 0;
                    addLine = item.ToString();
                    addLine += " - $" + item.Price;
                    receipt.Add(addLine);

                    foreach (string instruction in item.SpecialInstructions)
                    {
                        addLine = " -" + instruction;
                        receipt.Add(addLine);
                    }
                }
                

            }
            receipt.Add("");
            addLine = "Subtotal: $" + thisOrder.Subtotal;
            receipt.Add(addLine);
            addLine = "Tax: $" + thisOrder.Tax;
            receipt.Add(addLine);
            addLine = "Total: $" + thisOrder.Total;
            receipt.Add(addLine);

            if (isCash)
            {
                addLine = "Payment Method: Cash";
                receipt.Add(addLine);

            }
            else
            {
                addLine = "Payment Method: Card";
                receipt.Add(addLine);
            }

            addLine = "Change Owed: $" + ChangeOwed;
            receipt.Add(addLine);
            File.WriteAllLines(@"D:\K-State Computer Science\Semester 5\CIS 400 - OO Design, Implementation, Testing\CIS400\bleakwind-buffet\Debug\receipts.txt", receipt);
            RoundRegister.RecieptPrinter.CutTape();
        }

        /// <summary>
        /// Represents the total order cost
        /// </summary>
        public double TotalCost { get; private set; }

        /// <summary>
        /// Represents the total amount paid so far
        /// </summary>
        public double TotalPaid
        {
            get 
            {
                return Math.Round(paidPennies * .01 + paidNickels * .05 + paidDimes * .1 + paidQuarters * .25 + paidHalfDollars * .5 + paidDollars +
                    paidOnes + paidTwos * 2 + paidFives * 5 + paidTens * 10 + paidTwenties * 20 + paidFifties * 50 + paidHundreds * 100, 2);
            }
        }

        /// <summary>
        /// Property representing the amount that the customer still has to pay
        /// </summary>
        public double AmountDue
        {
            get {
                double amountDue = TotalCost - TotalPaid; 
                if (amountDue < 0)
                {
                    ChangeOwed += Math.Round(amountDue * -1, 2);
                    amountDue = 0;
                }
                return Math.Round(amountDue, 2);
            }
        }

        private double changeOwed = 0;
        /// <summary>
        /// Represents the total change owed
        /// </summary>
        public double ChangeOwed
        {
            get 
            { 
                return Math.Round(changeOwed, 2); 
            }
            set
            {
                changeOwed = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
                CalculateChange();
            }
        }

        /// <summary>
        /// Method for calculating how much change the customer is owed.
        /// </summary>
        public void CalculateChange()
        {
            if (TotalPaid - TotalCost < 0)
            {
                return;
            }
            double change = TotalPaid - TotalCost;
            ChangeHundreds = (int)Math.Floor(change / 100);
            change = change % 100;
            ChangeFifties = (int)Math.Floor(change / 50);
            change = change % 50;
            ChangeTwenties = (int)Math.Floor(change / 20);
            change = change % 20;
            ChangeTens = (int)Math.Floor(change / 10);
            change = change % 10;
            ChangeFives = (int)Math.Floor(change / 5);
            change = change % 5;
            ChangeTwos = (int)Math.Floor(change / 2);
            change = change % 2;
            ChangeOnes = (int)Math.Floor(change / 1);
            change = change % 1;
            ChangeHalfDollars = (int)Math.Floor(change / .5);
            change = change % .5;
            ChangeQuarters = (int)Math.Floor(change / .25);
            change = change % .25;
            ChangeDimes = (int)Math.Floor(change / .1);
            change = change % .1;
            ChangeNickels = (int)Math.Floor(change / .05);
            change = change % .05;
            ChangePennies = (int)Math.Floor(change / .01);
            change = change % .01;
        }

        /// <summary>
        /// Property representing how many pennies the customer paid with
        /// </summary>
        private int paidPennies = 0;
        public int PaidPennies 
        { 
            get { return paidPennies; }
                
            set 
            {
                paidPennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidPennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
                
            } 
        }

        /// <summary>
        /// Property representing how many nickels the customer paid with
        /// </summary>
        private int paidNickels = 0;
        public int PaidNickels
        {
            get { return paidNickels; }

            set
            {
                paidNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
            }
        }

        /// <summary>
        /// Property representing how many dimes the customer paid with
        /// </summary>
        private int paidDimes = 0;
        public int PaidDimes
        {
            get { return paidDimes; }

            set
            {
                paidDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
            }
        }

        /// <summary>
        /// Property representing how many quarters the customer paid with
        /// </summary>
        private int paidQuarters = 0;
        public int PaidQuarters
        {
            get { return paidQuarters; }

            set
            {
                paidQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
            }
        }

        /// <summary>
        /// Property representing how many half dollars the customer paid with
        /// </summary>
        private int paidHalfDollars = 0;
        public int PaidHalfDollars
        {
            get { return paidHalfDollars; }

            set
            {
                paidHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
            }
        }

        /// <summary>
        /// Property representing how many dollars the customer paid with
        /// </summary>
        private int paidDollars = 0;
        public int PaidDollars
        {
            get { return paidDollars; }

            set
            {
                paidDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
            }
        }

        /// <summary>
        /// Property representing how many ones the customer paid with
        /// </summary>
        private int paidOnes = 0;
        public int PaidOnes
        {
            get { return paidOnes; }

            set
            {
                paidOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
            }
        }

        /// <summary>
        /// Property representing how many twos the customer paid with
        /// </summary>
        private int paidTwos = 0;
        public int PaidTwos
        {
            get { return paidTwos; }

            set
            {
                paidTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
            }
        }

        /// <summary>
        /// Property representing how many fives the customer paid with
        /// </summary>
        private int paidFives = 0;
        public int PaidFives
        {
            get { return paidFives; }

            set
            {
                paidFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
            }
        }

        /// <summary>
        /// Property representing how many tens the customer paid with
        /// </summary>
        private int paidTens = 0;
        public int PaidTens
        {
            get { return paidTens; }

            set
            {
                paidTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
            }
        }

        /// <summary>
        /// Property representing how many twenties the customer paid with
        /// </summary>
        private int paidTwenties = 0;
        public int PaidTwenties
        {
            get { return paidTwenties; }

            set
            {
                paidTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
            }
        }

        /// <summary>
        /// Property representing how many fifties the customer paid with
        /// </summary>
        private int paidFifties = 0;
        public int PaidFifties
        {
            get { return paidFifties; }

            set
            {
                paidFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
            }
        }

        /// <summary>
        /// Property representing how many hundreds the customer paid with
        /// </summary>
        private int paidHundreds = 0;
        public int PaidHundreds
        {
            get { return paidHundreds; }

            set
            {
                paidHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PaidHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FinalizeSaleButtonEnabled"));
            }
        }

        /// <summary>
        /// Property representing how many pennies the customer should get in change
        /// </summary>
        private int changePennies = 0;
        public int ChangePennies
        {
            get { return changePennies; }

            set
            {
                changePennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
            }
        }

        /// <summary>
        /// Property representing how many nickels the customer should get in change
        /// </summary>
        private int changeNickels = 0;
        public int ChangeNickels
        {
            get { return changeNickels; }

            set
            {
                changeNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
            }
        }

        /// <summary>
        /// Property representing how many dimes the customer should get in change
        /// </summary>
        private int changeDimes = 0;
        public int ChangeDimes
        {
            get { return changeDimes; }

            set
            {
                changeDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
            }
        }

        /// <summary>
        /// Property representing how many quarters the customer should get in change
        /// </summary>
        private int changeQuarters = 0;
        public int ChangeQuarters
        {
            get { return changeQuarters; }

            set
            {
                changeQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
            }
        }

        /// <summary>
        /// Property representing how many half dollars the customer should get in change
        /// </summary>
        private int changeHalfDollars = 0;
        public int ChangeHalfDollars
        {
            get { return changeHalfDollars; }

            set
            {
                changeHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHalfDollars"));
            }
        }

        /// <summary>
        /// Property representing how many dollars the customer should get in change
        /// </summary>
        private int changeDollars = 0;
        public int ChangeDollars
        {
            get { return changeDollars; }

            set
            {
                changeDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDollars"));
            }
        }

        /// <summary>
        /// Property representing how many ones the customer should get in change
        /// </summary>
        private int changeOnes = 0;
        public int ChangeOnes
        {
            get { return changeOnes; }

            set
            {
                changeOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
            }
        }

        /// <summary>
        /// Property representing how many twos the customer should get in change
        /// </summary>
        private int changeTwos = 0;
        public int ChangeTwos
        {
            get { return changeTwos; }

            set
            {
                changeTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
            }
        }

        /// <summary>
        /// Property representing how many fives the customer should get in change
        /// </summary>
        private int changeFives = 0;
        public int ChangeFives
        {
            get { return changeFives; }

            set
            {
                changeFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
            }
        }

        /// <summary>
        /// Property representing how many tens the customer should get in change
        /// </summary>
        private int changeTens = 0;
        public int ChangeTens
        {
            get { return changeTens; }

            set
            {
                changeTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
            }
        }

        /// <summary>
        /// Property representing how many twenties the customer should get in change
        /// </summary>
        private int changeTwenties = 0;
        public int ChangeTwenties
        {
            get { return changeTwenties; }

            set
            {
                changeTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
            }
        }

        /// <summary>
        /// Property representing how many fifties the customer should get in change
        /// </summary>
        private int changeFifties = 0;
        public int ChangeFifties
        {
            get { return changeFifties; }

            set
            {
                changeFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
            }
        }

        /// <summary>
        /// Property representing how many hundreds the customer should get in change
        /// </summary>
        private int changeHundreds = 0;
        public int ChangeHundreds
        {
            get { return changeHundreds; }

            set
            {
                changeHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
            }
        }

        /// <summary>
        /// Property representing the number of pennies in the cash drawer
        /// </summary>
        public int DrawerPennies { get; } = CashDrawer.Pennies;

        /// <summary>
        /// Property representing the number of nickels in the cash drawer
        /// </summary>
        public int DrawerNickels { get; } = CashDrawer.Nickels;

        /// <summary>
        /// Property representing the number of dimes in the cash drawer
        /// </summary>
        public int DrawerDimes { get; } = CashDrawer.Dimes;

        /// <summary>
        /// Property representing the number of quarters in the cash drawer
        /// </summary>
        public int DrawerQuarters { get; } = CashDrawer.Quarters;

        /// <summary>
        /// Property representing the number of half dollars in the cash drawer
        /// </summary>
        public int DrawerHalfDollars { get; } = CashDrawer.HalfDollars;

        /// <summary>
        /// Property representing the number of dollars in the cash drawer
        /// </summary>
        public int DrawerDollars { get; } = CashDrawer.Dollars;

        /// <summary>
        /// Property representing the number of ones in the cash drawer
        /// </summary>
        public int DrawerOnes { get; } = CashDrawer.Ones;

        /// <summary>
        /// Property representing the number of twos in the cash drawer
        /// </summary>
        public int DrawerTwos { get; } = CashDrawer.Twos;

        /// <summary>
        /// Property representing the number of fives in the cash drawer
        /// </summary>
        public int DrawerFives { get; } = CashDrawer.Fives;

        /// <summary>
        /// Property representing the number of tens in the cash drawer
        /// </summary>
        public int DrawerTens { get; } = CashDrawer.Tens;

        /// <summary>
        /// Property representing the number of twenties in the cash drawer
        /// </summary>
        public int DrawerTwenties { get; } = CashDrawer.Twenties;

        /// <summary>
        /// Property representing the number of fifties in the cash drawer
        /// </summary>
        public int DrawerFifties { get; } = CashDrawer.Fifties;

        /// <summary>
        /// Property representing the number of hundreds in the cash drawer
        /// </summary>
        public int DrawerHundreds { get; } = CashDrawer.Hundreds;
    }
}
