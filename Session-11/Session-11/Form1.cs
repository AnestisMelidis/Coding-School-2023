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
using static DevExpress.Utils.Svg.CommonSvgImages;
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
       

        public Form1(CoffeeShopData test) {


            _CoffeeShopData = test;
            InitializeComponent();

            
        }
        
        private void Form1_Load(object sender, EventArgs e) {
            gridProducts.DataSource = _CoffeeShopData.products;
            gridEmployee.DataSource = _CoffeeShopData.employees;
            gridLedger.DataSource = _CoffeeShopData.monthlyLedgers;
        }



        public void WriteJson(object obj, string file) {
            serializer.SerializeToFile(obj, file);
        }



        public void btnSaveEmployeesClick(object sender, EventArgs e) 
        {
            

            Employee newEmployee = new Employee() {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                TypeOfEmployee = (EmployeeType)Enum.Parse(typeof(EmployeeType), cmbType.SelectedItem.ToString()),
                SalaryPerMonth = Convert.ToDecimal(txtSalary.Text)
            };

            txtName.Text = "";
            txtSurname.Text = "";
            cmbType.Text = "";
            txtSalary.Text = "";
            _CoffeeShopData.employees.Add(newEmployee);
            gridEmployee.DataSource = null;
            gridEmployee.DataSource = _CoffeeShopData.employees;

        }
        public void btnSaveProductsClick(object sender, EventArgs e)
        {
            Product newProduct = new Product()
            {
                Description = txtDesc.Text,
                TypeOfProduct = (ProductType)Enum.Parse(typeof(ProductType), cmbProType.SelectedItem.ToString()),
                Price = Convert.ToDecimal(txtPrice.Text),
                Cost = Convert.ToDecimal(txtCost.Text)
            };
            txtDesc.Text = "";
            cmbProType.Text = "";
            txtPrice.Text = "";
            txtCost.Text = "";
            _CoffeeShopData.products.Add(newProduct);
            gridProducts.DataSource = null;
            gridProducts.DataSource = _CoffeeShopData.products;
        }

        public void btnSaveJson(object sender, EventArgs e)
        {
            WriteJson(_CoffeeShopData, "test1.json") ;
        }


        public void button2_Click(object sender, EventArgs e) {
            this.Hide();
            EntryPoint entryPoint = new EntryPoint();
            entryPoint.Show();
        }
        public void GetCode()
        {
            
        }



    } 
}