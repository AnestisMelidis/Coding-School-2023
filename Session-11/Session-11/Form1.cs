using DevExpress.DataAccess.Native.Data;
using DevExpress.XtraCharts;
using Library;
using System.Linq;

namespace Session_11
{
    public partial class Form1 : Form
    {


        private ProductCategory _productCategory;

        // private ProductCategory _productCategory;
        List<Product> products;
        List<Employee> employees;
        List<TransactionLine> transaction_Lines;
        Serializer serializer = new Serializer();


        public Form1()
        {

            Populate populate = new Populate();
            InitializeComponent();
            grvEmployee.DataSource = populate.PopulateEmployees();
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


    } 
}