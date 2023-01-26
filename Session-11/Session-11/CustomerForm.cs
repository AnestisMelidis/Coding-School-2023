﻿using DevExpress.Printing.Core.PdfExport.Metafile;
using DevExpress.XtraCharts;
using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Library.Product;
using static Library.Transaction;

namespace Session_11
{
    public partial class CustomerForm : Form
    {
        public CoffeeShopData Data { get; set; }
        private CoffeeShopData _CoffeeShopData = new CoffeeShopData();
        public decimal Discount = 0.85m;
        Serializer serializer = new Serializer();
        List<TransactionLine> lines = new List<TransactionLine>();
        List<Transaction> trans = new List<Transaction>(); 

        public CustomerForm(CoffeeShopData test)
        {
            InitializeComponent();
            _CoffeeShopData = test;

        }

        public void WriteJson(object obj, string file)
        {
            serializer.SerializeToFile(obj, file);
        }

            private void addToCart_Click(object sender, EventArgs e)
        {

            List<Product> products = _CoffeeShopData.products;
            
            var test = (products.Where(x => x.Description == cmbMenu.Text).ToList());
            TransactionLine transactionLine = new TransactionLine()
            {
                Description = cmbMenu.Text,
                Quantity = Convert.ToInt32(numQuantity.Text),
                ProductID = test[0].ProductCategoryID,
                Price = test[0].Price,
                TotalCost = test[0].Cost * Convert.ToInt32(numQuantity.Text),
                TotalPrice = test[0].Price * Convert.ToInt32(numQuantity.Text)
            };
            lines.Add(transactionLine);

            gridSales.DataSource = null;
            gridSales.DataSource = lines;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<TransactionLine> transactionLine = _CoffeeShopData.transactionLines;
            Customer customer = new Customer();
            List<Employee> employees = _CoffeeShopData.employees;
            int length = employees.Count;
            Random ran = new Random();
            int num = ran.Next(0, length);
            decimal totalPrice = lines.Sum(x => x.TotalPrice);
            decimal totalCost = lines.Sum(x => x.TotalCost);
            totalPrice = DiscountCheck(totalPrice);
            var payment = CheckPayment(totalPrice);
            Transaction transaction = new Transaction()
            {
                CustomerID = customer.ID,
                EmployeeID = employees[num].ID,
                TypeOfPayment = (MethodPayment)payment,
                TotalPrice = totalPrice,
                Cost = totalCost
            };

            lines.Clear();
            trans.Add(transaction);
            _CoffeeShopData.transactions.Add(transaction);
            LedgerEntry();
            gridSales.DataSource = null;
            gridTransaction.DataSource = null;
            gridTransaction.DataSource = trans;
            WriteJson(_CoffeeShopData, "test1.json");

        }
        public decimal DiscountCheck(decimal price)
        {
            if (price > 10)
            {
                price *= Discount;
            }
            return price;
        }
        public object CheckPayment(decimal price)
        {
            var test = (MethodPayment)Enum.Parse(typeof(MethodPayment), cmbPayment.SelectedItem.ToString());
            if (price > 50) 
            {
                test = MethodPayment.Cash;
            }
            return test;

        }
        public void LedgerEntry()
        {
            int rent = 3000;
            List<Transaction> transactions = _CoffeeShopData.transactions;
            List<Employee> employees = _CoffeeShopData.employees;
            decimal income = transactions.Sum(x => x.TotalPrice);
            decimal expensesProd = transactions.Sum(x => x.Cost);
            decimal expensesSal = employees.Sum(x => x.SalaryPerMonth);
            decimal total = (income - expensesProd - expensesSal - rent);
            MonthlyLedger ledger = new MonthlyLedger()
            {
                Income = income,
                Expenses = expensesProd + expensesSal + rent,
                Total = total
            };
            _CoffeeShopData.monthlyLedgers.Add(ledger);
        }



        private void radCoffee_CheckedChanged(object sender, EventArgs e)
        {
            cmbMenu.Items.Clear();
            if (radCoffee.Checked == true)
            {
                foreach (var i in _CoffeeShopData.products)
                {
                    if (i.TypeOfProduct == ProductType.Coffee)
                    {
                        cmbMenu.Items.Add(i.Description);
                    }
                }
            }
        }
        private void radBeverages_CheckedChanged(object sender, EventArgs e)
        {
            cmbMenu.Items.Clear();
            if (radBeverages.Checked == true)
            {
                cmbMenu.SelectedItem = -1;
                foreach (var i in _CoffeeShopData.products)
                {
                    if (i.TypeOfProduct == ProductType.Beverages)
                    {
                        cmbMenu.Items.Add(i.Description);
                    }
                }
            }
        }
        private void radFood_CheckedChanged(object sender, EventArgs e)
        {
            cmbMenu.Items.Clear();
            if (radFood.Checked == true)
            {
                foreach (var i in _CoffeeShopData.products)
                {
                    if (i.TypeOfProduct == ProductType.Food)
                    {
                        cmbMenu.Items.Add(i.Description);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntryPoint entryPoint = new EntryPoint();
            entryPoint.Show();
        }
    }
}
