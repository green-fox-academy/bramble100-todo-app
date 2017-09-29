using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ToDoApplication;

namespace ToDoApplicationTests
{
    [TestFixture]
    class TasksTests
    {
        [Test]
        public void ConstructorFromList()
        {
            string[] array = { "true", "ToDo" };
            var task = new ToDoApplication.Task(array);
            var tasks = new Tasks();
            tasks.Add(task);
            Assert.AreEqual("ToDo", tasks[0].Description);
            Assert.AreEqual(true, tasks[0].IsCompleted);
        }
    }
}
