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
        private ProductCategory _productCategory;


        List<Product> products;
        List<Employee> employees;
        List<TransactionLine> transaction_Lines;
        Serializer serializer = new Serializer();
        Populate populate = new Populate();
        int cnt = 0;

        public Form1() {
            
            employees = new List<Employee>();
            products = new List<Product>();
            InitializeComponent();
            //grvEmployee.DataSource = populate.PopulateEmployees();
            //grvEmployee.DataSource = employees;
            //grvProducts.DataSource = populate.PopulateCoffee();
            //PopulateTransaction_Line();

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
            //grvEmployee.DataSource = employees;
        }


        public void btnSaveEmployeesClick(object sender, EventArgs e) 
        {

            //string name = txtName.Text;
            //string surname = txtSurname.Text;
            //string type = cmbType.SelectedItem.ToString();
            //string salary = txtSalary.Text;
            //Employee userInput = populate.FillEmployees(employees, name, surname, type, salary);
            //employees.Add(userInput);

            //grvEmployee.DataSource = employees;


            // Create a new Employee object with the user's input
            Employee newEmployee = new Employee() {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                TypeOfEmployee = (EmployeeType)Enum.Parse(typeof(EmployeeType), cmbType.SelectedItem.ToString()),
                SalaryPerMonth = Convert.ToDouble(txtSalary.Text)
            };

            // Add the new employee to the list
            employees.Add(newEmployee);
            
            // Refresh the data grid to display the new employee
            //grvEmployee.Refresh();
            //gridEmployee.DataSource = employees;


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
                products.Add(newProduct);
        }
        public void btnLoadEmployeesClick(object sender, EventArgs e)
        {

            // grvEmployee.DataSource = employees;
            gridEmployee.DataSource = null;
            gridEmployee.DataSource = employees;


        }
        public void btnLoadProductsClick(object sender, EventArgs e)
        {
            gridProducts.DataSource = null;
            gridProducts.DataSource = products;
        }

       
    } 
}