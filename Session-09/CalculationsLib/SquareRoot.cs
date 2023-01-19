using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsLib {
    public class SquareRoot {
        
        public decimal Calculation(decimal? x) {
            double result = 0;

            if (x != null ) {
                result = Math.Sqrt((double)x);
            }

            return (decimal)result;
        }
    }
}
