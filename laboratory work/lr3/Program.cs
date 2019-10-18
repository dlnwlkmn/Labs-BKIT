using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Студент:\tСавельев Алексей");
            Console.WriteLine("Группа:\t\tИУ5-34Б");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Работа со списками и коллекциями C#");
            Console.ResetColor();

            double[,] dimensions = new double[3, 2];
            string str;
            int stop;
            do
            {
                Console.WriteLine("Введите длину и ширину Прямоугольника (через Enter:)");
                str = Console.ReadLine();
                double.TryParse(str, out dimensions[0, 0]);
                str = Console.ReadLine();
                double.TryParse(str, out dimensions[0, 1]);
                Console.WriteLine("Введите длину стороны Квадрата:");
                str = Console.ReadLine();
                double.TryParse(str, out dimensions[1, 0]);
                Console.WriteLine("Введите длину стороны Квадрата:");
                str = Console.ReadLine();
                double.TryParse(str, out dimensions[2, 0]);

                Rectangle rect = new Rectangle(dimensions[0, 0], dimensions[0, 1]);
                Squad squad = new Squad(dimensions[2, 0]);
                Circle circ = new Circle(dimensions[1, 0]);
                rect.Print();
                squad.Print();
                circ.Print();

                // Выйти или продолжить
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nЗавершить?");
                Console.ResetColor();
                Console.WriteLine("0) Нет\n1) Да");
                int.TryParse(Console.ReadLine(), out stop);

            } while (stop != 1);


            Console.ReadKey();

        }
    }
}
