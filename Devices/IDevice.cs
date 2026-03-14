using GameControlSystem.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlSystem.Devices
{
    public interface IDevice
    {
        string Name { get; }
        void Attach(IObserver observer);
        void Notify(string message);
    }
}
