using System;
using System.Collections.Generic;
using System.Threading;

namespace Project_1_ThreadTest
{
    class Program
    {
        static Dictionary<char, Func<int>> ConsoleMenuDictionary = new Dictionary()
        {
            {'1', ()=>ThreadTest()  },
            {'2', ()=>ThreadTest2() },
            {'3', ()=>ThreadTest3() },
            {'4', ()=>ThreadTest4() },
            {'5', ()=>ThreadTest5() },
            {'6', ()=>ThreadTest6() },
            {'7', ()=>ThreadTest7() }
        };
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(value: "Zahra Bodaghi");
            Console.WriteLine(value: "Assignmnet 8");
            Console.WriteLine();
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine(value: "1) Demo the ThreadTest");
                Console.WriteLine(value: "2) Demo the ThreadTest2");
                Console.WriteLine(value: "3) Demo the ThreadTest3");
                Console.WriteLine(value: "4) Demo the ThreadTest4");
                Console.WriteLine(value: "5) Demo the ThreadTest5");
                Console.WriteLine(value: "6) Demo the ThreadTest6");
                Console.WriteLine(value: "7) Demo the ThreadTest7");
                Console.WriteLine(value: "X) exit");
                Console.Write(value: "Select demonstration: ");

                var keyPressed = Console.ReadKey().KeyChar;
                if(keyPressed == 'x' || keyPressed == 'X')
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
                for(int i=0;i<100;i++)
                {
                    Console.Write(value: "y");
                }
            }
            void WriteZ()
            {
                for(int i=0;i<100;i++)
                {
                    Console.Write(value: "z");
                }
            }
            void WriteW()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(value: "w");
                }
            }
            Thread ty = new Thread(WriteY);
            ty.Start();
            for(int i=0; i<1000;i++)
            {
                Console.Write(value: "X");
            }
            return 0;
        }
        private static int ThreadTest2()
        {
            void WriteAString(string StringToWrite)
            {
                for(int i=0; i<100;i++)
                {
                    Console.Write(StringToWrite);
                }
            }
            Thread ty = new Thread(start: () => WriteAString("y"));
            ty.Start();
            
            for(int i=0; i<1000; i++)
            {
                WriteAString("X");
            }

            return 0;
        }
        private static int ThreadTest3()
        {
            void WriteAString(string StringToWrite)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(StringToWrite);
                }
            }
            
            Thread ty = new Thread(() => WriteAString("y"));
            ty.Start();

            for(int i=0; i<5; i++)
            {
                WriteAString("X");
            }
            Thread.Sleep(5000);

            return 0;
        }
        private static int ThreadTest4()
        {
            void WriteAString(object StringToWrite)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(StringToWrite);
                }
            }
            Thread ty = new Thread(() => WriteAString("y"));
            ty.Start();

            Thread tz = new Thread(WriteAString);
            tz.Start("z");

            Thread tw = new Thread(WriteAString);
            tw.Start("w");

            for(int i=0; i<5; i++)
            {
                WriteAString("X");
            }

            while(ty.IsAlive || tz.IsAlive || tw.IsAlive)
            {
                Thread.Sleep(millisecondsTimeout: 10);
            }

            return 0;
        }

        private static int ThreadTest5()
        {
            void WriteAString(object StringToWrite)
            {
                for(int i=0; i<25; i++)
                {
                    Console.Write(StringToWrite);
                }
            }

            Thread[] aBunchOfThreads = new Thread[10];

            for(int threadNumber = 0; threadNumber<10; threadNumber++ )
            {
                aBunchOfThreads[threadNumber] = new Thread(start: () => WriteAString(threadNumber.ToString()));
                aBunchOfThreads[threadNumber].Start();

            }

            for(int i=0; i<5; i++)
            {
                WriteAString("X");
            }
            while(true)
            {
                var aThreadIsStillRunning = false;
                for(var threadNumber = 0; threadNumber<10;  threadNumber++)
                {
                    aThreadIsStillRunning = aThreadIsStillRunning || aBunchOfThreads[threadNumber].IsAlive;

                }
                if(!aThreadIsStillRunning)
                {
                    break;
                }
                Thread.Sleep(millisecondsTimeout: 10);

            }

            return 0;
}        
        private static int ThreadTest6()
        {
            void WriteAString(object StringToWrite)
            {
                for(int i=0;i<25; i++)
                {
                    Console.Write(StringToWrite);
                }
            }
            Thread[] aBunchOfThreads = new Thread[10];
            for(int threadNumber =0; threadNumber<10; threadNumber++)
            {
                aBunchOfThreads[threadNumber] = new Thread(start: () => WriteAString(threadNumber.ToString()));
                aBunchOfThreads[threadNumber].Start();
            }

            for(int i=0; i<5; i++)
            {
                WriteAString("X");
            }

            for(var threadNumber = 0; threadNumber<10; threadNumber++)
            {
                aBunchOfThreads[threadNumber].Join();
            }
            return 0;
        }

        static bool _done;
        private static int ThreadTest7()
        {
            _done = false;
            new Thread(Go).Start();
            Go();

            return 0;
        }
        static void Go()
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
