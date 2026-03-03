using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell.src.Commands
{
    internal class CommandRegistry
{
    private readonly Dictionary<string, ICommand> _commands;
    public CommandRegistry()
    {
        _commands = new Dictionary<string, ICommand>();
        Register(new EchoCommand());
        Register(new TypeCommand());
        Register(new ExitCommand());

    }
    public bool Contains(string commandName)
    {
        return _commands.ContainsKey(commandName);
    }
    public ICommand Get(string commandName)
    {
        return _commands[commandName];
    }
    public void Register(ICommand command)
    {
        _commands[command.Name] = command;
    }
}
}
