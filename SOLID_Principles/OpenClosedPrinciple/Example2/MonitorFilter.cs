using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID_Principles.OpenClosedPrinciple.Example2
{
    class MonitorFilter : IFilter<ComputerMonitor>
    {
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification) =>
            monitors.Where(m => specification.IsSatisfied(m)).ToList();
        
    }
}
