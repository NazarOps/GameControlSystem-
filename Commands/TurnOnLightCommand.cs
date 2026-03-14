using GameControlSystem.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlSystem.Commands
{
    public class TurnOnLightCommand : ICommand
    {
        private readonly Light light;

        public TurnOnLightCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }
}
