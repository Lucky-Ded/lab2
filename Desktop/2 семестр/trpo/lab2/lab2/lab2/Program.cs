using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            //считывание данных о нажатой клавиши
            ConsoleKeyInfo key = Console.ReadKey();
            
            //получение символа нажатой клавиши (если возможно)
            char ch = key.KeyChar;



            if (ch == '+') Console.WriteLine("{0}", a + b);

            if (ch == '-') Console.WriteLine("{0}", a - b);

            Console.ReadKey();

        }
    }
}
