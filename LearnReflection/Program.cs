using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(TestLibrary.Car);
            ViewMetadataUseReflection.ListFields(t);
            ViewMetadataUseReflection.ListMetods(t);

            Console.ReadLine();
        }
    }
}
