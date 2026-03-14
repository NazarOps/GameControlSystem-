using GameControlSystem.Commands;
using GameControlSystem.Devices;
using GameControlSystem.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlSystem.Core
{
    public class GameFacade
    {
        private readonly CommandInvoker invoker = new();
        private IModeStrategy mode = new ExplorationMode();
        private readonly List<IDevice> devices = new();

        public void AddDevice(IDevice device)
        {
            devices.Add(device);
        }

        public void SetMode(IModeStrategy newMode)
        {
            mode = newMode;
            Console.WriteLine($"Mode changed to {newMode.GetType().Name}");
        }

        public void RunCommand(ICommand command)
        {
            if (mode.CanExecute())
            {
                invoker.ExecuteCommand(command);
            }
            else
            {
                Console.WriteLine("Command blocked by current mode");
            }
        }

        public void ReplayLast5()
        {
            invoker.ReplayLast5();
        }
    }
}
