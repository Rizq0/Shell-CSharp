using src.Commands;

class Program
{
    static void Main()
    {
        var commandRegistry = new CommandRegistry();
        while (true)
        {
            Console.Write("$ ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                continue;  
            var inputParts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var commandName = inputParts[0].ToLower(); // meaning uppercase or lowercase commands will work
            var commandArgs = inputParts.Skip(1).ToArray(); // if command is "echo Hello World", commandArgs will be ["Hello", "World"] array[1] would only take the first argument

            if (commandRegistry.Contains(commandName))
            {
                var command = commandRegistry.Get(commandName);
                command.Execute(commandArgs);
            } else
            {
                Console.WriteLine($"{commandName}: not found.");
            }
        }
    }
}
