using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class TransactionLine
    {
        public Guid ID { get; set; }
        public Guid ProductID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalCost { get; set; }        
        public double TotalPrice { get; set; }

        public TransactionLine()
        {
            ID = Guid.NewGuid();
            Date= DateTime.Now;
        }
    }
}


