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
            Console.WriteLine("Информация о сборке:");
            Assembly i = Assembly.GetExecutingAssembly();
            Console.WriteLine("Полное имя:" + i.FullName);
            Console.WriteLine("Исполняемый файл:" + i.Location);
        }
        static void TypeInformation()
        {
            ForResearch obj = new ForResearch();
            Type t = obj.GetType();

            Console.WriteLine("\nИнформация о типе:");
            Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
            Console.WriteLine("Пространство имен " + t.Namespace);
            Console.WriteLine("Распологается в сборке " + t.AssemblyQualifiedName);

            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nПоля данных (public):");
            foreach (var x in t.GetFields())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nForResearch реализует IComparable -> " +
            t.GetInterfaces().Contains(typeof(IComparable))
            );
        }

        static void Main(string[] args)
        {
            AssemblyInformation();
            TypeInformation();
            Console.ReadKey();
        }
    }
}
