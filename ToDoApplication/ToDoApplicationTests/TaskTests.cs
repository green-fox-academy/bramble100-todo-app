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

        // TODO: Constructor w/ string: ArgumentNullException!!!

        // TODO: Constructor /stringArray: ArgumentNullException!!!

        [Test]
        public void StringToBeSavedToFileTrue()
        {
            string[] array = { "true", "ToDo" };
            Task task = new Task(array);
            Assert.AreEqual("True;ToDo", task.StringToBeSavedToFile());
        }

        [Test]
        public void StringToBeSavedToFileFalse()
        {
            string[] array = { "false", "ToDo" };
            Task task = new Task(array);
            Assert.AreEqual("False;ToDo", task.StringToBeSavedToFile());
        }

        [Test]
        public void ToStringTrue()
        {
            string[] array = { "false", "ToDo" };
            Task task = new Task(array);
            Assert.AreEqual("[ ] ToDo", task.ToString());
        }

        [Test]
        public void ToStringFalse()
        {
            string[] array = { "true", "ToDo" };
            Task task = new Task(array);
            Assert.AreEqual("[x] ToDo", task.ToString());
        }

        [Test]
        public void CompleteFalse()
        {
            string[] array = { "false", "ToDo" };
            Task task = new Task(array);
            task.Complete();
            Assert.IsTrue(task.IsCompleted);
        }

        [Test]
        public void CompleteTrue()
        {
            string[] array = { "true", "ToDo" };
            Task task = new Task(array);
            task.Complete();
            Assert.IsTrue(task.IsCompleted);
        }
    }
}