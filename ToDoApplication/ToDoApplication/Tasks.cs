using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    class Tasks : Dictionary<int, Task>
    {
        private static string path = @"./todo-list.txt";
        //private bool SourceFileExists;

        public Tasks()
        {
            string[] content = File.ReadAllLines(path);
            foreach (string item in content)
            {
                Add(Count, new Task(item));
            }
        }

        public void SaveToFile()
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Hello Alpaga!");
            }
        }

        public override string ToString()
        {
            if (Count == 0)
            {
                return "No todos for today! :)";
            }

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                stringBuilder.AppendLine($"{i + 1} - {this[i].ToString()}");
            }
            return stringBuilder.ToString();
        }
    }
}
