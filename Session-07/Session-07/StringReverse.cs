﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class StringReverse : StringManipulator {

        public override string Manipulate() {

            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed string: " + reversedString);
            return reversedString;
        }

    }
}
