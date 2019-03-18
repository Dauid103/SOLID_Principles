using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregationPrinciple
{
    public class Run_ISP
    {
        public static void Run()
        {
            
            MultiFuncionalCar multiFunctionalCar = new MultiFuncionalCar();

            multiFunctionalCar.Drive();
            multiFunctionalCar.Fly();

            Console.Read();
        }
    }
}
