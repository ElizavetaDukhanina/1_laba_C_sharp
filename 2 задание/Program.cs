using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello world!";       //строковые литералы
            string str2 = "Hi,'Man', txt you";
            string str3 = "This is a text. New string";
            Console.WriteLine(str1 + str2 + str3);  //сцепление (конкатенация) 
            string text1 = string.Copy(str1);       //копирование
            Console.WriteLine(text1);
            Console.WriteLine(str2.Substring(3, 5)); //выделение подстроки

            char[] delims = ".,;:!?\n\xD\xA\" ".ToCharArray();  //разделение строки на слова
            string[] words = str3.Split(delims,
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
                Console.WriteLine(word);

            Console.WriteLine(str2.Insert(9, "Вставка текста"));  //вставка подстроки
            Console.WriteLine(str3.Remove(2, 17));                  //удаление заданной подстроки
            Console.WriteLine($"{str2}. {str1}!");                  //интерполирование строк

            string str4 = " ";
            string str5 = null;
            Console.WriteLine(string.IsNullOrEmpty(str4));          //указывает, действительно ли указанная строка является строкой null?
            Console.WriteLine(string.IsNullOrEmpty(str5));
            Console.WriteLine(str4 + str1);

            StringBuilder sb = new StringBuilder("ABC", 50);
            sb.Remove(1, 1);                 //удаление символов
            sb.Insert(0, 'Z');              //добавление символов в начало
            sb.Append(new char[] { 'D', 'E' });     //добавление символов в конец 
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
