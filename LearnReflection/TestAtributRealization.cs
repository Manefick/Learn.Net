using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnReflection
{
    [Male("dkf")]
    class TestAtributRealization
    {
        public string name { get; }
        public int age { get; }
        public TestAtributRealization(string n, int a)
        {
            name = n;
            age = a;
        }
        [Male("Man")]
        public override string ToString()
        {
            return $"{name} {age}";
        }
        public int BirthdayYear()
        {
            Console.WriteLine(2020-age);
            return 2020 - age;
        }
    }
}
