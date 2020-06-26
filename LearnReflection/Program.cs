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

            // использование сборки через Assembly(будет описанно все класы что находяться в сборке)
            //Assembly assembly = ViewMetadataUseReflection.GetAssembly(typeof(TestLibrary.Car));
            //Type[] types = assembly.GetTypes();
            //foreach (var t in types)
            //{
            //    ViewMetadataUseReflection.ListFields(t);
            //    ViewMetadataUseReflection.ListMetods(t);
            //    ViewMetadataUseReflection.AttributesFields(t);

            //}

            // рефлексия через Type (будет описан только класс кар)
            Type type = typeof(TestLibrary.Car);
            ViewMetadataUseReflection.PropertiesFields(type);
            ViewMetadataUseReflection.AttributesFields(type);
            Console.WriteLine(ViewMetadataUseReflection.GetAssembly(typeof(TestLibrary.Car)));
            
            Console.ForegroundColor = ConsoleColor.Red;
            TestAtributRealization testAtribut = new TestAtributRealization("Sasha", 22);
            var e = testAtribut.GetType();
            ViewMetadataUseReflection.AttributesFields(e);
            ViewMetadataUseReflection.ListMetods(e);


            Console.ReadLine();
        }
    }
}
