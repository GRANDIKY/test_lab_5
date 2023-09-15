using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 0; i < 5; i++)
            {
                result += SumDigit(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(result);
        }

        static int SumDigit(int N)
        {
            int S = 0;
            while(N > 0)
            {
                S += N % 10;
                N /= 10;
            }
            return S;
        }
    }   
}
