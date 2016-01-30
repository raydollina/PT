using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split();   
            for (int n = 0; n < token.Length; n++)
            {
                int qwe = 0; 
                int b = int.Parse(token[n]); // изменить на цифры
                for (int i = 1; i <= b; i++) // число от 1 до заданного числа
                {
                    if (b % i == 0) // делиться ли число на что либо
                    {
                        qwe++; 
                    }
                }
                if (cnt < 3) // если число делителей меньше 3, значит число делителей всего 2, это значит число делиться на себя и на 1
                {
                    Console.Write("{0} ", b); // вывести простое число                   
                }
            }
            Console.ReadKey();
        }
    }
}