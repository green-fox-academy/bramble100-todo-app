using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    public class Services
    {
        public static string[] AvailableOptions = {
            "list",
            "add",
            "remove",
            "complete"
        };

        public Dictionary<string, char> ShortArgs = new Dictionary<string, char> {
            { AvailableOptions[0], 'l' },
            { AvailableOptions[1], 'a' },
            { AvailableOptions[2], 'r' },
            { AvailableOptions[3], 'c' }
        };
        public Dictionary<string, string> Descriptions = new Dictionary<string, string>
        {
            { AvailableOptions[0], "Lists all the tasks" },
            { AvailableOptions[1], "Adds a new task" },
            { AvailableOptions[2], "Removes a task" },
            { AvailableOptions[3], "Completes a task" }
        };
    }
}
