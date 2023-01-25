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
    public partial class Customer : Form
    {
        public CoffeeShopData Data { get; set; }
        private CoffeeShopData _CoffeeShopData = new CoffeeShopData();
        public Customer(CoffeeShopData test)
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

    }
}
