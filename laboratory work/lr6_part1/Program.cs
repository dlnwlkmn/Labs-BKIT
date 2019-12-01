using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr6_part1
{
    class Program
    {
        delegate int MultOrDev(int p1, int p2);
        static int Multiply(int p1, int p2) { return p1 * p2; }
        static int Devide(int p1, int p2) { return p1 / p2; }
        static void MultOrDevMethod(string str, int i1, int i2, MultOrDev MultOrDevProgram)
        {
            int result = MultOrDevProgram(i1, i2);
            Console.WriteLine(str + result.ToString());
        }
        static void Main(string[] args)
        {
            string str1;
            string str2;
            Console.Write("Введите первый аргумент: ");
            str1 = Console.ReadLine();
            Console.Write("Введите второй аргумент: ");
            str2 = Console.ReadLine();
            while(str2 == "0")
            {
                Console.Write("Введите второй аргумент повторно (неравный нулю): ");
                str2 = Console.ReadLine();
            }
            int i1 = int.Parse(str1);
            int i2 = int.Parse(str2);
            Console.WriteLine("\n");

            MultOrDevMethod("Умножаем: ", i1, i2, Multiply);
            MultOrDevMethod("Делим: ", i1, i2, Devide);

            Console.ReadKey();
        }
    }
}
