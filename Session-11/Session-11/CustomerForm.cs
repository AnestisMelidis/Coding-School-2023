using DevExpress.Printing.Core.PdfExport.Metafile;
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
        public double Discount = 0.85;

        public CustomerForm(CoffeeShopData test)
        {
            InitializeComponent();
            _CoffeeShopData = test;

        }

        private void chkCofee_Checked(object sender, EventArgs e)
        {

            if (chkCoffee.Checked == true)
            {
                foreach (var i in _CoffeeShopData.products)
                {
                    if (i.TypeOfProduct == ProductType.Coffee)
                    {
                        cmbMenu.Items.Add(i.Description);
                    }
                }
            }
            if (chkCoffee.Checked == false)
            {
                cmbMenu.Items.Clear();
            }
        }

        private void chkBevarages_Checked(object sender, EventArgs e)
        {
            if (chkBeverages.Checked == true)
            {
                foreach (var i in _CoffeeShopData.products)
                {
                    if (i.TypeOfProduct == ProductType.Beverages)
                    {
                        cmbMenu.Items.Add(i.Description);
                    }
                }
            }
            if (chkBeverages.Checked == false)
            {
                cmbMenu.Items.Clear();
            }
        }
        private void chkFood_Checked(object sender, EventArgs e)
        {
            if (chkFood.Checked == true)
            {
                foreach (var i in _CoffeeShopData.products)
                {
                    if (i.TypeOfProduct == ProductType.Food)
                    {
                        cmbMenu.Items.Add(i.Description);
                    }
                }
            }
            if (chkFood.Checked == false)
            {
                cmbMenu.Items.Clear();
            }
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
                TotalPrice = test[0].Price * Convert.ToInt32(numQuantity.Text)
            };
            _CoffeeShopData.transactionLines.Add(transactionLine);

            gridSales.DataSource = null;
            gridSales.DataSource = _CoffeeShopData.transactionLines;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<TransactionLine> transactionLine = _CoffeeShopData.transactionLines;
            //TransactionLine transactionLine1 = new TransactionLine();
            Customer customer = new Customer();
            List<Employee> employees = _CoffeeShopData.employees;
            int length = employees.Count;
            Random ran = new Random();
            int num = ran.Next(0, length);
            double total = transactionLine.Sum(x => x.TotalPrice);
            total = DiscountCheck(total);
            var payment = CheckPayment(total);
            //MessageBox.Show("The total price after discount is: " + total.ToString());
            Transaction transaction = new Transaction()
            {
                CustomerID = customer.ID,
                EmployeeID = employees[num].ID,
                TypeOfPayment = (MethodPayment)payment,
                TotalPrice = total
            };

            _CoffeeShopData.transactions.Add(transaction);
            gridSales.DataSource = null;
            gridTransaction.DataSource = null;
            gridTransaction.DataSource = _CoffeeShopData.transactions;
        }
        public double DiscountCheck(double price)
        {
            if (price > 10)
            {
                price *= Discount;
            }
            return price;
        }
        public object CheckPayment(double price)
        {
            var test = (MethodPayment)Enum.Parse(typeof(MethodPayment), cmbPayment.SelectedItem.ToString());
            if (price > 50) 
            {
                test = MethodPayment.Cash;
            }
            return test;

        }

    }
}
