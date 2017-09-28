using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    class Task
    {
        public string Description = String.Empty;
        public bool IsCompleted = true;

        public Task(string item)
        {
            if(String.IsNullOrEmpty(item))
            {
                throw new ArgumentNullException("Unable to add: no task provided");
            }
            Description = item;
        }

        public override string ToString()
        {
            //return "Hello";
            //return $"{IsCompleted}";
            //return $"{Description}";
            //return $"[] {Description}";
            return $"[{(IsCompleted ? "x" : " ")}] {Description}";
            // {(IsCompleted ? "x" : " ")}
        }
    }
}
