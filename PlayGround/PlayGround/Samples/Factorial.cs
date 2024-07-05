using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Samples
{
    public static class Factorial 
    {
        public static void FindFactorial(this SampleObject sample)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            var output = Fact(n);
            Console.WriteLine($"The factorial is {output}");
        } 

        private static int Fact(int num)
        {
            if (num ==0 || num == 1)
            {
                return 1;
            }
            else
            {
                return num * Fact(num - 1);
            }
        }
    }
}
