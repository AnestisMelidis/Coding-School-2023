using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class MonthlyLedger
    {
        //Properties
        public DateTime Year { get; set; }
        public DateTime Month { get; set; }
        public double Income { get; set; }
        public double Expenses { get; set; }
        public double Total { get; set; }

        //Constructors
        public MonthlyLedger() 
        {

        }

        //Methods
        public void GetIncome(double income, DateTime date)
        {

        }
    }
}
