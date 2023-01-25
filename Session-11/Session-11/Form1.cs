using DevExpress.DataAccess.Native.Data;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Cms;
using DevExpress.Utils.DPI;
using DevExpress.XtraCharts;
using DevExpress.XtraSpreadsheet.Export;
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
            
            InitializeComponent();
            employees = new List<Employee>();
            //grvEmployee.DataSource = populate.PopulateEmployees();
            //grvEmployee.DataSource = employees;
            grvProducts.DataSource = populate.PopulateCoffee();

            //PopulateTransaction_Line();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

            string name = txtName.Text;
            string surname = txtSurname.Text;
            string type = cmbType.SelectedItem.ToString();
            string salary = txtSalary.Text;
 
            Employee userInput = populate.FillEmployees(employees, name, surname, type, salary);
            employees.Add(userInput);
            grvEmployee.DataSource = employees;
        }
    } 
}