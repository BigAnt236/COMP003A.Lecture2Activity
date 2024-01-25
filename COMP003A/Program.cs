﻿/*
 * Author: Anthony Alvarez
 * Course: COMP-003A
 * Purpose: Lecture activity for variables, type system, Math, and Console properties
 * Reference: The C# Player's Guide (4e) by RB Whitaker
 */

namespace COMP003A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* working with variables */
            // the following code shows all three primary variable-related activities
            string username; // declaring a variable (1 of 3)
            Console.WriteLine("What is your name?"); // request for user input
            username = Console.ReadLine(); // retrieving its current value (2 of 3)
            Console.WriteLine("Hi " + username); // retrieving its current value (3 of 3)


            // another example of the three primary variable related activities (declaring, assigning, and retrieving)
            string favoriteColor;
            Console.WriteLine("What is your favorite color?");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + favoriteColor);

            /* working with variable integers */
            int score; // declare a new variable with a data type int
            // score - "Generic User"; // will fail to compile because the "O" is still
            // assigned as a string - enclosed in the double quotes
            score = 0; // works
            score = 4; // you can also reassign values to the variable as long as they are within scope and not constant
            score = 11;
            score = -1564;

            /* reading from a variable does not change it */
            int a;
            int b;

            a = 5;
            b = 2;
            Console.WriteLine("The current value of a: " + a);
            Console.WriteLine("The current value of b: " + b);

            b = a;
            a = -3;
            Console.WriteLine("The new value of a: " + a);
            Console.WriteLine("The new value of b: " + b);

            /* variables are case-sensitive */
            // the variables below are different despite having similar names
            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;

            Console.WriteLine("********************************");
            /* 
             * types of variables and values matter in C#. they are not interchangeable.
             * there are eight integer types for storing integers of differing sizes and 
             * ranges: int, short, long, byte, sbyte, ushort, and ulong.
             * the char type stores single characters.
             * the string type stores longer text.
             * there are three types for storing real numbers: float, double, and decimal.
             * the bool type stores truth values (true and false) used in logic.
             * these types are the building blocks of a much larger type system.
             * using var for a variable's type tells the compiler to infer its type from the surrounding code, so you do not have to type it out. (But it still has a specific type.)
             * the System.Convert class is a useful class to convert from one type to another.
             */

            /* declaring and using variables with integer types */
            byte aSingleByte = 34;
            Console.WriteLine("aSingleByte: " + aSingleByte);
            aSingleByte = 17;
            Console.WriteLine("aSingleByte: " + aSingleByte);

            short aNumber = 5039;

        }
    }
}