using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    class Task
    {
        public string Description;

        public Task(string item)
        {
            Description = item;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
