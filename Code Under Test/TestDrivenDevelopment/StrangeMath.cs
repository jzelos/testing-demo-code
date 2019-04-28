using System;

namespace UnitTestDemo
{
    public class StrangeMath
    {
        // Pure functions, always return the same value given the same imputs
        public int SpecialSum(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int SpecialSum2(int a, int b)
        {
            // We don't like unlucky numbers, lets return 14 instead of 13
            if (a + b == 13) 
                return 14;

            throw new NotImplementedException();
        }

        public int SpecialSum3(int a, int b)
        {
            if (a + b == 13)
                return 14;

            return a + b;
        }

    }
}




