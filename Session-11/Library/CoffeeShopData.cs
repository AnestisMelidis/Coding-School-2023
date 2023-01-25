using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CoffeeShopData
    {

        // properties
        public List<Product> Products { get; set; }

        public List<Employee> Employees { get; set; }


        public List<TransactionLine> TransactionLines { get; set; }




        // constructors
        public CoffeeShopData()
        {
            Products = new List<Product>();
            Employees = new List<Employee>();
            TransactionLines = new List<TransactionLine>();



        }


    }
}

