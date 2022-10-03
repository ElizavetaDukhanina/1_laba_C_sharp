using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {0, 1, 5, 9, 4, 6, 7, 2, 3 };
            string str = "Fld";
            Func1(numbers, str);
            (int,int,int,string) Func1(int[]numbers1,string str1)
            {
                int max = 0, min = 0, sum = 0;
                for(int i=0;i<numbers1.Length;i++)
                {
                    if (numbers1[i] > max) max = numbers1[i];
                    if (numbers1[i] < min) min = numbers1[i];
                    sum += numbers1[i];
                }
                Console.WriteLine($"{max},{min},{sum},{str1.Substring(0, 1)}");
                Console.ReadLine();
                return (max, min, sum, str1.Substring(0, 1));
                
            }
        }
    }
}
