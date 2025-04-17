using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppWithCompletedStatusConsoleApp
{
    public static class HelperFunctions
    {
        // Menu Function
        public static void ShowMenu()
        {
            Console.WriteLine("1. Add Todo");
            Console.WriteLine("2. Display One Todo");
            Console.WriteLine("3. Show All");
            Console.WriteLine("0. Exit");
        }

        public static void AddTodo(List<Todo> todos)
        {
            Console.WriteLine("Enter your Todo title: ");
            string title = Console.ReadLine();
            Todo newTodo = new Todo(title);
            todos.Add(newTodo);
            Console.WriteLine("Todo added succesfully.");
        }

        public static void ShowOneTodoInfo(List<Todo> todos)
        {
            Console.WriteLine("Enter todo Id: ");
            string id = Console.ReadLine();
            var todo = todos.Find(todo => todo.Id == id);
            if (todo != null)
            {
                todo.DispalyInfo();
            }
            else
            {
                Console.WriteLine("No Todo Found, try again!");
            }
        }

        public static void ShowAllTodos(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                todo.DispalyInfo();
            }
        }
    }
}
