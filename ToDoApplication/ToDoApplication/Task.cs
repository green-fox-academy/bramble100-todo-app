using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    public class Task
    {
        public string Description = String.Empty;
        public bool IsCompleted = false;

        public Task(string item)
        {
            if (String.IsNullOrEmpty(item))
            {
                throw new ArgumentNullException("Unable to add: no task provided");
            }
            Description = item;
        }

        public Task(string[] rowFromFile)
        {
            IsCompleted = Convert.ToBoolean(rowFromFile[0].ToLower());            
            Description = rowFromFile[1];
        }

        public string StringToBeSavedToFile() => $"{IsCompleted};{Description}";

        public override string ToString() => $"[{(IsCompleted ? "x" : " ")}] {Description}";

        internal void Complete() => IsCompleted = true;
    }
}
