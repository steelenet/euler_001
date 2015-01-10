using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            Console.WriteLine("Press a key to start.");
            Console.ReadKey();
            while (i < 1000)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = i + sum;
                    i++;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
