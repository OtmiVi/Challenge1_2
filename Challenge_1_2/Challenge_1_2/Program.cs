using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=Int16.Parse(Console.ReadLine());
            
            int pastSum1 = 0;
            int pastSum2 = 1;
            int sum = 0 ;
            for (int i = 0; i < n-1; i++)
            {
                sum = pastSum1 + pastSum2;
                pastSum2 = pastSum1;
                pastSum1 =sum;   
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
