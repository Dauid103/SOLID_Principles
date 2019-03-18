using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.InterfaceSegregationPrinciple
{
    class Airplane : IAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Flying an Airplane");
        }
    }
}
