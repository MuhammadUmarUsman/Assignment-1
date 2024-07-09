using System;

namespace Programming_Lecture
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello Programmers!");
            
             Example 0: User input
            Console.Write("Enter your marks: ");
            string userInput = Console.ReadLine();
            int mark = int.Parse(userInput);
            if(mark > 50)
            {
                Console.WriteLine("You passed");
            }

            // Example 1: If statement
            int num = 10;

            if (num > 0)
            {
                Console.WriteLine("The number is positive.\n");
            }

            // Example 2: If else statement
            int age = 17;

            if (age >= 18)
            {
                Console.WriteLine("You are an adult.\n");     // '\n' is used to print new line 
            }
            else
            {
                Console.WriteLine("You are a minor.\n");
            }

            // Example 3: If-Else If statement
            int marks = -85;
            if (marks >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
            */

            //// Example 4: Switch Case statement
            //int dayOfWeek = 3;
            //string dayName;
            //switch (dayOfWeek)
            //{
            //    case 1:
            //        dayName = "Monday";
            //        break;
            //    case 2:
            //        dayName = "Tuesday";
            //        break;
            //    case 3:
            //        dayName = "Wednesday";
            //        break;
            //    case 4:
            //        dayName = "Thursday";
            //        break;
            //    case 5:
            //        dayName = "Friday";
            //        break;
            //    case 6:
            //        dayName = "Saturday";
            //        break;
            //    case 7:
            //        dayName = "Sunday";
            //        break;
            //    default:
            //        dayName = "Funday";
            //        break;
            //}
            //Console.WriteLine($"Today is {dayName}\n");


            // Example 5: For loop
            for (int i = 5; i > 0; i--) // i = i+1
            {
                Console.WriteLine("Value of i: " + i.ToString());
                Console.WriteLine($"Value of i: {i}");
            }


            //Example 6: While loop
            int countdown = 10;
            while (countdown > 0)
            {
                Console.WriteLine($"Countdown: {countdown}");
                countdown--; // countdown = countdown - 1
            }



        }
    }
}
