using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.SingleResponsiblillityPrinciple
{
    public interface IEntryManager<T>
    {
        void AddEntry(T entity);
        void RemoveEntryAt(int index);
    }
}
