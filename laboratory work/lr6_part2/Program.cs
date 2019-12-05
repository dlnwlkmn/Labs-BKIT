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
        static void Main(string[] args)
        {
            AssemblyInformation();
        }
    }
}
