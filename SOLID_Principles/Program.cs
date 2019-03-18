using SOLID_Principles.DependencyInversionPrinciple;
using SOLID_Principles.InterfaceSegregationPrinciple;
using SOLID_Principles.LiskovSubstitutionPrinciple;
using SOLID_Principles.OpenClosedPrinciple.Example1;
using SOLID_Principles.OpenClosedPrinciple.Example2;
using SOLID_Principles.SingleResponsiblillityPrinciple;
using System;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------Test Single Responsiblillity Principle-------//

            //Run_SRP.Run();

            //--------Test Open Closed Principle-------------------//

            //Run_OCP_Example1.Run();
            //Run_OCP_Example2.Run();

            //--------Test Liskov Substitution Principle-----------//

            //Run_LSP.Run();

            //--------Test Interface Segregation Principle---------//

            //Run_ISP.Run();

            //--------Test Dependency Inversion Principle----------//

            Run_DIP.Run();

        }
    }
}
