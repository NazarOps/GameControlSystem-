using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlSystem.Core
{
    public class Logger
    {
        private static Logger? instance;

        public static Logger Instance => instance ??= new Logger();

        private Logger() { }

        public void Log(string message)
        {
            Console.WriteLine($"LOG: {message}");
        }
    }
}
