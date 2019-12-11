using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Project_3_Await
{
    class Program
    {
        static Dictionary<char, Action> ConsoleMenuDictionary = new Dictionary<char, Action>
        {
            {'1', AwaitDemo1 },
            {'2', AwaitDemo2 },
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
                Console.WriteLine(value: "1) Demo the AwaitDemo1");
                Console.WriteLine(value: "2) Demo the AwaitDemo2");
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
        static Stopwatch _stopwatch = new Stopwatch();
        private static void AwaitDemo1()
        {
            _stopwatch.Reset();
            _stopwatch.Start();

            Task<string> a = WaitAsynchronouslyAsync(delay: 1000);
            Task<string> b = WaitAsynchronouslyAsync(delay: 100);
            var c = WaitAsynchronouslyAsync(delay: 10);
            var d = WaitAsynchronouslyAsync(delay: 2000);
            var e = WaitAsynchronouslyAsync(delay: 100);

            Console.WriteLine();

            Console.WriteLine(a.Result);
            Console.WriteLine(b.Result);
            Console.WriteLine(c.Result);
            Console.WriteLine(d.Result);
            Console.WriteLine(e.Result);

            Console.WriteLine();
            Console.WriteLine(value: $"{_stopwatch.ElapsedMilliseconds} total elapsed time");

            _stopwatch.Stop();

        }

        private static async Task<string> WaitAsynchronouslyAsync(int delay)
        {
            await Task.Delay(delay);
            Console.WriteLine(value: $"Completed take with {delay} delay");
            return $"completed {delay} in {_stopwatch.ElapsedMilliseconds} milliseconds";
        }

        private static void AwaitDemo2()
        {
            _stopwatch.Restart();
            _stopwatch.Start();
            var rnd = new Random();
            var runningTasks = new Task<string>[10];
            for(var taskNumber=0; taskNumber<10; taskNumber++)
            {
                runningTasks[taskNumber] = WaitAsynchronouslyAsync(rnd.Next(0, 5000));

            }

            Console.WriteLine();

            for(var taskNumber=0; taskNumber<10;taskNumber++)
            {
                Console.WriteLine(value:$"task#{taskNumber} { runningTasks[taskNumber].Result}");

            }

            Console.WriteLine();
            Console.WriteLine(value: $"{_stopwatch.ElapsedMilliseconds} total elapsed time");

            _stopwatch.Stop();
        }
    }
}
