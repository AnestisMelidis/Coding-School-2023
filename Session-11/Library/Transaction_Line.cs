using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Transaction_Line
    {
        public Guid ID { get; set; }
        public Guid ProductID { get; set; }
        public Datetime Date { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double TotalPrice { get; set; }
        public Transaction_Line(){
            }
        public void DiscountCheck() { 
   }
    }
}
