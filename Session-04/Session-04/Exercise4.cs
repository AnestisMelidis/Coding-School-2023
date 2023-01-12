using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class Exercise4
    {
        /*4. Write a C# program that assigns an age (number) (for example 20) and a gender(string) 
        * (for example female) and displays something like:
        "You are female and look younger than 20."*/
        int age = 25;
        string gender = "Male";
        public string ReturnAgeAndGender()
        {
            return "You are " + gender + " and look younger than " + age + ".";
        }


    }
}
