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
                HelpMessage helpMessage = new HelpMessage();
                Console.WriteLine(helpMessage.ToString());
            }

            Console.ReadKey();
        }
    }
}
