using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameControlSystem.Strategies
{
    public class StealthMode : IModeStrategy
    {
        public bool CanExecute() => false;
    }
}
