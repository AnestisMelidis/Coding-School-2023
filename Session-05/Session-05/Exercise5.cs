using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Exercise5
    {
        /*5.Write a C# program to sort the given array of integers from the lowest
        to the highest number.
        • Array: [ 0, -2, 1, 20, -31, 50 , -4, 17, 89, 100 ]*/
        
       public void SortArray()
        {
            int[] array1 = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            Console.WriteLine("The Array :");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine(" ");

           
            Console.WriteLine("The Sorted Array : ");

            var sortedNumbers =from n in array1 orderby n select n;

            foreach (var n in sortedNumbers)
            {
                Console.Write(n + " ");
            }

        }
    }
}
