using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Exercise3
    {
        //3. Write a C# program to print the result of the specified operations:
        public int OperationOne()
        {
            return  -1 + 5 * 6;
        }

        public int OperationTwo()
        {
            return 38 + 5 % 7;
        }

        public double OperationThree()
        {

            return 14 + (-3 * 6) / 7;
        }

        public double OperationFour() 
        { 
            return 2 + (13 / 6.0) * 6 + Math.Sqrt(7);
        }

        public double OperationFive()
        {
            return (Math.Pow(6, 2) + Math.Pow(5, 7)) / (9 % 4);
        }
            

    }
}
