using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Exercise3
    {
        /*3.Write a C# program that asks the user for an integer (n) and finds all
        the prime numbers from 1 to n.*/
        public void UserNumberChoise()
        {
            Boolean checkNumber = false;

            while (!checkNumber)
            {
                Console.WriteLine("Enter an integer: ");
                string integer = Console.ReadLine();

                if (int.TryParse(integer, out int userNumber))
                {
                    Console.WriteLine("Input is an integer: " + userNumber);
                    checkNumber = true;
                    bool[] primes = new bool[userNumber + 1];

                    for (int i = 2; i <= userNumber; i++)
                    {
                        primes[i] = true;
                    }

                    // Mark non-primes <= n using Sieve of Eratosthenes
                    for (int i = 2; i * i <= userNumber; i++)
                    {
                        // If i is prime, then mark multiples of i as nonprime
                        if (primes[i])
                        {
                            for (int j = i * i; j <= userNumber; j += i)
                            {
                                primes[j] = false;
                            }
                        }
                    }

                    // Print all prime numbers
                    for (int i = 2; i <= userNumber; i++)
                    {
                        if (primes[i])
                        {
                            Console.Write(i + " ");
                            
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Input is not an integer. Please Enter A Number!");
                }

            }

         

            
        }

    }
}
