using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230717_02
{
    internal class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int c = 0;
            c = y;
            y = x;
            x = c;
        }

        static void Calculate(int a, int b, out int outSum, out float outAvg)
        {
            outSum = a + b;
            outAvg = (float)outSum / 2.0f;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 10;
            int d = 20;

            Swap(ref a, ref b);
            Swap(ref c, ref d);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            int sum = 0;
            float avg = 0;
            Calculate(a, b, out sum, out avg);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
        }
    }
}
