using GameControlSystem.Commands;
using GameControlSystem.Core;
using GameControlSystem.Devices;
using GameControlSystem.Observers;
using GameControlSystem.Strategies;

namespace GameControlSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game Control System started\n");

            var door = new Door();
            var light = new Light();
            var music = new MusicPlayer();

            var dashboard = new DashboardObserver();
            var logger = new LoggerObserver();
            var audit = new AuditObserver();

            door.Attach(dashboard);
            door.Attach(logger);
            door.Attach(audit);

            light.Attach(dashboard);
            light.Attach(logger);

            music.Attach(dashboard);
            music.Attach(logger);

            var facade = new GameFacade();

            facade.AddDevice(door);
            facade.AddDevice(light);
            facade.AddDevice(music);

            facade.SetMode(new CombatMode());

            facade.RunCommand(new OpenDoorCommand(door));
            facade.RunCommand(new TurnOnLightCommand(light));
            facade.RunCommand(new PlayMusicCommand(music));

            Console.WriteLine();
            facade.ReplayLast5();

            Console.WriteLine("\nSwitching to StealthMode...");
            facade.SetMode(new StealthMode());
            facade.RunCommand(new PlayMusicCommand(music));
        }
    }
}
