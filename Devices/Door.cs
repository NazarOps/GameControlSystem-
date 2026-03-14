using GameControlSystem.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlSystem.Devices
{
    public class Door : IDevice
    {
        private readonly List<IObserver> observers = new();

        public string Name => "Door";

        public void Open()
        {
            Console.WriteLine("Door opened");
            Notify("Door opened");
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
