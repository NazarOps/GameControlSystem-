using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlSystem.Commands
{
    public class CommandInvoker
    {
        private readonly List<ICommand> history = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            history.Add(command);
        }

        public void ReplayLast5()
        {
            Console.WriteLine("Replaying last commands...");

            foreach (var command in history.TakeLast(5))
            {
                command.Execute();
            }
        }
    }
}
