using System;
using System.Collections.Generic;
using System.Threading;

namespace Project_2_ThreadSafe
{
    class Program
    {
        static Dictionary<char, Action> ConsoleMenuDictionary = new Dictionary<char, Action>
        {
            {'1',  ThreadSafeTest},
        };
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(value: "Zahra Bodaghi");
            Console.WriteLine(value: "Assignmnet 8");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(value: "1) Demo the ThreadSafeTest");
                Console.WriteLine(value: "X) exit");
                Console.Write(value: "Select demonstration: ");

                var keyPressed = Console.ReadKey().KeyChar;
                if (keyPressed == 'x' || keyPressed == 'X')
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
        static bool _done;
        static readonly object Locker = new object();
        private static void ThreadSafeTest()
        {
            /*
             * It prints Done when it is done but without it it does not get to the point to print done.
             */
            _done = false;
            new Thread(Go).Start();
            Go();
            
        }
        static void Go()
        {
            lock(Locker)
            {
                if(!_done)
                {
                    Thread.Sleep(millisecondsTimeout: 10);
                    _done = true;
                    Console.WriteLine(value: "Done");
                }
            }
        }
    }
}
