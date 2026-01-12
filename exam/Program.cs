using static System.Collections.Specialized.BitVector32;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO.Pipelines;
using System.Numerics;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Text;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.X86;
using System.ComponentModel.Design;

namespace exam
{
    internal class Program
    {
        // functions

        #region Q2

        //static bool checkDevidebyzero( int a , int b)
        //{

        //    if(a ==0 || b == 0)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        //static int CalculateNumbers(int a, int b, char oper)
        //{
        //    switch (oper)
        //    {
        //        case '+':
        //            return a + b;

        //        case '-':
        //            return a - b;

        //        case '*':
        //            return a * b;

        //        case '/':
        //            if (checkDevidebyzero(a, b))
        //            {
        //                return a / b;
        //            }
        //            else
        //            {

        //                return 0;
        //            }

        //        default:
        //            Console.WriteLine("Invalid operator.");
        //            return 0;
        //    }
        //}





        #endregion



        #region Q3
        //static void multibly(int num)
        //{
        //    for (int i = 1; i <= num; i++)
        //    {
        //        Console.WriteLine( $"table {i}");
        //        for(int j = 1; j <= 10; j++)
        //        {
        //            Console.WriteLine($"{i} *  {j} = {i*j}");
        //        }


        //        Console.WriteLine();


        //}   }    
        #endregion



        #region Q6

        //static bool IsPlaindorm (string s1)
        //{
        //    if (s1 is not null)
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        for (int i = s1.Length-1; i >= 0; i--)
        //            sb.Append(s1[i]);
        //        {


        //            if (sb.ToString() == s1 )
        //            {
        //                return true;
        //            }

        //            return false;

        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}



        #endregion



        #region Q7
        //static int ? Getdevision(int? a, int? b) {

        //    if (a == null || b == null || b==0)
        //        return null;
        //    else
        //        return a / b;


        //}
        #endregion


        #region Q8
        // static int SumEven(int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] % 2 == 0) {

        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}
        #endregion



        #region Q9

        #endregion



        #region Q10

        static int ? average( int? [] arr)
        {
            int sum = 0;
            int counter = 0;
            if (arr == null)
            {

                return null;

            }

            else
            {
                for (int  i = 0; i < arr.Length; i++)
                {

                    if (arr[i].HasValue)
                    {
                        sum += arr[i]!.Value  ;
                        counter++;
                    }


                }

            }

            if (counter == 0)
            {
                return 0;
            }
            

            return sum / counter;




        }   


        #endregion

        static void Main(string[] args)
        {
            #region Q1
            //question 1:
            //Write a program that asks the user to enter their age and nationality.If the age is 18 or above
            //and nationality is "Egyptian", print "Eligible to vote", otherwise print "Not eligible".

            //Console.Write("enter  your age ");
            // bool isage =int.TryParse(Console.ReadLine(), out int age );

            //Console.Write("enter  your  nationality ");
            //string ? nationality=Console.ReadLine() ?? "Undefined";

            //if(isage && age > 0)
            //{
            //    if(age >=18 && nationality =="Egyption")
            //    {
            //        Console.WriteLine("Eligible to vote");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not eligible");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(" you enterd invalid age try again ");

            //}










            #endregion



            #region Q2

            //    Create a calculator function that takes two numbers and an operator (+, -, *, /) as input.Use a
            //switch statement to perform the operation and return the result.Handle division by zero.

            //Console.WriteLine("enter  the operator  ");
            //char.TryParse(Console.ReadLine(), out char oper);

            //Console.Write("enter number1 ");
            //int.TryParse(Console.ReadLine(), out int num1);

            //Console.Write("enter number1 ");
            //int.TryParse(Console.ReadLine(), out int num2);



            //Console.WriteLine(CalculateNumbers(num1,num2,oper));



            #endregion






            #region Q3

            //Write a method that takes an integer n and prints the multiplication table from 1 to n. Each row
            //should show the result of multiplying the current number by 1 through 10


            //Console.WriteLine("enter the the  number  for  the multiplication table");
            //int.TryParse(Console.ReadLine(), out int number);

            //Console.Clear();
            //multibly(number);


            #endregion




            #region Q4

            //Write a program that accepts an array of integers and counts how many of them are prime
            //    numbers.

            //Console.Write("enter the array Size ");
            //int.TryParse(Console.ReadLine(), out int size);

            //int[] arr = new int[size];
            //for (int i = 0; i < arr.Length; i++) {

            //    Console.WriteLine($"enter the element {i+1} ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);



            //}

            //int total = 0;

            //for (int i = 0; i < arr.Length; i++) { 

            //    int counter = 0;

            //    if (arr[i] < 2)
            //        continue;

            //    for (int j = 1; j <= arr[i]; j++)

            //    {
            //        if (arr[i] % j == 0)
            //        {
            //            counter++;
            //        }

            //    }


            //    if (counter == 2) {

            //        total++;

            //    }



            //}
            //Console.WriteLine($"Total prime numbers = {total}");

            #endregion




            #region Q5

            //Ask the user to input 10 integers and store them in an array. Find and print the maximum value
            //and its index.

            //int[] arr01 =new int[10];
            //Console.WriteLine("enter 10 numbers "); 
            //for (int i = 0; i < arr01.Length; i++)
            //{

            //    Console.WriteLine($"enter  number {i+1}");
            //    int.TryParse(Console.ReadLine(), out arr01[i]);
            //}

            //int max = arr01[0];
            //int index = -1;

            //for (int i = 0; i < arr01.Length; i++) {

            //    if (arr01[i]> max)
            //    {
            //        max= arr01[i];
            //        index=i;
            //    }

            //}
            //Console.WriteLine($"max value is {max} at index {index +1 }");



            #endregion




            #region Q6


            ////Create a function that checks whether a given word(as a string) is a palindrome (same forward
            //// and backward). Ignore casing

            //Console.WriteLine("enter string ");
            //string S1=Console.ReadLine() !;

            //if (IsPlaindorm(S1))
            //{
            //    Console.WriteLine("It is a palindrome!");
            //}
            //else
            //{
            //    Console.WriteLine("It is not a palindrome!");
            //}

            #endregion



            #region Q7

            //Write a function that takes two int? values(nullable integers). If both are not null, return their
            //division result. If either is null, return null.Also, avoid division by zero.

            //Console.Write("enter  first  number ");
            //int.TryParse (Console.ReadLine(), out int num1 );

            //Console.WriteLine("enter  secon  number ");
            //int.TryParse(Console.ReadLine(), out int  num2);


            //int ? result = Getdevision(num1 , num2);

            //if (result.HasValue)
            //{
            //    Console.WriteLine( $"result = {result}");
            //}
            //else
            //{
            //    Console.WriteLine("invalied");
            //}

            #endregion









            #region Q8

            //Create a function that accepts an array of integers and returns the sum of all even numbers

            //int[] arr03 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };


            //Console.WriteLine( $"  sum of even number is {SumEven(arr03)}");





            #endregion




            #region Q9

            //Write a program that reads student scores(as integers from 0–100) for 5 students.For each
            //student, use a switch with ranges(use when) to assign grades

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"Enter score {i}: ");
            //    int.TryParse(Console.ReadLine(), out int score);

            //    if (score < 0 || score > 100)
            //    {
            //        Console.WriteLine("Invalid score.");  
            //    }

            //    switch (score)
            //    {
            //        case int n when (n >= 90 && n <= 100):
            //            Console.WriteLine("Grade: A");
            //            break;

            //        case int n when (n >= 80 && n < 90):
            //            Console.WriteLine("Grade: B");
            //            break;

            //        case int n when (n >= 70 && n < 80):
            //            Console.WriteLine("Grade: C");
            //            break;

            //        case int n when (n >= 60 && n < 70):
            //            Console.WriteLine("Grade: D");
            //            break;

            //        case int n when (n >= 0 && n < 60):
            //            Console.WriteLine("Grade: F");
            //            break;
            //    }
            //}










            #endregion





            #region q10 
            //Create a function that accepts an array of int? (nullable scores). Return the average of all nonnull scores.If all scores are null, return null.
            int?[] arr04 = { 1, 2, 3, null, 5, 6, 7, 9, null };
            int?[] arr05 = { null, null };
            int? result = average(arr05);

            if (result.HasValue)
                Console.WriteLine($"Average score = {result.Value}");
            else
                Console.WriteLine("No valid scores to calculate average.");
            #endregion












        }
    }
}
