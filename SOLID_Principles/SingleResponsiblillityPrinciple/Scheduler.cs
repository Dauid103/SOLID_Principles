using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID_Principles.SingleResponsiblillityPrinciple
{
    class Scheduler : IEntryManager<ScheduleTask>
    {
        private readonly List<ScheduleTask> _entries;

        public Scheduler()
        {
            _entries = new List<ScheduleTask>();
        }

        public void AddEntry(ScheduleTask task) => _entries.Add(task);

        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries.Select(x => $"TaskId: {x.TaskId}, Content: {x.Content}, Execute on: {x.ExecuteOn}"));
        }

    }
}
