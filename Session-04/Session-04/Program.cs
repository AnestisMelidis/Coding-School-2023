// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Session_04;
using System;
using System.ComponentModel;

//1.Write a C# program to print Hello and your name in the same line.

Exercise1 exercise1 = new Exercise1();
Console.WriteLine(exercise1.HelloName());




//2. Write a C# program to print the sum of two numbers and the division of those two numbers
Exercise2 exercise2 = new Exercise2();
Console.WriteLine("The Sum is : " + exercise2.SumOfTwoNumbers());
Console.WriteLine("The Division is : " + exercise2.DivisionOfTwoNumbers());




//3.Write a C# program to print the result of the specified operations:
Exercise3 exercise3 = new Exercise3();
Console.WriteLine("The Operation One Result  is : " + exercise3.OperationOne());
Console.WriteLine("The Operation Two Result  is : " + exercise3.OperationTwo());
Console.WriteLine("The Operation Three Result  is : " + exercise3.OperationThree());
Console.WriteLine("The Operation Four Result  is : " + exercise3.OperationFour());
Console.WriteLine("The Operation Five Result  is : " + exercise3.OperationFive());




/*4. Write a C# program that assigns an age (number) (for example 20) and a gender(string) 
        * (for example female) and displays something like:
        "You are female and look younger than 20."*/
Exercise4 exercise4 = new Exercise4();
Console.WriteLine(exercise4.ReturnAgeAndGender());




/* 5. Write a C# program that takes an integer representing seconds
       (for example 45678) and converts it to :
      Minutes , Hours , Days , Years */
Exercise5 exercise5 = new Exercise5();
Console.WriteLine("The Minutes Result  is : " + exercise5.CalculateMinutes());
Console.WriteLine("The Hours Result  is : " + exercise5.CalculateHours());
Console.WriteLine("The Days Result  is : " + exercise5.CalculateDays());
Console.WriteLine("The Years Result  is : " + exercise5.CalculateYears());




//6. Rewrite Program #5 using .Net Libraries.
int seconds = 45678;
TimeSpan time = TimeSpan.FromSeconds(seconds);

Console.WriteLine("The Minutes Result using .Net Libraries : " + (time.Minutes + (time.Hours * 60)));
Console.WriteLine("The Hours Result using .Net Libraries : " + time.Hours);
Console.WriteLine("The Days Result using .Net Libraries : " + (int)time.TotalDays % 365);
Console.WriteLine("The Years Result using .Net Libraries : " + (int)time.TotalDays / 365);


    


// 7. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
Exercise7 exercise7 = new Exercise7();
Console.WriteLine("The Celsius (10.0) to Kelvin Result  is : " + exercise7.CalculateCelsiusToKelvin());
Console.WriteLine("The Celsius (10.0) to Fahrenheit Result  is : " + exercise7.CalculateCelsiusToFahrenheit());
Console.ReadLine();