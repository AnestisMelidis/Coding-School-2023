using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Exercise4
    {
        /*4.Write a C# program to multiply all values from Array1 with all values
        from Array2 and display the results in a new Array.
        Array1: [2, 4, 9, 12]
        Array2: [1, 3, 7, 10]*/

        public void Array()
        {
            int[] array1 = new int[] { 2, 4, 9, 12 };
            int[] array2 = new int[] { 1, 3, 7, 10 };
            int[] array3 = new int[array1.Length * array2.Length];
            int index = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    array3[index++] = array1[i] * array2[j];
                }
            }

            Console.WriteLine("The Array 1:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }

            Console.WriteLine("\r\nThe Array 2:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
           
            Console.WriteLine("\r\nThe New Array 3:");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i] + " ");
            }
        }


    }
}
