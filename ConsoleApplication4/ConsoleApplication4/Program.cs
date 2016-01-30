using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static bool IsPrime(string s)
        {
            //конвертация от типа строки в тип целое число
            int x = int.Parse(s);
            int cnt = 0;
            //подсчет кол-ва делителей отличных от 1 и самого числа
            for (int j = 2; j <= Math.Sqrt(x); ++j)
            {
                if (x % j == 0)
                {
                    cnt++;
                }
            }

            return cnt == 0 && x != 1;
        }
    }
}
