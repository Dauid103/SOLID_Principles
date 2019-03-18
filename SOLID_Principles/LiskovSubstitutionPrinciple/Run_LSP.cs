using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitutionPrinciple
{
    public class Run_LSP
    {

        public static void Run()
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            Calculator sum = new SumCalculator(numbers);
            Console.WriteLine($"The sum of all numbers: {sum.Calculate()}");

            Console.WriteLine();

            Calculator evenSum = new EvenNumbersSumCalculator(numbers); 
            Console.WriteLine($"The sum of all numbers: {evenSum.Calculate()}");

            Console.Read();

        }
        
    }
}
