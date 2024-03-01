namespace Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Task list:");
            Console.WriteLine("1. Operations on strings");
            Console.WriteLine("2. Compare two numbers");
            Console.WriteLine("3. Days of the week");
            Console.Write("To select one of the tasks, enter its number: ");
            short taskNumber = Convert.ToInt16(Console.ReadLine());
            switch (taskNumber)
            {
                case 1:
                    FirstTask.Task();
                    break;
                case 2:
                    SecondTask.Task();
                    break;
                case 3:
                    ThirdTask.Task();
                    break;
                default:
                    Console.WriteLine("Task Not Found!");
                    break;
            }
        }
    }
}