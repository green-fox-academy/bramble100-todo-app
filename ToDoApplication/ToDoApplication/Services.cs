using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    public class Services
    {
        private enum AvailableServices
        {
            List,
            Add,
            Remove,
            MarkAsCompleted
        };

        private Dictionary<AvailableServices, string> ShortArgs;
        private Dictionary<AvailableServices, string> LongArgs;
    }
}
