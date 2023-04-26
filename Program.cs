using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;

namespace Test_Play
{
    internal class StopWatch
    {
        private static void Main(string[] args)
        {
            Everything();
        }

        static void Everything()
        {
            float Timer;
            ConsoleKey spacePress;
            ConsoleKey backSpacePress;
            while (true)
            {
                Console.WriteLine("Type \"timer\", \"stopwatch\", or \"clock\".");

                string clockChoice = Console.ReadLine();
                Console.Clear();

                switch (clockChoice)
                {
                    case "timer":
                        while (true)
                        {

                            Console.WriteLine("Chose what amount of minutes you want your timer to have. \nThe timer will start immediately. \nChoices are \"1m\", \"5min\", \"10min\", \"30min\", \"1h\". ");

                            string timerChoice = Console.ReadLine();

                            switch (timerChoice)
                            {
                                case ("30sec"):
                                    Console.WriteLine("30 seconds chosen");
                                    Timer = 31.0f;
                                    Console.Clear();
                                    while (true)
                                    {
                                        Timer -= 1;
                                        Console.WriteLine(Timer);
                                        Thread.Sleep(1000);
                                        Console.Clear();

                                        if (Timer == 1)
                                        {
                                            Console.WriteLine("Timer Ended");
                                            break;
                                        }
                                    }
                                    break;



                                case ("1min"):
                                    Console.WriteLine("1 minute is chosen");
                                    Timer = 60.0f;
                                    Console.Clear();
                                    Console.WriteLine("1:00");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    while (true)
                                    {
                                        Timer -= 1;
                                        Console.WriteLine(Timer);
                                        Thread.Sleep(1000);
                                        Console.Clear();

                                        if (Timer == 1)
                                        {
                                            Console.WriteLine("Timer Ended");
                                            break;
                                        }

                                    }
                                    break;

                                case ("5min"):
                                    Console.WriteLine("5 minutes is chosen");
                                    Timer = 300.0f;
                                    int minute5 = (int)(Timer / 60);
                                    int second5 = (int)(Timer % 60);
                                    Console.Clear();
                                    Console.WriteLine("2:00");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    while (true)
                                    {
                                        Timer -= 1;
                                        minute5 = (int)(Timer / 60);
                                        second5 = (int)(Timer % 60);
                                        Console.WriteLine(minute5 + ":" + second5);
                                        Thread.Sleep(1000);
                                        Console.Clear();

                                        if (Timer == 1)
                                        {
                                            Console.WriteLine("Timer Ended");
                                            break;
                                        }

                                    }
                                    break;

                                case ("10min"):
                                    Console.WriteLine("5 minutes is chosen");
                                    Timer = 600.0f;
                                    int minute10 = (int)(Timer / 60);
                                    int second10 = (int)(Timer % 60);
                                    Console.Clear();
                                    Console.WriteLine("10:00");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    while (true)
                                    {
                                        Timer -= 1;
                                        minute10 = (int)(Timer / 60);
                                        second10 = (int)(Timer % 60);
                                        Console.WriteLine(minute10 + ":" + second10);
                                        Thread.Sleep(1000);
                                        Console.Clear();

                                        if (Timer == 1)
                                        {
                                            Console.WriteLine("Timer Ended");
                                            break;
                                        }

                                    }
                                    break;

                                case ("30min"):
                                    Console.WriteLine("30 minutes is chosen");
                                    Timer = 1800.0f;
                                    int minute30 = (int)(Timer / 60);
                                    int second30 = (int)(Timer % 60);
                                    Console.Clear();
                                    Console.WriteLine("30:00");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    while (true)
                                    {
                                        Timer -= 1;
                                        minute30 = (int)(Timer / 60);
                                        second30 = (int)(Timer % 60);
                                        Console.WriteLine(minute30 + ":" + second30);
                                        Thread.Sleep(1000);
                                        Console.Clear();

                                        if (Timer == 1)
                                        {
                                            Console.WriteLine("Timer Ended");
                                            break;
                                        }

                                    }
                                    break;

                                case ("1h"):
                                    Console.WriteLine("30 minutes is chosen");
                                    Timer = 3600.0f;
                                    int minute1h = (int)(Timer / 60);
                                    int second1h = (int)(Timer / 60);

                                    Console.Clear();
                                    Console.WriteLine("1:00:00");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    while (true)
                                    {
                                        Timer -= 1;
                                        minute1h = (int)(Timer / 60);
                                        second1h = (int)(Timer % 60);
                                        Console.WriteLine(minute1h + ":" + second1h);
                                        Thread.Sleep(1000);
                                        Console.Clear();

                                        if (Timer == 1)
                                        {
                                            Console.WriteLine("Timer Ended");
                                            break;
                                        }

                                    }
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("That is not a valid Input.");
                                    Thread.Sleep(1000);
                                    break;
                            }
                            Console.Clear();
                        }
                        break;

                    case "stopwatch":
                        while (true)
                        {

                            Console.WriteLine("\nPress any key to start the stopwatch.");
                            spacePress = Console.ReadKey().Key;
                            if (spacePress == ConsoleKey.Spacebar)
                            {
                                Console.Clear();
                                System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
                                stopWatch.Start();
                                Console.WriteLine("Stopwatch Started. Press any key to stop.");
                                while (!Console.KeyAvailable)
                                {
                                    Console.WriteLine("Elasped Time: {0}. \nPress spacebar to stop. \nPress Backspace to exit", stopWatch.Elapsed.ToString(@"hh\:mm\:ss\.fff"));
                                    Thread.Sleep(10);
                                    Console.Clear();
                                }
                                stopWatch.Stop();
                                Console.WriteLine("Stopwatch stopped! Total elasped time: {0}", stopWatch.Elapsed);
                                Console.ReadKey();
                            }
                            else if (spacePress == ConsoleKey.Backspace)
                            {
                                Console.Clear();
                                Console.WriteLine("Exiting...");
                                Thread.Sleep(100);
                                Everything();
                            }



                            else
                            { Console.WriteLine("That is an invalid input"); }
                        }
                        break;

                    case "clock":
                        for (; ; )
                        {
                            Console.WriteLine(DateTime.Now.ToString());
                            Console.WriteLine("Press a key to refresh. \nPress Backspace to exit.");
                            Console.WriteLine("\a");
                        backSpacePress = Console.ReadKey().Key;
                            
                            if (backSpacePress == ConsoleKey.Backspace)
                        {
                                Console.WriteLine("Exiting...");
                                Thread.Sleep(1000);
                                Console.Clear();
                                Everything();
                        }
                            Console.WriteLine("\nRefreshing...");
                            Thread.Sleep(500);
                            Console.Clear();
                        }
                        break;

                    default:
                        Console.WriteLine("That is not a valid input.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}