using System;
/*
 * Zahra Bodaghi
 */

namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahra Bodaghi");
            Console.WriteLine("Assignment 7");
            Random randomNumber = new Random();
            int[] numbers = new int[10];
       
            Console.WriteLine("As Loaded...");
            var count = 0;
            
            //Creating 10 random number
            while(count != 10)
            {
               numbers[count] = randomNumber.Next(0, 100);
               count++;
            }
            // Displaying 10 random numbers
            for(int item = 0; item < 10; item++)
            {
                Console.Write(numbers[item]);
                Console.Write("  ");
            }
            //Sorting out the numbers & Displaying them
            Console.WriteLine("");
            Console.WriteLine("As retrived...");
            Array.Sort(numbers);
            for(int item = 1; item < 10; item++)
            {
                Console.Write(numbers[item]);
                Console.Write("  ");
            }

        }
    }
}
