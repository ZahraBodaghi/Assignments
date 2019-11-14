using System;
using System.Collections.Generic;
using System.Threading;

namespace Project_1_ThreadTest
{
    class Program
    {
        static Dictionary<char, Func<int>> ConsoleMenuDictionary = new Dictionary<char, Func<int>>
        {
            {'1',() => ThreadTest() }
        };
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(value: "Zahra Bodaghi");
            Console.WriteLine(value: "Assignment 8");
            Console.WriteLine();
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine(value: "1) Demo the ThreadTest");
                Console.WriteLine(value: "X) exit");
                Console.Write(value: "Select demonstration: ");

                var keyPressed = Console.ReadKey().KeyChar;
                if(!(keyPressed !='x' ||   keyPressed != 'X'))
                {
                    return;
                }
                Console.WriteLine();
                Console.WriteLine();
                try
                {
                    ConsoleMenuDictionary[keyPressed].Invoke();

                }
                catch
                {

                }
                Console.WriteLine();

            }

        }
        private static int ThreadTest()
        {
            void WriteY()
            {
                for(int i=0; i<100; i++)
                {
                    Console.Write(value: "y");
                }
            }
            void WriteZ()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(value: "y");
                }
            }
            void WriteW()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(value: "y");
                }
            }
            Thread ty = new Thread(WriteY);
            ty.Start();

            for(int i=0; i<1000; i++)
            {
                Console.Write(value: "X");
            }
            return 0;
        }

    }
}
