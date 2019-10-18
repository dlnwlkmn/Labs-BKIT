using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biquadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Студент:\tСавельев Алексей");
            Console.WriteLine("Группа:\t\tИУ5-34Б");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Решаем биквадраные уравнения\n");
            Console.ResetColor();
            int stop = 0;
            double a, b, c;
            do
            {
                if(args.Length == 3) //использование аргументов командной строки
                {
                    double.TryParse(args[0], out a);
                    double.TryParse(args[1], out b);
                    double.TryParse(args[2], out c);
                    Console.WriteLine("Аргументы командной строки: a = {0}, b = {1}, c = {2}", a, b, c);
                    Array.Resize(ref args, 0); 
                } else
                {
                    a = toDoubleCase("Введите коэффициент а: ");
                    b = toDoubleCase("Введите коэффициент b: ");
                    c = toDoubleCase("Введите коэффициент c: ");
                }
                if (a == 0 && b == 0 && c == 0) //коэфициенты А и Б и Цэ равны нулю
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите ненулевые коэффициенты");
                    Console.ResetColor();
                    goto Choise;
                }
                if (a == 0 && b == 0) //коэфициенты А и Б равны нулю
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("end:     Корней НЕТ!");
                    Console.ResetColor();
                    goto Choise;
                }
                if ((a == 0 && c == 0) || (b == 0 && c == 0)) //коэфициенты А и Цэ ИЛИ Б и Цэ равны нулю
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("end:     x = 0");
                    Console.ResetColor();
                    goto Choise;
                }
                if (a == 0) //коэфициент А равен нулю
                {
                    if (c < 0)
                    {
                        double root = System.Math.Pow((-c / b), 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("end:     Корни уравнения:    x1 = {0},\tx2 = {1};", root, (-1 * root));
                        Console.ResetColor();
                    }
                    else if (c == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("end:     x = 0");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("end:     Корней НЕТ!");
                        Console.ResetColor();
                    }
                    goto Choise;
                }
                if (b == 0) //коэфициент Б равен нулю
                {
                    if (c < 0)
                    {
                        double root = System.Math.Pow(System.Math.Pow((-c / a), 0.5), 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("end:     Корни уравнения:    x1 = {0},\tx2 = {1};", root, (-1 * root));
                        Console.ResetColor();
                    }
                    else if (c == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("end:     x = 0");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("end:     Корней НЕТ!");
                        Console.ResetColor();
                    }
                    goto Choise;
                }
                if (c == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("footnote:    Попробуйте иные коэффициенты...");
                    Console.ResetColor();
                    goto Choise;
                }

                double D = System.Math.Pow(b, 2) - (4 * a * c);
                Console.WriteLine("Дискриминант: " + D + "\n");

                if (D > 0)
                {
                    double t1 = (-b + Math.Pow(D, 0.5)) / (2 * a); //t - это замена: t=x^2
                    double t2 = (-b - Math.Pow(D, 0.5)) / (2 * a);

                    if (t1 < 0 && t2 < 0) 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("end:     Корней нет!");
                        Console.ResetColor();
                    } else if (t1 < 0 && t2 > 0)
                    {
                        double root = Math.Pow(t2, 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("end:     Корни уравнения:    x1 = {0},\tx2 = {1};", root, (-1 * root));
                        Console.ResetColor();
                    } else if (t2 < 0 && t1 > 0)
                    {
                        double root = Math.Pow(t1, 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("end:     Корни уравнения:    x1 = {0},\tx2 = {1};", root, (-1 * root));
                        Console.ResetColor();
                    } else
                    {
                        double root1 = Math.Pow(t1, 0.5);
                        double root2 = Math.Pow(t2, 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("end:     Корни уравнения:    x1 = {0},\tx2 = {1};", root1, (-1 * root1));
                        Console.WriteLine("                             x3 = {0},\tx4 = {1};", root2, (-1 * root2));
                        Console.ResetColor();
                    }
                }
                else if (D == 0)
                {
                    double t = -b / (2 * a);
                    if (t < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("end:     Корней нет!");
                        Console.ResetColor();
                    } else
                    {
                        double root = Math.Pow(t, 0.5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("end:     Корни уравнения:    x1 = {0},\tx2 = {1};", root, (-1 * root));
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("end:     Действительных корней НЕТ!");
                    Console.ResetColor();
                }

                Choise: //Выйти или Продолжить
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nЕщё раз?");
                Console.ResetColor();
                Console.WriteLine("0) Да\n1) Нет");
                int.TryParse(Console.ReadLine(), out stop);

            } while (stop != 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nКонец...");
            Console.ReadLine();

        }

        static double toDoubleCase(string cout)
        {
            double doubleCase;
            string inputCase;
            bool stop = false;

            do
            {
                Console.WriteLine(cout);
                Console.ResetColor();
                inputCase = Console.ReadLine();

                stop = double.TryParse(inputCase, out doubleCase);
                if (stop == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите коэффициент повторно\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            } while (!stop);
            Console.ResetColor();

            return doubleCase;
        }

        //static double toDoubleCase1(string cout)
        //{
        //    double doubleCase = -111111;
        //    string inputCase;
        //    bool stop = false;

        //    do
        //    {
        //        Console.WriteLine(cout);
        //        inputCase = Console.ReadLine();

        //        try
        //        {
        //            doubleCase = double.Parse(inputCase);
        //            //stop = double.TryParse(inputCase, out doubleCase);
        //        }
        //        catch (Exception e)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("\nВы ввели не число: " + e.Message);
        //            Console.WriteLine("\nПодробное описание ошибки: ");
        //            Console.ResetColor();
        //            Console.WriteLine(e.StackTrace + "\n");
        //        }
        //        if (doubleCase != -111111) { stop = true; }

        //    } while (!stop);

        //    return doubleCase;
        //}
    }
}
