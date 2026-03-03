using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodecraftersShell.src.Commands
{
    internal class TypeCommand : ICommand
    {
        public string Name => "type";
        public void Execute(string[] args)
        {
            var commandRegistry = new CommandRegistry();
            string commandToCheck = args[0];
            bool commandExists = commandRegistry.Contains(commandToCheck);
            if (commandExists)
            {
                Console.WriteLine($"{commandToCheck} is a shell builtin");
            }
            else
            {
                Console.WriteLine($"{commandToCheck} not found");
            }
        }
    }
}
