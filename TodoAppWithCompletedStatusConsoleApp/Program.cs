namespace TodoAppWithCompletedStatusConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo("Buy groceries"),
                new Todo("Finish the C# project"),
                new Todo("Call mom"),
                new Todo("Go for a run"),
                new Todo("Read a book")
            };
            bool isExit = false;
            while (!isExit)
            {
                HelperFunctions.ShowMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        HelperFunctions.AddTodo(todos);
                        break;
                    case "2":
                        HelperFunctions.ShowOneTodoInfo(todos);
                        break;
                    case "3":
                        HelperFunctions.ShowAllTodos(todos);
                        break;
                    case "4":
                        CompleteTodo();
                        break;
                    case "0":
                        isExit = true;
                        Console.WriteLine("Exiting the application...");
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                        
                }
            }
        }
        public static void CompleteTodo()
        {
            Console.WriteLine("Enter the ID of the task you want tomark as complete.");
            string TaskId = Console.ReadLine();

            Todo task =(task => task.id == TaskId);
            if (task != null)
            {
                task.CompleteTask();
                Console.WriteLine($"task{task.Title}marked as completed");

            }
            else
            {
                Console.WriteLine("task not found.");
            }
        }
        
    }
}
