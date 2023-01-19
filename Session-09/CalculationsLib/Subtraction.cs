using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsLib {
    public class Subtraction : IMathematicalCal {
        public decimal Calculation(decimal? x, decimal? y) {
            decimal result = 0;

            if (x != null && y != null) {
                result = x.Value - y.Value;
            }

            return result;
        }
    }
    
}
