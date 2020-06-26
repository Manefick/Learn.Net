using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LearnReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Использование динамической загрузки сборок
            Assembly assembly = Assembly.LoadFrom(@"E:\VisualStudio\Learn.Net\TestLibrary\bin\Debug\netstandard2.0\TestLibrary.dll");
            Type[] types = assembly.GetTypes();
            foreach (var t in types)
            {
                ViewMetadataUseReflection.ListFields(t);
                ViewMetadataUseReflection.ListMetods(t);
            }
            Console.ReadLine();
        }
    }
}
