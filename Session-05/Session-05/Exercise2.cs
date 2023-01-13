using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Exercise2
    {
        /*2.Write a C# program that asks the user for an integer (n) and gives them
    the possibility to choose between computing the sum and computing
    the product of 1,…, n.*/

        Boolean checkOperation = false;
        Boolean checkNumber = false;
        public void UserNumberChoise()
        {
           
            while (!checkNumber) {
                Console.WriteLine("Enter an integer: ");
                string integer = Console.ReadLine();

                if (int.TryParse(integer, out int userNumber))
                {
                    Console.WriteLine("Input is an integer: " + userNumber);
                    checkNumber = true;
                    UserOperationChoice(userNumber);

                }
                else
                {
                    Console.WriteLine("Input is not an integer.");
                }

            }
        }

        public void UserOperationChoice(int n)
        {

            while (!checkOperation)
            {
                Console.WriteLine("What would you like to do? (Enter 'sum' or 'product')");
                string operation = Console.ReadLine();


                if (operation.ToLower() == "sum")
                {
                    int sum = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine("The sum of 1 to " + n + " is " + sum);
                    checkOperation = true;
                }
                else if (operation.ToLower() == "product")
                {
                    long product = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        product *= i;
                    }
                    Console.WriteLine("The product of 1 to " + n + " is " + product);
                    checkOperation = true;
                }
                else
                {
                    Console.WriteLine("Invalid type. Please type the exact choise!");
                }
            }
        }
            

            

            
        
    }
}
