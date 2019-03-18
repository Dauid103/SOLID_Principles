using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregationPrinciple
{
    public class MultiFuncionalCar : IMultiFunctionalVehicle
    {
        
        public void Drive()
        {
            Console.WriteLine("Driving my multifunctional car");
        }

        public void Fly()
        {
            Console.WriteLine("Flying my multifunctional car");
        }
    }
}
