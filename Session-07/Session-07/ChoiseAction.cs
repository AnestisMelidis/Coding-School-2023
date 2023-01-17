using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ChoiseAction {

       public void Action() {

            Boolean checkOperation = false;
            
            while (!checkOperation) {
                Console.WriteLine("What would you like to do? (Enter 'Convert' or 'Uppercase' or 'Reverse')");
                string operation = Console.ReadLine();
                
           
                if (operation.ToLower() == "convert") {

                    Console.WriteLine("The choise is : " + operation);
                    checkOperation = true;
                    ConvertAndCheck convertAndCheck=new ConvertAndCheck();
                    convertAndCheck.CheckAndAct();

                }
                else if (operation.ToLower() == "uppercase") {
                    
                    Console.WriteLine("The choise is : "  + operation);
                    checkOperation = true;
                    UppercaseTheLongestString uppercaseTheLongestString = new UppercaseTheLongestString();
                    uppercaseTheLongestString.UpperCaseLongest();
                }
                else if(operation.ToLower() == "reverse") {

                    Console.WriteLine("The choise is : " + operation);
                    checkOperation = true;
                    ReversingAString reversingAString=new ReversingAString();
                    reversingAString.Reversing();


                }
                else {
                    Console.WriteLine("Invalid type. Please select on of the choises!");
                }
            }
        }
    }
}
