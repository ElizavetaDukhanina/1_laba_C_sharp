using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Func1();
            Func2();
            void Func1()
            {
                checked
                {
                    int max = int.MaxValue;
                    Console.WriteLine($"{max}");
                }
            }
            void Func2()
            {
                int min = int.MinValue;
                Console.WriteLine($"{min}");
            }
            
            Console.ReadLine();
            
        }
    }
}
