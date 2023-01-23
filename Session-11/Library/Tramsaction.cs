using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Transaction
    {
        public enum MethodPaymet
        {
            Cash,
            Credit_Card
        };
        public Guid ID { get; set; }
        public Datetime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public double TotalPrice { get; set; }

        public Transaction{
            }
    }   
}
