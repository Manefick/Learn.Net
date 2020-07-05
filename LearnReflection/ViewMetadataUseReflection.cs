using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Security.Cryptography;

namespace LearnReflection
{
    class ViewMetadataUseReflection
    {
        public static Assembly GetAssembly(Type type)
        {
            return type.Assembly;
        }
        
        public static void ListMetods(Type t)
        {
            MethodInfo[] mi = t.GetMethods();
            foreach (var i in mi)
            {
                foreach(var atr in i.GetCustomAttributes())
                {
                    Console.WriteLine($"{i.Name}  Atribute: {atr}");
                }
            }
        }
        public static void ListFields(Type t)//почему не отображаеться ничего
        {
            var fildName = from n in t.GetFields() select n.Name;
            foreach(var name in fildName)
                Console.WriteLine($"{name}");
        }
        public static void PropertiesFields(Type t)
        {
            foreach (var atr in t.GetProperties())
                foreach (var atrib in atr.GetCustomAttributes())
                {
                    Console.WriteLine("{0} {1} Attribute: {2}  ", atr.Name, atr.PropertyType, atrib);
                }
        }
        public static void AttributesFields(Type t)
        {
            var a = t.GetCustomAttributes();
            if (a.Any(i => i.GetType() == typeof(TestLibrary.ColorAttribute)))
            {
                foreach(var q in a)
                    Console.WriteLine($"Attribute: {q}");//почему отображаеться какаято хуйня
            }
            Console.WriteLine(a);
        }
    }
}
