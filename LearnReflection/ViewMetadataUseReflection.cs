﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

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
            foreach(var i in mi)
                Console.WriteLine($"{i.Name}");
        }
        public static void ListFields(Type t)
        {
            var fildName = from n in t.GetFields() select n.Name;
            foreach(var name in fildName)
                Console.WriteLine($"{name}");
        }
    }
}