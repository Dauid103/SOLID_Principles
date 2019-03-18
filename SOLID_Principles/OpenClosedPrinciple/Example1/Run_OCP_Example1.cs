using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.OpenClosedPrinciple.Example1
{
    class Run_OCP_Example1
    {
        public static void Run()
        {
            var devCalculations = new List<BaseSalaryCalculator>
        {
            new SeniorDeveloperSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
            new JuniorDeveloperSalaryCalculator(new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
            new SeniorDeveloperSalaryCalculator(new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
        };

            var calculator = new SalaryCalculator(devCalculations);
            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");

            Console.ReadKey();
        }
    }
}
