using System;

namespace task_struct
{
    class Program
    {
        struct Task
        {
            public int id;
            public string title;
            public string description;
            public DateTime? dueDate;
            public bool done;
        }

        private static string ToString(Task task)
        {
            string dueDate = task.dueDate == null ? "" : $" ({task.dueDate.ToString("MMMM dd")})";
            string description = task.description == null ? "" : task.description == "" ? "" : $"\n\t{task.description}";
            char isDone = task.done ? 'x' : ' ';

            return $"{task.id,6}.\t[{isDone}] {task.title}{dueDate}{description}";
        }

        static void Main(string[] args)
        {
            Task task = new Task()
            {
                id = 12,
                description = "this is description",
                title = "Task Title",
                dueDate = new DateTime(2021, 5, 1),
                done = true,
            };
            Console.WriteLine(ToString(task));
        }
    }
}
