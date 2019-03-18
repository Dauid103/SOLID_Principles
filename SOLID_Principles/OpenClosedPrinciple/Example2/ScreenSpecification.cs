using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosedPrinciple.Example2
{
    class ScreenSpecification : ISpecification<ComputerMonitor>
    {
        private readonly Screen _screen;

        public ScreenSpecification(Screen screen)
        {
            _screen = screen;
        }

        public bool IsSatisfied(ComputerMonitor item) => item.Screen == _screen;
    }
}
