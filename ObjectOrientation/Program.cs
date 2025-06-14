using ObjectOrientation;

TaskManager taskManager = new TaskManager();

while(true) {
    Console.WriteLine();
    Console.WriteLine("1. Add Simple Task");
    Console.WriteLine("2. Add Deadline Task");
    Console.WriteLine("3. List Tasks");
    Console.WriteLine("4. Execute Tasks");
    Console.WriteLine("5. Exit");
    string option = Console.ReadLine();
    int index = 0;

    switch (option)
    {
        case "1":
            Console.WriteLine("Enter the task description: ");
            string description1 = Console.ReadLine();
            taskManager.AddTask(new SimpleTask(description1));
            Console.ReadKey(); 
            Console.Clear();
            break;

        case "2":
            Console.WriteLine("Enter the task description: ");
            string description2 = Console.ReadLine();
            DateTime deadline = DateTime.Now;
            taskManager.AddTask(new DeadlineTask(description2, deadline));
            Console.ReadKey(); 
            Console.Clear();
            break;
        case "3":
            Console.WriteLine("TASK LIST");
            Console.WriteLine("Enter the type of task you want to view:");
            Console.WriteLine("1. Simple Task");
            Console.WriteLine("2. Deadline Task");
            Console.WriteLine("3. Both Options");
            Console.WriteLine("4. Back to Main Menu");
            string type;

            while (true)
            {
                type = Console.ReadLine();

                switch (type)
                {
                    case "1":
                        taskManager.ListTasks("1");
                        Console.Write("Enter again: ");
                        continue;
                    case "2":
                        taskManager.ListTasks("2");
                        Console.Write("Enter again: ");
                        continue; 
                    case "3":
                        taskManager.ListTasks("3");
                        Console.Write("Enter again: ");
                        continue; 
                    case "4":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        Console.Write("Enter again: ");
                        continue; 
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            break;
        case "4":
            // Here, we will complete only the tasks that exist
            for (int i = 0; i < taskManager.Tasks.Count; i++) 
            {
                taskManager.CompleteTask(i);
            }
            Console.WriteLine();
            Console.WriteLine("Task Status:");
            taskManager.ListTasks("3"); // Assuming this method lists the tasks
            Console.ReadKey();
            Console.Clear();
            break;
        case "5":
            Console.WriteLine("The program is about to close.");
            return; // Ends the Main method, closing the program
        default:
            Console.WriteLine("Invalid option!");
            continue; // Continues asking for the option
    }
} 