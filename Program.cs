namespace TodoListApp
{
    class Program
    {

        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Просмотреть задачи");
                Console.WriteLine("2. Добавить задачу");
                Console.WriteLine("3. Удалить задачу");
                Console.WriteLine("4. Выйти");
                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewTasks();
                        break;
                    case "2":
                        AddTask();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "4":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }

        static void ViewTasks()
        {
            Console.Clear();
            if (tasks.Count == 0)
            {
                Console.WriteLine("Задачи отсутствуют.");
                Console.WriteLine();
                Console.WriteLine("--------------------");
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
                Console.WriteLine();
                Console.WriteLine("--------------------");
            }
        }

        static void AddTask()
        {
            Console.Clear();
            Console.Write("Введите задачу: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Задача добавлена.");
        }

        static void RemoveTask()
        {
            ViewTasks();
            Console.Write("Введите номер задачи для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Задача удалена.");
            }
            else
            {
                Console.WriteLine("Неверный номер задачи.");
            }
        }
    }
}
