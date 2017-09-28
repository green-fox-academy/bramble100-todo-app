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
            }
            else if (command.Equals($"--{Services.AvailableOptions[1]}") ||
                command.Equals($"-{services.ShortArgs[Services.AvailableOptions[1]]}"))
            {
                // Add
                try
                {
                    tasks.Add(args[1]);
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentNullException || ex is IndexOutOfRangeException)
                    {
                        Console.WriteLine("Unable to add: no task provided");
                    }
                }
            }
            else if (command.Equals($"--{Services.AvailableOptions[2]}") ||
                command.Equals($"-{services.ShortArgs[Services.AvailableOptions[2]]}"))
            {
                Console.WriteLine("Remove");
            }
            else if (command.Equals($"--{Services.AvailableOptions[3]}") ||
                command.Equals($"-{services.ShortArgs[Services.AvailableOptions[3]]}"))
            {
                Console.WriteLine("Complete");
            }
        }
    }
}
