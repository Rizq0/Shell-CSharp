class Program
{
    static void Main()
    {
        bool isRunning = true;
        while (isRunning)
        {
            Console.Write("$ ");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            { 
                isRunning = false;
            }
            else
            {
                Console.WriteLine($"{input}: command not found");
            }
        }
    }
}
