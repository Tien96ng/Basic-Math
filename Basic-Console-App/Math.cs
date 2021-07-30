using System;

namespace Basic_Console_App
{
    public class Math
    {

        public void SayClass()
        {
            Console.WriteLine("Using class Math");
        }

        public int AddTwo(int a, int b)
        {
            return a + b;
        }

        public int SubtractTwo(int a, int b)
        {
            return a - b;
        }

        public int MultiplyTwo(int a, int b)
        {
            return a * b;
        }

        public int SumAll(int[] nums)
        {
            int max = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                max += nums[i];
            }
            return max;
        }

    }
}
