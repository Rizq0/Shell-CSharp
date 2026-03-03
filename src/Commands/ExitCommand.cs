using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell.src.Commands
{
    internal class ExitCommand : ICommand
    {
        public string Name => "exit";
        public void Execute(string[] args)
        {
            Environment.Exit(0);
        }
    }
}
