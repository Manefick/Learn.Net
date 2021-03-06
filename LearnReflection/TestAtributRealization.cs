﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary;

namespace LearnReflection
{
    [Male("dkf")]
    class TestAtributRealization
    {
        public int field;

        public string name { get; }
        [Color]
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
