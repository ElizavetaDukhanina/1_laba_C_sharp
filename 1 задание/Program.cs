using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main()
        {
            byte biti = Convert.ToByte(Console.ReadLine());         //0 to 255
            Console.WriteLine(biti);
            bool b = Convert.ToBoolean(biti);                       //true, false
            Console.WriteLine(b);
            sbyte c = Convert.ToSByte(b);                 //-128 to 127
            Console.WriteLine(c);
            char ch = Convert.ToChar(biti);
            Console.WriteLine(ch);
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(i);
            decimal de = Convert.ToDecimal(i);
            Console.WriteLine(de);
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(d);
            uint h = Convert.ToUInt32(b);
            Console.WriteLine(h);
            long l = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(l);
            short shortik = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(shortik);

            float f = (float)d;     //явное приведение
            byte by = (byte)i;
            var f2 = 2.5;        //неявное приведение
            Console.WriteLine(f2.GetType());

            Object g;              //упаковка
            g = 5;
            int k;
            k = (int)g;             //распаковка : int <= object

            int? x = null;          //Nullable переменная
            int? y = 5;
            Console.WriteLine(y ?? x);
            Console.Read();
        }
    }
}
