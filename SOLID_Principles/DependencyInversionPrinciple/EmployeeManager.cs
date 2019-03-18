using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID_Principles.DependencyInversionPrinciple
{
    class EmployeeManager : IEmployeeRepository
    {
        private readonly List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Employee> EmployeesByGenderAndPosition(Gender gender, Position position)
        {
            return _employees.Where(emp => emp.Gender == gender && emp.Position == position);
        }

    }
}
