using GameControlSystem.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlSystem.Devices
{
    public class Light : IDevice
    {
        private readonly List<IObserver> observers = new();

        public string Name => "Light";

        public void TurnOn()
        {
            Console.WriteLine("Light turned on");
            Notify("Light turned on");
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
