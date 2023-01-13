using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Exercise1
    {
        //1.Write a C# program that reverses a given string (your name).
        public string ReversingString()
        {
            string name = "Anestis";
            char[] nameArray = name.ToCharArray();
            for (int i = 0; i < nameArray.Length / 2; i++)
            {
                char position = nameArray[i];
                nameArray[i] = nameArray[nameArray.Length - 1 - i];
                nameArray[nameArray.Length - 1 - i] = position;
            }
            
            return new string(nameArray);
        }
    }
}
