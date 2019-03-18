using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.DependencyInversionPrinciple
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> EmployeesByGenderAndPosition(Gender gender, Position position);
    }
}
