class Program
{
    static void Main()
    {
        bool isRunning = true;
        List<string> commands = new List<string> { "echo", "exit", "type" };
        while (isRunning)
        {
            Console.Write("$ ");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            { 
                isRunning = false;
            }
            else if (input.ToLower().StartsWith("echo "))
            {
                Console.WriteLine(input.Substring(5));
            }
            else if (input.ToLower().StartsWith("type "))
            {
                string currentCommand = input.Substring(5).Trim();
                bool isBuiltin = commands.Any(c => c.Contains(currentCommand.ToLower()));
                if (isBuiltin)
                {
                    Console.WriteLine($"{currentCommand} is a shell builtin");
                }
                else
                {
                    Console.WriteLine($"{currentCommand}: not found");
                }
            }
            else
            {
                Console.WriteLine($"{input}: command not found");
            }
        }
    }
}
