using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Services services = new Services();

            if (args.Length == 0)
            {
                HelpMessage helpMessage = new HelpMessage(services);
                Console.WriteLine(helpMessage.ToString());
                return;
            }

            string command = args[0];

            Tasks tasks = new Tasks();

            if (command.Equals($"--{Services.AvailableOptions[0]}") ||
                command.Equals($"-{services.ShortArgs[Services.AvailableOptions[0]]}"))
            {
                // List
                Console.WriteLine(tasks.ToString());
                return;
            }

            if (command.Equals($"--{Services.AvailableOptions[1]}") ||
                command.Equals($"-{services.ShortArgs[Services.AvailableOptions[1]]}"))
            {
                // Add
                try
                {
                    tasks.Add(args[1]);
                    Console.WriteLine($"Task added ({args[1]})");
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentNullException || ex is IndexOutOfRangeException)
                    {
                        Console.WriteLine("Unable to add: no task provided");
                    }
                }
                tasks.SaveToFile();
            }
            else if (command.Equals($"--{Services.AvailableOptions[2]}") ||
                command.Equals($"-{services.ShortArgs[Services.AvailableOptions[2]]}"))
            {
                // Remove
                try
                {
                    int number = Convert.ToInt32(args[1]);
                    try
                    {
                        tasks.RemoveAt(number - 1);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Unable to remove: index is out of bound");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Unable to remove: no index provided");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to remove: index is not a number");
                }
                tasks.SaveToFile();
            }
            else if (command.Equals($"--{Services.AvailableOptions[3]}") ||
                command.Equals($"-{services.ShortArgs[Services.AvailableOptions[3]]}"))
            {
                // Complete

                Console.WriteLine("Complete");
                //tasks.SaveToFile();
            }
            else
            {
                Console.WriteLine("Unsupported argument");
                HelpMessage helpMessage = new HelpMessage(services);
                Console.WriteLine(helpMessage.ToString());
            }
        }
    }
}
