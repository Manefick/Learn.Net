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
            //Assembly assembly = Assembly.LoadFrom(@"E:\VisualStudio\Learn.Net\TestLibrary\bin\Debug\netstandard2.0\TestLibrary.dll");
            //Type[] types = assembly.GetTypes();
            //foreach (var t in types)
            //{
            //    ViewMetadataUseReflection.ListFields(t);
            //    ViewMetadataUseReflection.ListMetods(t);
            //}

            // использование сборки через Assembly
            Assembly assembly = ViewMetadataUseReflection.GetAssembly(typeof(TestLibrary.Car));
            Type[] types  = assembly.GetTypes();
            foreach (var t in types)
            {
                ViewMetadataUseReflection.ListFields(t);
                ViewMetadataUseReflection.ListMetods(t);
                
            }
            ViewMetadataUseReflection.PropertiesFields(types[0]);

            // рефлексия через Type 
            Type type = typeof(TestLibrary.Car);
            ViewMetadataUseReflection.ListMetods(type);
            Console.WriteLine(ViewMetadataUseReflection.GetAssembly(typeof(TestLibrary.Car)));     
            Console.ReadLine();
        }
    }
}
