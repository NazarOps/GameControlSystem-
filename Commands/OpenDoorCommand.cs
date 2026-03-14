using GameControlSystem.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlSystem.Commands
{
    public class OpenDoorCommand : ICommand
    {
        private readonly Door door;

        public OpenDoorCommand(Door door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Open();
        }
    }
}
