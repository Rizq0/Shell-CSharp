using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Commands
{
    internal class EchoCommand : ICommand
{
    public string Name => "echo";
    public void Execute(string[] args)
    {
        Console.WriteLine(string.Join(" ", args)); // this joins the arguments with a space in between
    }
}
}
