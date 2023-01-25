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
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double Discount = 0.85;
        public double TotalPrice { get; set; }
        //public List<TransactionLine> transactionLines { get; set; }

        public TransactionLine()
        {
            ID = Guid.NewGuid();
            Date= DateTime.Now;
        }
        public bool DiscountCheck(double price, int quantity)
        {
            if (quantity * price > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double DoTotalCost(TransactionLine test)
        {

            if (test.DiscountCheck(test.Price, test.Quantity))
            {
                //MessageBox.Show("Mpika sthn If");
                test.TotalPrice = (test.Price * test.Quantity) * test.Discount;
                // MessageBox.Show("" + test.TotalPrice);

            }
            else
            {
                //MessageBox.Show("DEn Mpika sthn If");
                test.TotalPrice = (test.Price * test.Quantity);
                // MessageBox.Show("" + test.TotalPrice);
            }
            return test.TotalPrice;

        }
        

        public virtual void Write (TransactionLine test)
        {



        }

        string message = "Only Cash";
        public void PaymentCheck(double price, int quantity)
        {
            if (quantity * price > 50)
            {
               
                TextWriter message;
            }
            else
            {
                TextWriter allmethodspaymends;
            }
        }

        




    }
}

