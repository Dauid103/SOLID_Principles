using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID_Principles.LiskovSubstitutionPrinciple
{
    public class SumCalculator : Calculator
    {
        private readonly int[] _numbers;

        public SumCalculator(int[] numbers)
            :base(numbers)
        {
            _numbers = numbers;
        }

        public override int Calculate() => _numbers.Sum();

    }
}
