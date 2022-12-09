using System;
using System.Threading;
using TW.DeveloperTest.Contracts;
using TW.DeveloperTest.Logger;

namespace TW.DeveloperTest.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            IWorker worker = Ioc.Resolve<IWorker>();
            ILogger logger = Ioc.Resolve<ILogger>();

            do
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Modifiers.HasFlag(ConsoleModifiers.Control)
                        && key.Key == ConsoleKey.X)
                    {
                        run = false;
                    }
                }

                try
                {
                    var result = worker.GetResult();

                    logger.Info($"output - {result}");
                }
                catch (Exception e)
                {
                    //TODO replace with logging library
                    logger.Error($"error - {e.Message}");
                }
                
                Thread.Sleep(500);
            } while (run);
        }
    }
}
