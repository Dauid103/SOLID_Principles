using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregationPrinciple
{
    class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }
}
