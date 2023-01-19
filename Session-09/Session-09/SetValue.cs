using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_09 {
    public class SetValue {        

        public int SetInputValue(decimal?[] values) {
           // Form1 form1 = new Form1();
            if (values[0] == null) {
               // form1._value1 = x;
                
                return 0;
            }
            else {
                //form1._value2 = x;
                return 1;
            }
        }
    }
}
