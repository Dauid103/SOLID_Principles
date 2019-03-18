using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID_Principles.LiskovSubstitutionPrinciple
{
    class EvenNumbersSumCalculator : Calculator
    {
        private readonly int[] _numbers;

        public EvenNumbersSumCalculator(int[] numbers)
            :base(numbers)
        {
            _numbers = numbers;
        }

        public override int Calculate() => _numbers.Where(n => n % 2 == 0).Sum();

    }
}
