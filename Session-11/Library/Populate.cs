using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Populate
    {
        private ProductCategory _productCategory;
        List<Product> products;
        List<Employee> employees;
        List<TransactionLine> transactionLines;

        public object PopulateCoffee()
        {

            _productCategory = new ProductCategory();

            products = new List<Product>();

            Product product1 = new Product()
            {
                Code = 1,
                Description = "Fredo",
                TypeOfProduct = Product.ProductType.Coffee,
                Price = 10,
                Cost = 5

            };
            Product product2 = new Product()
            {

                Code = 2,
                Description = "Burger",
                TypeOfProduct = Product.ProductType.Food,
                Price = 8,
                Cost = 4,

            };
            Product product3 = new Product()
            {
                Code = 3,
                Description = "Frape",
                TypeOfProduct = Product.ProductType.Coffee,
                Price = 30,
                Cost = 10

            };
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            return products;
            
/*            MessageBox.Show("Coffee Products: " + string.Join(", ", products.Where(x => x.TypeOfProduct == Product.ProductType.Coffee)
            .Select(x => (x.Description, x.Code, x.Price, x.Cost))));*/
        }
        public object PopulateEmployees()
        {
            employees = new List<Employee>();

            Employee manager = new Employee()
            {
                Name = "Vasilis",
                Surname = "Papadopoulos",
                TypeOfEmployee = EmployeeType.Manager,
                SalaryPerMonth = 1600
            };
            Employee cashier1 = new Employee()
            {
                Name = "Maria",
                Surname = "Markora",
                TypeOfEmployee = EmployeeType.Cashier,
                SalaryPerMonth = 1200
            };
            Employee barista1 = new Employee()
            {
                Name = "Jenny",
                Surname = "Karakosta",
                TypeOfEmployee = EmployeeType.Barista,
                SalaryPerMonth = 1200
            };
            Employee waiter1 = new Employee()
            {
                Name = "Mike",
                Surname = "Karagouni",
                TypeOfEmployee = EmployeeType.Waiter,
                SalaryPerMonth = 1200
            };
            employees.Add(manager);
            employees.Add(cashier1);
            employees.Add(barista1);
            employees.Add(waiter1);

            return employees;
        }
        public object PopulateLines()
        {

            transactionLines = new List<TransactionLine>();

            TransactionLine transactionLine1 = new TransactionLine()
            {
                Quantity = 2,
                Price = 4

            };
            TransactionLine transactionLine2 = new TransactionLine()
            {
                Quantity = 2,
                Price = 50

            };

            transactionLine1.TotalPrice = transactionLine1.DoTotalCost(transactionLine1);
            transactionLine2.TotalPrice = transactionLine2.DoTotalCost(transactionLine2);
            transactionLines.Add(transactionLine1);
            transactionLines.Add(transactionLine2);
            return transactionLines;
            //MessageBox.Show(product1.Description + " " + product2.Description);
        }
        public Employee FillEmployees(List<Employee>? employees, string name, string surname, string type, string salary)
        {
            //employees = new List<Employee>();
            Employee employeeInput = new Employee()
            {
                Name = name,
                Surname = surname,
                TypeOfEmployee = EmployeeType.Waiter,
                //TypeOfEmployee = EmployeeType.(enum.Parse(Type EmployeeType, string type)),
                SalaryPerMonth = Convert.ToDouble(salary)
            };
            return employeeInput;
        }

    }
    
}
