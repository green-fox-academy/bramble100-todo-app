using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ToDoApplication;

namespace ToDoApplicationTestSuite
{
    [TestFixture]
    class TaskTests
    {
        [Test]
        public void CreateWithWellFormattedString()
        {
            Task task = new Task("ToDo");
            Assert.AreEqual("ToDo", task.Description);
        }

        [Test]
        public void CreateWithStringArrayWithTrue()
        {
            string[] array = { "true", "ToDo" };
            Task task = new Task(array);
            Assert.AreEqual("ToDo", task.Description);
            Assert.AreEqual(true, task.IsCompleted);
        }

        [Test]
        public void CreateWithStringArrayWithFalse()
        {
            string[] array = { "false", "ToDo" };
            Task task = new Task(array);
            Assert.AreEqual("ToDo", task.Description);
            Assert.AreEqual(false, task.IsCompleted);
        }

        //[Test]
        //public void CreateWithStringArrayWithFalse()
        //{
        //    string[] array = { "false", "ToDo" };
        //    Task task = new Task(array);
        //    Assert.AreEqual("ToDo", task.Description);
        //    Assert.AreEqual(false, task.IsCompleted);
        //}
    }
}