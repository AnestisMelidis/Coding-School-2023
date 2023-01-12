using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Exercise7
    {
        // 7. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.

        double celsius = 10.0;
        public  double CalculateCelsiusToKelvin()
        {
            return celsius + 273.15;
        }

        public  double CalculateCelsiusToFahrenheit()
        {
            return (celsius * 1.8) + 32;
        }


    }
}
