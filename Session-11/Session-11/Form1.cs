using Library;

namespace Session_11
{
    public partial class Form1 : Form
    {


        private ProductCategory _productCategory;
        List<Product> products;
        List<Employee> employees;

        public Form1()
        {


            InitializeComponent();
            PopulateCoffee();
            PopulateEmployees();

            //Test push
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
  
        public void PopulateCoffee()
        {

            //_productCategory = new ProductCategory();

            products = new List<Product>();

            Product product1 = new Product()
            {
                Code = 1,
                Description = "Fredo",
                TypeOfProduct = Product.ProductType.Coffee,
                Price = 10,
                Cost = 5

            };

            products.Add(product1);

            Product product2 = new Product()
            {
                Code = 2,
                Description = "Frape",
                TypeOfProduct = Product.ProductType.Coffee,
                Price = 8,
                Cost = 4,

            };
            products.Add(product2);
            MessageBox.Show(product1.Description + " " + product2.Description);
            MessageBox.Show(product1.Description + " " + product2.Description);

        }
        

        public void PopulateEmployees()
        {


            employees = new List<Employee>();

            Employee manager = new Employee()
            {
                Name = "Vasilis",
                Surname = "Papadopoulos",
                TypeOfEmployee = EmployeeType.Manager,
                SalaryPerMonth = 1600
            };
            employees.Add(manager);
            MessageBox.Show(manager.TypeOfEmployee + " " + manager.Name + " ");

            Employee cashier1 = new Employee()
            {
                Name = "Maria",
                Surname = "Markora",
                TypeOfEmployee = EmployeeType.Cashier,
                SalaryPerMonth = 1200
            };
            employees.Add(cashier1);
            MessageBox.Show(cashier1.TypeOfEmployee + " " + cashier1.Name + " ");

            Employee barista1 = new Employee()
            {
                Name = "Jenny",
                Surname = "Karakosta",
                TypeOfEmployee = EmployeeType.Barista,
                SalaryPerMonth = 1200
            };
            employees.Add(barista1);
            MessageBox.Show(barista1.TypeOfEmployee + " " + barista1.Name + " " );

            Employee waiter1 = new Employee()
            {
                Name = "Mike",
                Surname = "Karagouni",
                TypeOfEmployee = EmployeeType.Waiter,
                SalaryPerMonth = 1200
            };
            employees.Add(waiter1);
            MessageBox.Show(waiter1.TypeOfEmployee + " " + waiter1.Name + " ");


        }


    }
}