using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ConvertAndCheck : ActionResponse {
        
        public override void CheckAndAct() {
            Boolean checkOperation = false;

            while (!checkOperation) {
                Console.WriteLine("Enter a decimal number:");
                string input = Console.ReadLine();
                decimal number;
                if (decimal.TryParse(input, out number)) {
                    string binary = Convert.ToString((int)number, 2);
                    Console.WriteLine("Binary representation: " + binary);
                    checkOperation=true;
                }
                else {
                    Console.WriteLine("Invalid input.Please select a correct input.");
                }
            }
        }
    }
}
