using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsLib {
    public class RaisetoPower : IMathematicalCal {
        public decimal Calculation(decimal? x, decimal? y) {
            double result = 0;

            if (x != null && y != null ) {
                result = Math.Pow((double)x , (double)y); 
            }

            return (decimal)result;
        }
    }
}
