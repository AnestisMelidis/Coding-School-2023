using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Exercise5
    {
        /* 5. Write a C# program that takes an integer representing seconds
         (for example 45678) and converts it to :
        Minutes , Hours , Days , Years */

        int seconds = 45678;

        public int CalculateMinutes()
        {
            return seconds / 60;

        }

        public int CalculateHours()
        {
            return seconds / 3600;
        }

        public int CalculateDays()
        {
            return seconds / 86400;
        }
        
        public int CalculateYears()
        {
            return seconds / 31536000; 
        }

    }
}
