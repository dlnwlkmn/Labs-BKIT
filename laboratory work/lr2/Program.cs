using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2_1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Студент:\tСавельев Алексей");
            Console.WriteLine("Группа:\t\tИУ5-34Б");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Работа с классами на C#");
            Console.ResetColor();
            Rectangle rect;
            Circle circ;
            Squad squad;
            while (true)
            {

                switch(menu())
                {
                    case 1:
                        double width = toDoubleCase("\nВведите ширину:");
                        double height = toDoubleCase("Введите высоту:");
                        rect = new Rectangle(width, height);
                        rect.Print();
                        Console.ReadKey();
                        break;
                    case 2:
                        double sideLength = toDoubleCase("\nВведите сторону квадрата:");
                        squad = new Squad(sideLength);
                        squad.Print();
                        Console.ReadKey();
                        break;
                    case 3:
                        double radius = toDoubleCase("\nВведите радиус:");
                        circ = new Circle(radius);
                        circ.Print();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nКонец...");
                        Console.ReadKey();
                        return 0;
                }
            }
        }

        static int menu()
        {
            int choice;
            string str;
            Console.WriteLine(
                "\nВыберитеГеометрическую фигуру:\n" +
                "1) Прямоугольник\n" +
                "2) Квадрат\n" +
                "3) Круг\n" +
                "4) Завершить"
                );
            str = Console.ReadLine();
            int.TryParse(str, out choice);
            return choice;
        }

        static double toDoubleCase(string cout)
        {
            double doubleCase = 0;
            string inputCase;
            bool stop = false;

            do
            {
                Console.WriteLine(cout);
                inputCase = Console.ReadLine();

                try
                {
                    doubleCase = double.Parse(inputCase);
                    //stop = double.TryParse(inputCase, out doubleCase);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nВы ввели не число: " + e.Message);
                    Console.WriteLine("\nПодробное описание ошибки: ");
                    Console.ResetColor();
                    Console.WriteLine(e.StackTrace + "\n");
                }
                if (doubleCase != 0) { stop = true; }

            } while (!stop);

            return doubleCase;
        }
    }
}
