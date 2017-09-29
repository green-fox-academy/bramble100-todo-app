using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    class Tasks : List<Task>
    {
        private static string path = @"./todo-list.txt";

        public Tasks()
        {
            string[] content = File.ReadAllLines(path);
            foreach (string row in content)
            {
                if (!String.IsNullOrEmpty(row))
                {
                    Add(new Task(row.Split(';')));

                }
            }
        }

        internal void Add(string item)
        {
            if (String.IsNullOrEmpty(item))
            {
                throw new ArgumentNullException("Unable to add: no task provided");
            }
            Add(new Task(item));
        }

        internal void CompleteAt(int number) => this[number].Complete();

        internal void Remove(int number) => RemoveAt(number - 1);

        public void SaveToFile()
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                ForEach(item => writer.WriteLine(item.StringToBeSavedToFile()));
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
