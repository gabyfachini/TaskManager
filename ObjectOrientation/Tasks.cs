using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public abstract class TaskBase //abstract because it cannot be instantiated
    {
        public TaskBase(string description) {
            Description = description;
            IsCompleted = false;
            CreatedAt = DateTime.Now;
        } //Constructor, is a method that every class has to initialize the class
        //All properties
        public string Description { get; set; } //search and modify the value of something
        public bool IsCompleted { get; set; } //Specific attribute of the class
        public DateTime CreatedAt { get; set; }
        public abstract void Execute(); // Method, the void is the return
        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
        public override string ToString() //public virtual string? ToString (); Always will be the standard
        {
            return $"[{(IsCompleted ? "X" : " ")}] {Description} (Created at: {CreatedAt})";
        }

    }
    public class SimpleTask : TaskBase
    {
        public SimpleTask(string description) : base(description)
        {

        }
        public override void Execute()
        {
            Console.WriteLine($"Executing Simple Task: {Description}");
            MarkAsCompleted();
        }
    }
    public class DeadlineTask : TaskBase       
    {
        public DeadlineTask(string description, DateTime deadline) : base(description)
        {
            Deadline = deadline;
        } //Constructor, is a method that every class has to initialize the class
        public DateTime Deadline { get; set; }
        public override void Execute() //Polymorphism, saying that a method can exist in several ways
        {
            Console.WriteLine($"Executing Deadline Task: {Description} by {Deadline}");
            MarkAsCompleted();
        }
        public override string ToString() 
        {
            return base.ToString() + $" with Deadline: {Deadline.ToShortDateString()}";
        }
    }
}
