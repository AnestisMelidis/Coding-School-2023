using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Exercise2
    {

        //2. Write a C# program to print the sum of two numbers and the division of those two numbers
        int number1 = 20;
        int number2 = 10;
        public int SumOfTwoNumbers()
        {
            int sum = number1 + number2;
            return sum;
        }

        public int DivisionOfTwoNumbers()
        {
            int division = number1 / number2;
            return division;
        }

    }
}
