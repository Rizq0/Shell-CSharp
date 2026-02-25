class Program
{
    static void Main()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.Write("$ ");
            string input = Console.ReadLine();
            Console.WriteLine($"{input}: command not found");
        }
    }
}
