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
    public partial class Form1 : Form
    {
        private ProductCategory _productCategory;

        List<Product> products;
        List<Employee> employees;
        List<TransactionLine> transaction_Lines;
        Serializer serializer = new Serializer();
        Populate populate = new Populate();

        public Form1()
        {
            employees = new List<Employee>();
            InitializeComponent();
            employees = new List<Employee>();
            grvEmployee.DataSource = populate.PopulateEmployees();
            //grvEmployee.DataSource = employees;
            grvProducts.DataSource = populate.PopulateCoffee();

            //PopulateTransaction_Line();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFredo.Text = "0";
            txtFredo.Enabled = false;
            chkFredo.Checked = false;
            txtCap.Text = "0";
            txtCap.Enabled = false;
            chkCap.Checked = false;
        }
        private void txtFredo_Click(object sender, EventArgs e)
        {
            txtFredo.Text = "";
            txtFredo.Focus();
        }
        private void chkFredo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFredo.Checked == true)
            {
                txtFredo.Enabled = true;
            }
            if (chkFredo.Checked == false)
            {
                txtFredo.Enabled = false;
                txtFredo.Text = "0";
            }
        }
        private void txtCap_Click(object sender, EventArgs e)
        {
            txtCap.Text = "";
            txtCap.Focus();
        }
        private void chkCap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCap.Checked == true)
            {
                txtCap.Enabled = true;
            }
            if (chkCap.Checked == false)
            {
                txtCap.Enabled = false;
                txtCap.Text = "0";
            }
        }

        public void WriteJson(object obj, string file)
        {
            serializer.SerializeToFile(obj, file);
        }

        public void LoadJson(string file)
        {
            object employees = serializer.DeserializeFromFile<Employee>(file);
            grvEmployee.DataSource = employees;
        }


        public void btnSaveClick(object sender, EventArgs e)
        {
            double coffeePrice = 2.3;
            double fredo = Convert.ToDouble(txtFredo.Text);
            double cap = Convert.ToDouble(txtCap.Text);
            double cost = (fredo * coffeePrice + cap * coffeePrice);
            MessageBox.Show(cost.ToString());
            /*string name = txtName.Text;
            string surname = txtSurname.Text;
            string type = cmbType.SelectedItem.ToString();
            string salary = txtSalary.Text;
            Employee userInput = populate.FillEmployees(employees, name, surname, type, salary);
            employees.Add(userInput);
            grvEmployee.DataSource = employees;*/
        }
    } 
}