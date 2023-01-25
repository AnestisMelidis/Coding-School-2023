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
        public int Year { get; set; }
        public int Month { get; set; }
        public double Income { get; set; }
        public double Expenses { get; set; }
        public double Total { get; set; }

        //Constructors
        public MonthlyLedger() 
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
        }
    }
}
