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

namespace Session_11
{
    public partial class CustomerForm : Form
    {
        public CoffeeShopData Data { get; set; }
        private CoffeeShopData _CoffeeShopData = new CoffeeShopData();

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
                Price= test[0].Price,
                TotalPrice = test[0].Price * Convert.ToInt32(numQuantity.Text)
            };
            _CoffeeShopData.transactionLines.Add(transactionLine);

            gridSales.DataSource = null;
            gridSales.DataSource = _CoffeeShopData.transactionLines;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<TransactionLine> transactionLine = _CoffeeShopData.transactionLines;
            TransactionLine transactionLine1 = new TransactionLine();
            Customer customer = new Customer();
            double total = transactionLine.Sum(x => x.TotalPrice);
            total = transactionLine1.DiscountCheck(total);
            MessageBox.Show("The total price after discount is: " + total.ToString());
            Transaction transaction = new Transaction()
            {

                TotalPrice = total
            };
        }
    }
}
