using SOLID_Principles.OpenClosedPrinciple.Example1;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosedPrinciple
{
    public class SalaryCalculator
    {
        private readonly List<BaseSalaryCalculator> _developerCalculation;

        public SalaryCalculator(List<BaseSalaryCalculator> developerCalculation)
        {
            _developerCalculation = developerCalculation;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devCalc in _developerCalculation)
            {
                totalSalaries += devCalc.CalculateSalary();
            }

            return totalSalaries;
        }
    }
}
