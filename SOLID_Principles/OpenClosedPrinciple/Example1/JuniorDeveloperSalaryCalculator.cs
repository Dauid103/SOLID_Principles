using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosedPrinciple.Example1
{
    public class JuniorDeveloperSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDeveloperSalaryCalculator(DeveloperReport report) : base(report)
        { 
        }

        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;

    }
}
