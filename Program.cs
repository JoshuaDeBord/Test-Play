using System;
using System.Threading;
namespace Test_Play
{
    class Program
    {
        static void Main(string[] args)
        {
            float timerMinuteInSeconds = 0.60f;
            float timerTime = 0.0f;
            float Timer;



            Console.WriteLine("Type \"timer\", \"stopwatch\", or \"clock\".");
            
            string clockChoice = Console.ReadLine();
            Console.Clear();
            switch (clockChoice)
            {
                case "timer":
                    while (true)
                    {

                        Console.WriteLine("Type the amount of seconds you want your timer to have. Examples are");

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
                        } Console.Clear();
                    }


                    break;


            }


























        }
    }
}
