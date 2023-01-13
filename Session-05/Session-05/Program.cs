
// See https://aka.ms/new-console-template for more information
using Session_05;
using System.ComponentModel;

//1.Write a C# program that reverses a given string (your name).

Console.WriteLine("Reversing the String for the Name Anestis!");
Exercise1 exercise1= new Exercise1();
Console.WriteLine(exercise1.ReversingString());



/*2.Write a C# program that asks the user for an integer (n) and gives them
the possibility to choose between computing the sum and computing
the product of 1,…, n.*/
Console.WriteLine("Asking For An Integer And Then Pick The Sum or Product 1 to n!");
Exercise2 exercise2 = new Exercise2();
exercise2.UserNumberChoise();


/*3.Write a C# program that asks the user for an integer (n) and finds all
the prime numbers from 1 to n.*/
Console.WriteLine("Asking For An Integer And Then Find all Prime Numbers 1 to n!");
Exercise3 exercise3 = new Exercise3();
exercise3.UserNumberChoise();
Console.WriteLine(" ");


/*4.Write a C# program to multiply all values from Array1 with all values
from Array2 and display the results in a new Array.
Array1: [2, 4, 9, 12]
Array2: [1, 3, 7, 10]*/
Console.WriteLine("Multiply all values from Array1 with all values from Array2 and display the results in a new Array!");
Exercise4 exercise4 = new Exercise4();
exercise4.Array();
Console.WriteLine(" ");



/*5.Write a C# program to sort the given array of integers from the lowest
to the highest number.
• Array: [ 0, -2, 1, 20, -31, 50 , -4, 17, 89, 100 ]*/
Console.WriteLine("Sort the given array of integers from the lowest to the highest number.");
Exercise5 exercise5 = new Exercise5();
exercise5.SortArray();


Console.ReadLine();