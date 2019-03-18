using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.DependencyInversionPrinciple
{
    public class Run_DIP
    {
        public static void Run()
        {
            var empManager = new EmployeeManager();
            empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });

            var stats = new EmployeeStatistics(empManager);
            Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");

            Console.Read();

        }
    }
}
