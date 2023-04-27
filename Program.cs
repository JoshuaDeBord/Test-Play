using System;
using System.Threading;
using System.Threading.Tasks;

namespace Test_Play
{
    internal class StopWatch
    {
        private static bool timerOn;
        private static void Main(string[] args)
        {

            Everything();
        }

        public static async Task BackSpace()
        {
            await Task.Run(() =>
            {
                ConsoleKey spacePress;

                while (timerOn)
                {
                    spacePress = Console.ReadKey().Key;
                    if (spacePress == ConsoleKey.Backspace)
                    {
                        timerOn = false;
                        Console.Clear();
                        Console.WriteLine("Exiting...");
                        Thread.Sleep(600);
                        Console.Clear();
                        Everything();
                    }
                }

            });
        }


        public static async Task TimerTime1Hour()
        {
            await Task.Run(() =>
            {
                float Timer;

                ConsoleKey backSpacePress;

                Console.WriteLine("1 hour is chosen");
                Timer = 3600.0f;
                int minute1h = (int)(Timer / 60);
                int second1h = (int)(Timer / 60);

                Console.Clear();
                Console.WriteLine("Timer is: 1:00:00");
                Console.WriteLine("Press Backspace To Exit");
                Thread.Sleep(1000);
                Console.Clear();
                while (timerOn)
                {
                    Timer -= 1;
                    minute1h = (int)(Timer / 60);
                    second1h = (int)(Timer % 60);
                    Console.WriteLine("Timer is: " + minute1h + ":" + second1h);
                    Console.WriteLine("Press Backspace To Exit");
                    Thread.Sleep(1000);
                    Console.Clear();

                    if (Timer == 1)
                    {
                        Console.WriteLine("Timer Ended");
                        Console.WriteLine("Press Backspace To Exit");
                        backSpacePress = Console.ReadKey().Key;
                        if (backSpacePress == ConsoleKey.Backspace)
                        {
                            Everything();
                            Console.Clear();
                        }
                        break;
                    }

                }

            });
        }


        public static async Task TimerTime30Minutes()
        {
            await Task.Run(() =>
            {
                float Timer;

                ConsoleKey backSpacePress;
                Console.WriteLine("30 minutes is chosen");
                Timer = 1800.0f;
                int minute30 = (int)(Timer / 60);
                int second30 = (int)(Timer % 60);
                Console.Clear();
                Console.WriteLine("Timer is: 30:00");
                Console.WriteLine("Press Backspace To Exit");
                Thread.Sleep(1000);
                Console.Clear();
                while (timerOn)
                {
                    Timer -= 1;
                    minute30 = (int)(Timer / 60);
                    second30 = (int)(Timer % 60);
                    Console.WriteLine("Timer is: " + minute30 + ":" + second30);
                    Console.WriteLine("Press Backspace To Exit");
                    Thread.Sleep(1000);
                    Console.Clear();

                    if (Timer == 1)
                    {
                        Console.WriteLine("Timer Ended");
                        Console.WriteLine("Press Backspace To Exit");
                        backSpacePress = Console.ReadKey().Key;
                        if (backSpacePress == ConsoleKey.Backspace)
                        {
                            Everything();
                            Console.Clear();
                        }
                        break;
                    }

                }

            });
        }


        public static async Task TimerTime10Minutes()
        {
            await Task.Run(() =>
            {
                float Timer;

                ConsoleKey backSpacePress;
                Console.WriteLine("10 minutes is chosen");
                Timer = 600.0f;
                int minute10 = (int)(Timer / 60);
                int second10 = (int)(Timer % 60);
                Console.Clear();
                Console.WriteLine("Timer is: 10:00");
                Console.WriteLine("Press Backspace To Exit");
                Thread.Sleep(1000);
                Console.Clear();
                while (timerOn)
                {
                    Timer -= 1;
                    minute10 = (int)(Timer / 60);
                    second10 = (int)(Timer % 60);
                    Console.WriteLine("Timer is: " + minute10 + ":" + second10);
                    Thread.Sleep(1000);
                    Console.Clear();

                    if (Timer == 1)
                    {
                        Console.WriteLine("Timer Ended");
                        Console.WriteLine("Press Backspace To Exit");
                        backSpacePress = Console.ReadKey().Key;
                        if (backSpacePress == ConsoleKey.Backspace)
                        {
                            Everything();
                            Console.Clear();
                        }
                        break;
                    }

                }

            });
        }

        public static async Task TimerTime5Minutes()
        {
            await Task.Run(() =>
            {
                float Timer;

                ConsoleKey backSpacePress;
                Console.WriteLine("5 minutes is chosen");
                Timer = 300.0f;
                int minute5 = (int)(Timer / 60);
                int second5 = (int)(Timer % 60);
                Console.Clear();
                Console.WriteLine("Timer is: 5:00");
                Console.WriteLine("Press Backspace To Exit");
                Thread.Sleep(1000);
                Console.Clear();
                while (timerOn)
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
                        Console.WriteLine("Press Backspace To Exit");
                        backSpacePress = Console.ReadKey().Key;
                        if (backSpacePress == ConsoleKey.Backspace)
                        {
                            Everything();
                            Console.Clear();
                        }
                        break;
                    }

                }

            });
        }



        //From Here Down Is The Main Code ~~~
        private static void Everything()
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

                            Console.WriteLine("Choose what amount of minutes you want your timer to have. \nThe timer will start immediately once chosen. \nChoices are \"30sec\", \"1min\", \"5min\", \"10min\", \"30min\", \"1h\". ");

                            string timerChoice = Console.ReadLine();

                            switch (timerChoice)
                            {
                                case ("30sec"):
                                    Console.WriteLine("1 minute is chosen");
                                    Timer = 30.0f;
                                    Console.Clear();
                                    Console.WriteLine("Timer is: 00:30");
                                    Console.WriteLine("Press Backspace To Exit");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    while (true)
                                    {
                                        Timer -= 1;
                                        Console.WriteLine("Timer is: 00:" + Timer);
                                        Console.WriteLine("Press Backspace To Exit");
                                        Thread.Sleep(1000);
                                        Console.Clear();

                                        if (Timer == 1)
                                        {
                                            spacePress = Console.ReadKey().Key;
                                            if (spacePress == ConsoleKey.Backspace)
                                            {
                                                timerOn = false;
                                                Console.Clear();
                                                Console.WriteLine("Exiting...");
                                                Thread.Sleep(600);
                                                Console.Clear();
                                                Everything();
                                            }

                                            break;
                                        }

                                    }
                                    break;



                                case ("1min"):
                                    Console.WriteLine("1 minute is chosen");
                                    Timer = 60.0f;
                                    Console.Clear();
                                    Console.WriteLine("Timer is: 1:00");
                                    Console.WriteLine("Press Backspace To Exit");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    while (true)
                                    {
                                        Timer -= 1;
                                        Console.WriteLine("Timer is: 00:" + Timer);
                                        Console.WriteLine("Press Backspace To Exit");
                                        Thread.Sleep(1000);
                                        Console.Clear();

                                        if (Timer == 1)
                                        {
                                            Console.WriteLine("Timer Ended");
                                            Console.WriteLine("Press Backspace To Exit");
                                            backSpacePress = Console.ReadKey().Key;
                                            if (backSpacePress == ConsoleKey.Backspace)
                                            {
                                                Everything();
                                                Console.Clear();
                                            }
                                            break;
                                        }

                                    }
                                    break;

                                case ("5min"):

                                    Task task1 = TimerTime5Minutes();
                                    timerOn = true;
                                    Task task2 = BackSpace();
                                    Task.WaitAll(task2);

                                    Task.WaitAll(task1);


                                    break;

                                case ("10min"):
                                    Task task110 = TimerTime10Minutes();
                                    timerOn = true;
                                    Task task210 = BackSpace();
                                    Task.WaitAll(task210);

                                    Task.WaitAll(task110);


                                    break;

                                case ("30min"):
                                    Task task130 = TimerTime30Minutes();
                                    timerOn = true;
                                    Task task230 = BackSpace();
                                    Task.WaitAll(task230);

                                    Task.WaitAll(task130);


                                    break;

                                case ("1h"):
                                    Task task11h = TimerTime1Hour();
                                    timerOn = true;
                                    Task task21h = BackSpace();
                                    Task.WaitAll(task21h);

                                    Task.WaitAll(task11h);
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

                            Console.WriteLine("\nPress the SpaceBar to start the stopwatch. Press Backspace to exit.");
                            spacePress = Console.ReadKey().Key;
                            if (spacePress == ConsoleKey.Spacebar)
                            {
                                Console.Clear();
                                System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
                                stopWatch.Start();
                                Console.WriteLine("Stopwatch Started. Press the SpaceBar to stop.");
                                while (!Console.KeyAvailable)
                                {
                                    Console.WriteLine("Elasped Time: {0} \nPress spacebar to stop. \nPress Backspace to exit", stopWatch.Elapsed.ToString(@"hh\:mm\:ss\.fff"));
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
                                Thread.Sleep(600);
                                Console.Clear();
                                Everything();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("That is an invalid input");
                            }
                        }
                        break;

                    case "clock":
                        for (; ; )
                        {
                            Console.WriteLine(DateTime.Now.ToString());
                            Console.WriteLine("Press any key to refresh. \nPress Backspace to exit.");

                            backSpacePress = Console.ReadKey().Key;

                            if (backSpacePress == ConsoleKey.Backspace)
                            {
                                Console.WriteLine("\nExiting...");
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
                        Thread.Sleep(700);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
