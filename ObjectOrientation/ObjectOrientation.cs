using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientation
{
    internal class TaskManager
    {
        private List<Task> tasks = new List<Task>(); // stores multiple values of the same type
        public List<Task> Tasks => tasks;

        public void AddTask(Task task)
        {
            tasks.Add(task);
            Console.WriteLine("Task added successfully!");
        }
        public void ListTasks(string type)
        {
            if (!tasks.Any())
            {
                Console.WriteLine("No tasks listed!");
                return;
            }
            foreach (var task in tasks)
            {
                if (type == "1" && task is SimpleTask)
                {
                    Console.WriteLine(task);
                }
                else if (type == "2" && task is TimedTask)
                {
                    Console.WriteLine(task);
                }
                else if (type == "3")
                {
                    // To list both types of tasks, no filter is needed
                    Console.WriteLine(task);
                }
            }
        }
            public void CompleteTasks(int index)
            {
                if (index >= 0 && index < tasks.Count)
                {
                    tasks[index].Execute();
                    Console.WriteLine("Task Completed!");
                } else
                {
                    Console.WriteLine("Invalid index!");
                }
            }
        }
    }
