/*
 * Author: Joaquin Gomez
 * Course: COMP-003A
 * Purpose: Lecture activity for variables, type system, Math, and Console properties
 * Reference: The C# Player's Guide (4e) by RB Whitaker
 */

namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* working with variables */
            // the following code shows all three primary variable-related activities:
            string username; // declaring a variable (1 of 3)
            Console.WriteLine("What is your name?"); // request for user input
            username = Console.ReadLine(); // assigning a value to a variable (2 of 3)
            Console.WriteLine("Hi " + username); // retrieving its current value (3 of 3)
                                                 // another example of the three primary variable related activities 
            (declaring, assigning, and retrieving)
 string favoriteColor;
            Console.WriteLine("What is your favorite color?");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + favoriteColor);