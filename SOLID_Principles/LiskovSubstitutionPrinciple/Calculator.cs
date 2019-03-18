using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitutionPrinciple
{
    public abstract class Calculator
    {
        private readonly int[] _numbers;

        public Calculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public abstract int Calculate();

    }
}
