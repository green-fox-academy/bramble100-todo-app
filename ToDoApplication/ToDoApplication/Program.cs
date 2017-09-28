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

            Tasks tasks = new Tasks();

            if (args[0].Equals($"--{Services.AvailableOptions[0]}") ||
                args[0].Equals($"-{services.ShortArgs[Services.AvailableOptions[0]]}"))
            {
                Console.WriteLine(tasks.ToString());
            }
            else if (args[0].Equals($"--{Services.AvailableOptions[1]}") ||
                args[0].Equals($"-{services.ShortArgs[Services.AvailableOptions[1]]}"))
            {
                Console.WriteLine("Add");
            }
            else if (args[0].Equals($"--{Services.AvailableOptions[2]}") ||
                args[0].Equals($"-{services.ShortArgs[Services.AvailableOptions[2]]}"))
            {
                Console.WriteLine("Remove");
            }
            else if (args[0].Equals($"--{Services.AvailableOptions[3]}") ||
                args[0].Equals($"-{services.ShortArgs[Services.AvailableOptions[3]]}"))
            {
                Console.WriteLine("Complete");
            }
        }
    }
}
