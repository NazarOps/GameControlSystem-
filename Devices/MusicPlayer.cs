using GameControlSystem.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlSystem.Devices
{
    public class MusicPlayer : IDevice
    {
        private readonly List<IObserver> observers = new();

        public string Name => "MusicPlayer";

        public void Play()
        {
            Console.WriteLine("Music started");
            Notify("Music started");
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
