using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArr = new int[4, 6];
            for (int p = 0; p < myArr.GetLength(0); p++)
            {
                for (int j = 0; j < myArr.GetLength(1); j++)
                {
                    myArr[p, j] = p;
                    Console.Write(myArr[p, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            String[] collection = new string[]
            {"1-й элемент",
            "2-й элемент",
            "3-й элемент"
            };
            int size = collection.Length;
            foreach(String element in collection)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Длина массива="+size);
            Console.WriteLine("Введите номер строки и номер символа, которые хотите изменить, затем символ, который хотите вставить:");
            int el = Convert.ToInt32(Console.ReadLine());
            int start = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            collection[el - 1] = collection[el - 1].Remove(start - 1, 1);
            collection[el - 1] = collection[el - 1].Insert(start - 1, str);
            Console.WriteLine(collection[el - 1]);
            Console.WriteLine();

            int[][] array = new int[3][];
            array[0] = new int[2];
            array[1] = new int[3];
            array[2] = new int[4];
            for (int i=0; i<2;i++)
            {
                array[0][i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<3;i++)
            {
                array[1][i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<4;i++)
            {
                array[2][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.Write(array[0][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(array[1][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(array[2][i] + " ");
            }

            var newArray = new[] { 1, 5.8 };
            var s = "f;llffl;f";

            Console.ReadLine();
        }
    }
}
