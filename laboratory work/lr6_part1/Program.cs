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
        static void MultOrDevMethodFunc(string str, int i1, int i2, Func<int, int, int> MultOrDevProgram)
        {
            int result = MultOrDevProgram(i1, i2);
            Console.WriteLine(str + result.ToString());
        }
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа 6 часть первая";
            ColorfulPrint("Студент:\tСавельев Алексей\nГруппа:\t\tИУ5-34Б", "Cyan");
            ColorfulPrint("Работа с Делегатами в C#", "Yellow");

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

            MultOrDevMethod("\nУмножаем: ", i1, i2, Multiply);
            MultOrDevMethod("Делим: ", i1, i2, Devide);

            // Экземпляры делегатов
            MultOrDev p1 = new MultOrDev(Multiply);
            MultOrDev p2 = new MultOrDev(Devide);

            MultOrDevMethod("\nУмножение, использую экземпляр делегата: ", i1, i2, Multiply);
            MultOrDevMethod("Деление, использую экземпляр делегата:", i1, i2, Devide);

            MultOrDevMethod("Создание экземпляра делегата на основе лямбда-выражения: ", i1, i2, (x, y) => x * y);

            Console.WriteLine("\n\nИспользование обощенного делегата Func< >");

            MultOrDevMethodFunc("Создание экземпляра делегата на основе метода: ", i1, i2, Multiply);
            MultOrDevMethodFunc("Создание экземпляра делегата на основе лямбда-выражения: ", i1, i2, (x, y) => x * y);

            Console.ReadKey();
        }
        static void ColorfulPrint(string outtext, string color)
        {
            switch (color)
            {
                case "Black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "Cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "DarkBlue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "DarkCyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "DarkGray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "DarkGreen":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "DarkMagenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "DarkRed":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "DarkYellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "Gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "White":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
            Console.WriteLine(outtext);
            Console.ResetColor();
        }
    }
}
