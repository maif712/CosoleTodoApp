using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppWithCompletedStatusConsoleApp
{
    public class Todo
    {
        public Todo(string title)
        {
            Title = title;
        }

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public bool IsCompleted { get; set; } = false;

        public void DispalyInfo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"#: {Id}, {Title}, completed: {(IsCompleted ? "[Done]" : "[Pending]")}");
            Console.WriteLine("----------------------");
        }
    }
}
