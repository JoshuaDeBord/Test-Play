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
            float setTimer;



            Console.WriteLine("Type \"timer\", \"stopwatch\", or \"clock\".");
            
            string clockChoice = Console.ReadLine();
            
            switch (clockChoice)
            {
                case "timer":
                    Console.WriteLine("Type the amount of seconds you want your timer to have. Examples are");

                    string timerChoice = Console.ReadLine();

                   switch (timerChoice)
                    {
                        case ("0.30"):
                            
                            break;
                       

                        case ("1.00"):

                            break;
                    }



                    break;


            }


























        }
    }
}
