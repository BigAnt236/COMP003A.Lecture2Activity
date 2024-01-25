/*
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
            // score - "Generic User"; // will fail to compile because the "O" is still assigned as a string - enclosed in the double quotes
            score = 0; // works
            score = 4; // you can also reassign values to the variable as long as they are within scope and not constant
            score = 11;
            score = -1564;

            // test
        }
    }
}