using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosedPrinciple.Example2
{
    class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly MonitorType _type;

        public MonitorTypeSpecification(MonitorType type)
        {
            _type = type;
        }

        public bool IsSatisfied(ComputerMonitor monitor) => monitor.Type == _type;

    }
}
