using DSA;

internal class Program
{
    public static SLLQueue list = new SLLQueue();

    private static void ContinueTest()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("This is Singly Linked List Implementation\n");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        Console.Clear();
        int choice;
        string[] MenuItems = { "Enqueue Node", "Dequeue Node", "Current Node", "Display Queue", "Size Of Queue", "Status Of Queue", "Exit" };
        int data;

        do
        {
            Console.WriteLine("Menu : ");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < MenuItems.Length; ++i)
            {
                Console.WriteLine($"{i + 1} {MenuItems[i]}");
            }
            Console.Write("Enter Your Choice : ");
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[0]}]---");

                    Console.Write("Enter Data : ");
                    int.TryParse(Console.ReadLine(), out data);
                    list.Enqueue(data);

                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[1]}]---");

                    Console.WriteLine($"Removing Node : {list.Peek()}");
                    list.Dequeue();


                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[2]}]---");

                    Console.Write($"Current Node Is : {list.Peek()}");

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[3]}]---");

                    list.DisplayQueue();

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[4]}]---");

                    Console.WriteLine($"Total Size Of Queue: {SLLQueue.Count}");

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[5]}]---");

                    Console.WriteLine($"Queue Status : {list.isEmpty()}");

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("Application Exited...");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 79: //It is hidden and only used for testing purpose. You can write your custom tests here. Take help ContinueTest() method see cler and neat output on console.
                    Console.Clear();
                    Console.WriteLine("Running Tests.....");


                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Please Enter Valid Choice");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (choice != 7);
    }
}