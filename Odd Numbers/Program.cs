using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers
{
    public class SumOfOddNumbers
    {
        public static void Main()
        {
            Console.WriteLine("Odd numbers from 0 to 100");
            for (int n = 1; n < (100 + 1); n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                }
               
            }
           
        }
    }
}
