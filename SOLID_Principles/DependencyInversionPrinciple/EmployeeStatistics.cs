using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID_Principles.DependencyInversionPrinciple
{
    class EmployeeStatistics
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeStatistics(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public int CountFemaleManagers()
        {
            return _employeeRepository.EmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
        }
      
    }
}
