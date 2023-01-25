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

namespace Session_11
{
    public partial class Form1 : Form {
        private ProductCategory _productCategory;

        List<Product> products;
        List<Employee> employees;
        List<TransactionLine> transaction_Lines;
        Serializer serializer = new Serializer();
        Populate populate = new Populate();

        public Form1() {
            employees = new List<Employee>();
            InitializeComponent();
            //grvEmployee.DataSource = populate.PopulateEmployees();
            //grvEmployee.DataSource = employees;
            grvProducts.DataSource = populate.PopulateCoffee();
            //PopulateTransaction_Line();

        }

        private void Form1_Load(object sender, EventArgs e) {
            numFredo.Enabled = false;
            numCap.Enabled = false;
            chkFredo.Checked = false;
            chkCap.Checked = false;
        }

        private void chkFredo_CheckedChanged(object sender, EventArgs e) {
            if (chkFredo.Checked == true) {
                numFredo.Enabled = true;
            }
            if (chkFredo.Checked == false) {
                numFredo.Enabled = false;
                numFredo.Text = "0";
            }
        }
        private void chkCap_CheckedChanged(object sender, EventArgs e) {
            if (chkCap.Checked == true) {
                numCap.Enabled = true;
            }
            if (chkCap.Checked == false) {
                numCap.Enabled = false;
                numCap.Text = "0";
            }
        }

        public void WriteJson(object obj, string file) {
            serializer.SerializeToFile(obj, file);
        }

        public void LoadJson(string file) {
            object employees = serializer.DeserializeFromFile<Employee>(file);
            grvEmployee.DataSource = employees;
        }


        public void btnSaveClick(object sender, EventArgs e) {

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
    



    public void btnLoadClick(object sender, EventArgs e)
        {

            // grvEmployee.DataSource = employees;
            gridEmployee.DataSource = null;
            gridEmployee.DataSource = employees;


        }
        public void btnPrice(object sender, EventArgs e)
        {
            double coffeePrice = 2.3;
            double fredo = Convert.ToDouble(numFredo.Text);
            double cap = Convert.ToDouble(numCap.Text);
            double cost = (fredo * coffeePrice + cap * coffeePrice);
            MessageBox.Show(cost.ToString());
        }
       
    } 
}