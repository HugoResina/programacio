using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate
{
    public static class Helper
    {
        public static double Exponent(int x, int y)
        {
            return Math.Pow(x , y);
        }
        public static double SquareR(int x)
        { 
            return Math.Sqrt(x); 
        }
        public static double Avarage(int[] ints)
        {
            double total = 0;
            foreach (int i in ints)
            {
                total += i;
            }
            return total/ints.Length;
        }
        public static string EvenOrOdd(int x)
        {
           return x % 2 == 0 ? ""+ (x*2): "el número " + x + " és senar";
        }
        public static int Fibonacci(int times)
        {
            if (times == 0) return 0;
            if (times == 1) return 1;
            return Fibonacci(times - 1) + Fibonacci(times - 2);
        }
    }
}
