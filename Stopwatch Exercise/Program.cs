using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;

namespace Stopwatch_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is a exercise for a Stopwatch application." +
                             "\nTo start it please type 'Start' & Press the Enter Key while running to stop the application");
            var stopwatch = new Stopwatch();
            

            

            while (true)
            {
                try
                {
                    var input = Console.ReadLine();

                    switch (input.ToLower())
                    {
                        case "start":
                        stopwatch.Start();
                            stopwatch.SetTimer();
                        break;
                        default: 
                            stopwatch.Stop();
                            Console.WriteLine(stopwatch.Duration); 
                            stopwatch.ATimer.Stop();
                            stopwatch.ATimer.Dispose();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
