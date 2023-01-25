using DevExpress.DataAccess.Native.Data;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Cms;
using DevExpress.Utils.DPI;
using DevExpress.XtraCharts;
using DevExpress.XtraSpreadsheet.Export;
using DevExpress.XtraSpreadsheet.Model;
using Library;
using System.Collections.ObjectModel;
using System.Linq;
using static Library.Product;

namespace Session_11
{
    public partial class Form1 : Form {
       
        public CoffeeShopData Data { get; set; }
        private CoffeeShopData _CoffeeShopData=new CoffeeShopData();
        
        List<Product> products;
        List<Employee> employees;
        List<TransactionLine> transaction_Lines;
        Serializer serializer = new Serializer();
        
        int cnt = 0;

        public Form1() {
            
            
           
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void chkCofee_Checked(object sender, EventArgs e)
        {

            if (chkCoffee.Checked == true)
            {
                foreach (var i in products)
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
                foreach (var i in products)
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
                foreach (var i in products)
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

        public void WriteJson(object obj, string file) {
            serializer.SerializeToFile(obj, file);
        }

        public void LoadJson(string file) {
            object employees = serializer.DeserializeFromFile<Employee>(file);
          
        }


        public void btnSaveEmployeesClick(object sender, EventArgs e) 
        {
            

            Employee newEmployee = new Employee() {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                TypeOfEmployee = (EmployeeType)Enum.Parse(typeof(EmployeeType), cmbType.SelectedItem.ToString()),
                SalaryPerMonth = Convert.ToDouble(txtSalary.Text)
            };

            _CoffeeShopData.employees.Add(newEmployee);
            
        }
    public void btnSaveProductsClick(object sender, EventArgs e)
        {
            Product newProduct = new Product()
            {
                Code = cnt,
                Description = txtDesc.Text,
                TypeOfProduct = (ProductType)Enum.Parse(typeof(ProductType), cmbProType.SelectedItem.ToString()),
                Price = Convert.ToDouble(txtPrice.Text),
                Cost = Convert.ToDouble(txtCost.Text)
            };
            cnt++;
            _CoffeeShopData.products.Add(newProduct);
        }



        public void btnLoadEmployeesClick(object sender, EventArgs e)
        {

            
            gridEmployee.DataSource = null;
            gridEmployee.DataSource = _CoffeeShopData.employees;


        }
        public void btnLoadProductsClick(object sender, EventArgs e)
        {
            gridProducts.DataSource = null;
            gridProducts.DataSource = _CoffeeShopData.products;
        }


        public void button2_Click(object sender, EventArgs e) {
            this.Hide();
            EntryPoint entryPoint = new EntryPoint();
            entryPoint.Show();

        }
    } 
}