using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlSystem.Observers
{
    public class DashboardObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Dashboard: {message}");
        }
    }
}
