using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class StringConvert : StringManipulator {


        public override string Manipulate() {
            Boolean checkOperation = false;

            while (!checkOperation) {
                Console.WriteLine("Enter a decimal number:");
                string input = Console.ReadLine();
                decimal number;
                if (decimal.TryParse(input, out number)) {
                    string binary = Convert.ToString((int)number, 2);
                    Console.WriteLine("Binary representation: " + binary);
                    checkOperation = true;
                    return binary;
                }
                else {
                    Console.WriteLine("Invalid input.Please select a correct input.");
                }
            }

            // “Convert” you must check if the Input is a decimal number and convert it to binary.
            return null;
            
        }
    }
}
