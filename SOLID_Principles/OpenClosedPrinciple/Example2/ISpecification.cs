using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosedPrinciple.Example2
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
