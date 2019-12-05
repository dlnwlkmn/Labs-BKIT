using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr6_part2
{
    class Program
    {
        
        static void AssemblyInformation()
        {
            ColorfulPrint("Информация о сборке: ", "Green");
            Assembly i = Assembly.GetExecutingAssembly();
            Console.WriteLine("Полное имя:" + i.FullName);
            Console.WriteLine("Исполняемый файл:" + i.Location);
        }
        static void TypeInformation()
        {
            ForResearch obj = new ForResearch();
            Type t = obj.GetType();

            ColorfulPrint("Информация о типе: ", "Green");
            Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
            Console.WriteLine("Пространство имен " + t.Namespace);
            Console.WriteLine("Распологается в сборке " + t.AssemblyQualifiedName);

            ColorfulPrint("\nКонструкторы: ", "Green");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            ColorfulPrint("\nМетоды: ", "Green");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            ColorfulPrint("\nСвойства: ", "Green");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }

            ColorfulPrint("\nПоля данных (публичные): ", "Green");
            foreach (var x in t.GetFields())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nForResearch реализует IComparable -> " +
            t.GetInterfaces().Contains(typeof(IComparable))
            );
        }
        static void InvokeMemberInformation()
        {
            Type t = typeof(ForResearch);
            ColorfulPrint("\nВызываем метод: ", "Green");

            //Создание объекта
            ForResearch fi = (ForResearch)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });

            //Параметры вызова метода
            object[] parameters = new object[] { 3, 2 };
            //Вызов метода
            object Result = t.InvokeMember("Multiply", BindingFlags.InvokeMethod, null, fi, parameters);
            ColorfulPrint("Умножить (3,2) = " + Result, "Yellow");

        }
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа 6 часть Вторая";
            ColorfulPrint("Студент:\tСавельев Алексей\nГруппа:\t\tИУ5-34Б", "Cyan");
            ColorfulPrint("Работа с Рефлексией в C#\n", "Yellow");

            AssemblyInformation();
            TypeInformation();
            InvokeMemberInformation();
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
